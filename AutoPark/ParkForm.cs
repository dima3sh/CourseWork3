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
            Load += showListView;
        }


        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void showListView(object sender, EventArgs e) {
            foreach (string[] car in Presenter.GetCars()) {
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.ShowCarView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }
    }
}
