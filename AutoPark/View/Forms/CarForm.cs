using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Model.Utils;
using AutoPark.Presenters;
using AutoPark.View;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoPark
{
    public partial class CarForm : Form, ICarView
    {
        private bool _isEditForm; 
        private string _oldNumber;
        private string _oldCategory;
        private string _imagePath;
        private Bitmap _image;

        public ICarPresenter Presenter { get; set; }

        public CarForm()
        {
            InitializeComponent();
            _isEditForm = false;
            _oldNumber = null;
            Load += LoadTypeCar;
        }

        public CarForm(Car car)
        {
            InitializeComponent();
            FillFieldEditCar(car);
            _oldNumber = car.Number;            
            _isEditForm = true;    
            _oldCategory = car.CategoryId;
            Load += LoadCategory;
        }

        private void LoadTypeCar(object sender, EventArgs e)
        {
            ComboBoxTypeCar.DataSource = Presenter.GetCarTypes();            
        }

        private void LoadCategory(object sender, EventArgs e)
        {
            Category category = Presenter.FindCategoryById(_oldCategory);
            LoadCategories(category.Type);
            CategoryComboBox.SelectedItem = category;
            ComboBoxTypeCar.Items.Add(category.Type);
            ComboBoxTypeCar.SelectedItem = category.Type;
            if (Presenter.HasImage(_oldNumber))
            {
                labelImageName.Text = "Has Image";
            }
        }

        public void ShowForm()
        {
            ShowDialog();
        }

        public void CloseForm()
        {
            Close();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Car car = GetCar();
                if (_isEditForm)
                {
                    Presenter.EditCar(car, _oldNumber);
                }
                else
                {
                    Presenter.AddCar(car);
                }
            } 
        }

        private string GetCategoryId() {
            Category category = (Category)CategoryComboBox.SelectedItem;
            return category != null ? category.Id : "";            
        }

        private void ComboBoxTypeCar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CategoryComboBox.Items.Clear();
            TypeCar type = (TypeCar)ComboBoxTypeCar.SelectedItem;
            ComboBoxTypeCar.IsValid = true;
            InvalidTypeBox.Text = "";
            LoadCategories(type);
            CategoryComboBox.SelectedItem = Presenter.FindCategoryById(_oldCategory);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream  myStream;
            OpenFileDialog  openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Properties.Resources.InitialDirectoryPath;
            openFileDialog1.Filter = "Image files (*.*)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    _imagePath = openFileDialog1.SafeFileName;
                    _image = new Bitmap(Image.FromStream(myStream), 40, 40);                    
                    labelImageName.Text = _imagePath;
                    myStream.Close();
                }
            }
        }

        private Car GetCar() { 
            Car car;
            if (((TypeCar)ComboBoxTypeCar.SelectedItem).Equals(TypeCar.PASSENGER_CAR))
            {
                car = new PassengerCar();
            }
            else {
                car = new Truck();
            }
            
            car.Number = CarNumber.Text;
            car.Model = CarModel.Text;
            car.CategoryId = GetCategoryId();           
            return car;
        }

        public void SaveImage(string number) {
            Presenter.SaveCarImage(_image, number);
        }

        private void LoadCategories(TypeCar type) {
            CategoryComboBox.Items.AddRange(Presenter.GetCategoriesByType(type).ToArray());
        }

        private void FillFieldEditCar(Car car) {
            if (car != null) {
                CarModel.Text = car.Model;
                CarNumber.Text = car.Number;
            }
            button1.Text = "Edit";
            ComboBoxTypeCar.Enabled = false;
        }

        private void CarModel_TextChanged_1(object sender, EventArgs e)
        {
            CarModel.IsValid =  ValidaterUtil.IsValidString(CarModel.Text, "^.*$") || CarModel.Text.Trim() == "";
            ShowInvalidText();
        }

        private void CarNumber_TextChanged(object sender, EventArgs e)
        {
            CarNumber.IsValid = ValidaterUtil.IsValidString(CarNumber.Text, "^[A-Z0-9-]{4,10}$") || CarNumber.Text.Trim() == "";
            ShowInvalidText();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryComboBox.IsValid = true;
            InvalidCategoryText.Text = "";
        }

        private void ShowInvalidText() {
            InvalidModelText.Text = !CarModel.IsValid ? Properties.Resources.InvalidModelName : "";
            InvalidCarNumberText.Text = !CarNumber.IsValid ? Properties.Resources.InvalidCarNumber : "";
            InvalidCategoryText.Text = !CategoryComboBox.IsValid ? Properties.Resources.SelectCategory : "";
            InvalidTypeBox.Text = !ComboBoxTypeCar.IsValid ? Properties.Resources.InvalidTypeCar : "";
        }

        private bool ValidateForm() {
            ComboBoxTypeCar.IsValid = ComboBoxTypeCar.SelectedItem != null;
            CategoryComboBox.IsValid = CategoryComboBox.SelectedItem != null;
            CarModel.IsValid = CarModel.IsValid && CarModel.Text.Trim() != "";
            CarNumber.IsValid = CarNumber.IsValid && CarNumber.Text.Trim() != "";
            ShowInvalidText();
            return CarModel.IsValid && CarModel.Text.Trim() != "" && CarNumber.IsValid && CarNumber.Text.Trim() != "" && CategoryComboBox.SelectedItem != null;
        }
    }
}
