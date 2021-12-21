using AutoPark.Entity;
using AutoPark.Presenters;
using System;
using System.Windows.Forms;

namespace AutoPark.View.Forms
{
    public partial class CategoriesForm : Form, ICategoryView
    {
        public ICategoryPresenter Presenter { get; set; }

        public CategoriesForm()
        {
            InitializeComponent();
            Load += LoadCategories;
        }

        private void LoadCategories(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Presenter.GetCategories().ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
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

        public void UpdateForm() {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Presenter.GetCategories().ToArray());
            buttonEdit.Enabled = comboBox1.SelectedItem != null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = comboBox1.SelectedItem != null;           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Presenter.ShowEditCategoryView((Category)comboBox1.SelectedItem);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Presenter.ShowAddCategoryView();
        }       
    }
}
