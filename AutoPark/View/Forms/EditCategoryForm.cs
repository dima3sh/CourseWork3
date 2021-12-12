using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Model.Utils;
using AutoPark.Presenters;
using System;
using System.Windows.Forms;

namespace AutoPark.View
{
    public partial class EditCategoryForm : Form, ICategoryView
    {
        public EditCategoryForm()
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

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Presenter.GetCategories().ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;
            if (category != null)
            {
                TxtBoxName.Text = category.Name;
                ComboBoxType.DataSource = Presenter.GetCarTypes();
                ComboBoxType.SelectedItem = category.Type;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;
            if (category != null)
            {
                if (Presenter.DeleteCategory(category.Id))
                {
                    Close();
                }
            }
            else {
                ShowMessage("Category isn't selected!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category obj = (Category)comboBox1.SelectedItem;
            string name = TxtBoxName.Text.Trim();
            if (obj != null && ValidaterUtil.IsValidString(name))
            {
                Category category = new Category();
                category.Id = obj.Id;
                category.Name = name;
                category.Type = (TypeCar)ComboBoxType.SelectedItem;
                Presenter.UpdateCategory(category);
                Close();
            }
            else {
                ShowMessage(Properties.Resources.InvalidData);
            }
        }
    }
}
