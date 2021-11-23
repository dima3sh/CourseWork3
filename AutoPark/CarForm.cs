using AutoPark.Entity;
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
        public ICarPresenter Presenter { get; set; }

        public CarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

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
            PassengerCar passengerCar = new PassengerCar();
            passengerCar.Number = CarNumber.Text;
            passengerCar.Model = CarModel.Text;
            passengerCar.Category = CarCategory.Text;
            if (Presenter.AddCar(passengerCar)) {
                new MessageBox();
                this.Close();
            }
        }
    }
}
