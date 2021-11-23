using AutoPark.Entity;
using AutoPark.Model.services;
using AutoPark.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Presenters
{
    class CarPresenter : ICarPresenter
    {
        private ICarView _view;
        private IService _service;
        private CarForm carForm;

        public CarPresenter(ICarView carForm, IService service)
        {
            this._view = carForm;
            this._service = service;
        }

        public bool AddCar(Car car)
        {
            return _service.addCar(car);
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void ShowForm()
        {
            throw new NotImplementedException();
        }
    }
}
