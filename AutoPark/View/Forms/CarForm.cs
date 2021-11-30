using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Presenters;
using AutoPark.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPark
{
    public partial class CarForm : Form, ICarView
    {
        private bool _isEditForm;
        private string _oldNumber;
        private string _oldCategory;

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
            button1.Text = "Edit";
            CarModel.Text = car.Model;
            CarNumber.Text = car.Number;
            _oldNumber = car.Number;            
            _isEditForm = true;
            ComboBoxTypeCar.Enabled = false;
            _oldCategory = car.CategoryId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadTypeCar(object sender, EventArgs e)
        {
            ComboBoxTypeCar.DataSource = Presenter.GetCarTypes();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            if (_isEditForm)
            {
                Presenter.EditCar(car, _oldNumber);
                this.Close();
            } else if (Presenter.AddCar(car)) {
                this.Close();
            }
        }

        private string GetCategoryId() {
            Category category = (Category)CategoryComboBox.SelectedItem;

            return category != null ? category.Id : "";
            
        }

        private void ComboBoxTypeCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryComboBox.Items.Clear();
            TypeCar type = (TypeCar)ComboBoxTypeCar.SelectedItem;
            CategoryComboBox.Items.AddRange(Presenter.GetCategoriesByType(type).ToArray());
            CategoryComboBox.SelectedItem = Presenter.FindCategoryById(_oldCategory);
            
        }
    }
}
