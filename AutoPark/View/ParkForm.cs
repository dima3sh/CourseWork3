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
    public partial class ParkForm : Form, IParkView
    {
        public IParkPresenter Presenter { get; set; }
        public ParkForm()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void showListView(object sender, EventArgs e) {            
            UpdateParkView(Presenter.GetCars());
        }

        public void UpdateParkView(List<string[]> cars)
        {
            listView1.Items.Clear();
            foreach (string[] car in cars)
            {
                listView1.Items.Add(new ListViewItem(car));
            }
        }

        public void ShowForm()
        {
            Application.Run(this);
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void ParkForm_Load(object sender, EventArgs e)
        {

        }

        private void ParkForm_Load_1(object sender, EventArgs e)
        {
            showListView(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.ShowCarView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string number = listView1.SelectedItems[0].Text;
            Presenter.ShowCarView(number);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string number = listView1.SelectedItems[0].Text;
            Presenter.DeleteCar(number);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presenter.ShowAddCategoryView();
        }

        private void BtnEditCategory_Click(object sender, EventArgs e)
        {
            Presenter.ShowEditCategoryView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string number = textBox1.Text.Trim();
            if (number != "")
            {
                List<string[]> cars = Presenter.GetCarsByPartNumber(number);
                UpdateParkView(cars);
            }
            else
            {
                showListView(sender, e);
            }
        }
    }
}
