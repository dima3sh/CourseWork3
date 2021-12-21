using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Presenters;
using System;
using System.Windows.Forms;

namespace AutoPark.View
{
    public partial class EditCategoryForm : Form, ICategoryView
    {
        private Category _oldCategory;

        public EditCategoryForm(Category category)
        {
            InitializeComponent();
            _oldCategory = category;
        }

        public ICategoryPresenter Presenter { get; set; }
        public void CloseForm()
        {
            Close();
        }

        public void ShowForm()
        {
            ShowDialog();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Presenter.GetCategories().ToArray());
            comboBox1.SelectedItem = _oldCategory;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;
            if (category != null)
            {
                TxtBoxName.Text = category.Name;
                ComboBoxType.DataSource = Presenter.GetCarTypes();
                ComboBoxType.SelectedItem = category.Type;
                ValidateUpdateForm();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;
            comboBox1.IsValid = category != null;
            if (ValidateDeleteForm())
            {
                if (Presenter.DeleteCategory(category.Id))
                {
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category obj = (Category)comboBox1.SelectedItem;
            if (ValidateUpdateForm())
            {
                Category category = new Category();
                category.Id = obj.Id;
                category.Name = TxtBoxName.Text.Trim();
                category.Type = (TypeCar)ComboBoxType.SelectedItem;
                Presenter.UpdateCategory(category);
                Close();
            }          
        }

        private bool ValidateDeleteForm() {
            InvalidCategoriesText.Text = Properties.Resources.SelectCategory;
            return comboBox1.SelectedItem != null;
        }

        private bool ValidateUpdateForm() {
            comboBox1.IsValid = comboBox1.SelectedItem != null;
            ComboBoxType.IsValid = ComboBoxType.SelectedItem != null;
            TxtBoxName.IsValid = TxtBoxName.Text.Trim() != "";
            ShowInvalidText();
            return comboBox1.IsValid && ComboBoxType.IsValid && TxtBoxName.IsValid;
        }

        private void ShowInvalidText() {
            InvalidCategoriesText.Text = !comboBox1.IsValid ? Properties.Resources.SelectCategory : "";
            InvalidCategory.Text = !ComboBoxType.IsValid ? Properties.Resources.InvalidTypeCar : "";
            InvalidNameText.Text = !TxtBoxName.IsValid ? Properties.Resources.InvalidCategoryName : "";
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxType.IsValid = ComboBoxType.SelectedItem != null;
            ShowInvalidText();
        }
    }
}
