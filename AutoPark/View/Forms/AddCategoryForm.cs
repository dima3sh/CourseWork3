using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Model.Utils;
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
            if (ValidaterUtil.IsValidCategoryName(TxtBoxName.Text))
            {
                Category category = new Category();
                category.Name = TxtBoxName.Text.Trim();
                category.Type = (TypeCar)ComboboxType.SelectedItem;
                Presenter.AddCategory(category);
            }
            else {
                ShowMessage(Properties.Resources.InvalidCategoryName);
            }
        }
    }
}
