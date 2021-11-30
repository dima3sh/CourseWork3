using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Show();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ComboboxType.DataSource = Presenter.GetCarTypes();            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtBoxName.Text.Trim() != "") {
                Category category = new Category();
                category.Name = TxtBoxName.Text.Trim();
                category.Type = (TypeCar)ComboboxType.SelectedItem;
                Presenter.AddCategory(category); 
                
            }
        }

        private void ComboboxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
