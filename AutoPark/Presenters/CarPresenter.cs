using AutoPark.Entity;
using AutoPark.Entity.Enums;
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

        public List<Category> GetCategoriesByType(TypeCar type)
        {
            return _service.GetCategoriesByType(type).ToList();
        }

        public bool EditCar(Car request, string number)
        {
            if (request.CategoryId.Trim() != "" && request.Number.Trim() != "" && request.Model.Trim() != "") {
                _service.EditCar(request, number);
                return true;
            }
            return false;
        }

        public void ShowForm()
        {
            throw new NotImplementedException();
        }

        public Category FindCategoryById(string number)
        {
            return _service.FindCategoryById(number);
        }

        public List<TypeCar> GetCarTypes()
        {
            return _service.GetCarTypes();
        }
    }
}
