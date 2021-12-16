using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Presenters;
using System;
using System.Windows.Forms;

namespace AutoPark.View
{
    public partial class AddCategoryForm : Form, ICategoryView
    {
        public AddCategoryForm()
        {
            InitializeComponent();
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ComboboxType.DataSource = Presenter.GetCarTypes();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Category category = new Category();
                category.Name = TxtBoxName.Text.Trim();
                category.Type = (TypeCar)ComboboxType.SelectedItem;
                Presenter.AddCategory(category);
            }            
        }

        private bool ValidateForm() {
            TxtBoxName.IsValid = TxtBoxName.IsValid && TxtBoxName.Text.Trim() != "";
            ComboboxType.IsValid = ComboboxType.SelectedItem != null;
            ShowInvalidText();
            return TxtBoxName.IsValid && ComboboxType.IsValid;
        }

        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            InvalidCategoryText.Text = "";
        }

        private void ShowInvalidText() {
            InvalidCategoryText.Text = !TxtBoxName.IsValid ? Properties.Resources.InvalidCategoryName : "";
            InvalidCarType.Text = !ComboboxType.IsValid ? Properties.Resources.InvalidTypeCar : "";
        }

        private void ComboboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInvalidText();
        }
    }
}
