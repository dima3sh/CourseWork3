using AutoPark.Model;
using AutoPark.Model.services;
using AutoPark.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPark
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ParkForm park = new ParkForm();
            IParkPresenter presenter = new ParkPresenter(park, new ParkService());
            park.Presenter = presenter;
            presenter.ShowForm();
        }
    }
}
