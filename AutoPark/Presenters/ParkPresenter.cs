using AutoPark.Entity;
using AutoPark.Model;
using AutoPark.Model.services;
using AutoPark.View;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Presenters
{
    class ParkPresenter : IParkPresenter
    {
        private IParkView _view;
        private IService _service;

        public ParkPresenter(IParkView view, IService service) {
            _view = view;
            _service = service;
            _service.GetCars().CollectionChanged += UpdateParkForm;
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        private static void UpdateParkForm(object sender, NotifyCollectionChangedEventArgs e) {
            switch (e.Action) {
                case NotifyCollectionChangedAction.Add:
                    
                    break;
            }    
        }

        public void ShowCarView()
        {
            CarForm carForm = new CarForm();
            ICarPresenter carPresenter = new CarPresenter(carForm, _service);
            carForm.Presenter = carPresenter;
            carForm.ShowForm();
        }

        public void ShowForm()
        {
            _view.ShowForm();
        }

        public List<string[]> GetCars()
        {
            List<string[]> result = new List<string[]>();
            foreach (Car car in _service.GetCars()) {
                string[] s = new string[3];
                s[0] = car.Number;
                s[1] = car.Model;
                s[2] = car.Category;
                result.Add(s);
            }
            return result;
        }
    }
}
