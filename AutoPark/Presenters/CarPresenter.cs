using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Model.services;
using AutoPark.View;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

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

        public void AddCar(Car car)
        {
            if (_service.addCar(car))
            {
                _view.SaveImage(car.Number);
                _view.CloseForm();
                _view.ShowMessage(Properties.Resources.AddCarResponse);
            }
            else {
                _view.ShowMessage(Properties.Resources.AddCarBadResponse);   
            }
        }

        public void CloseForm()
        {
            _view.CloseForm();
        }

        public List<Category> GetCategoriesByType(TypeCar type)
        {               
            return _service.GetCategoriesByType(type).ToList();
        }

        public void EditCar(Car request, string number)
        {
            if (_service.EditCar(request, number)) {
                _view.SaveImage(number);
                _view.CloseForm();
                _view.ShowMessage(Properties.Resources.EditCarResponse);
            }
            else
            {
                _view.ShowMessage(Properties.Resources.EditCarBadResponce);
            }
        }

        public void ShowForm()
        {
            _view.ShowForm();
        }
        
        public Category FindCategoryById(string number)
        {
            return _service.FindCategoryById(number);
        }

        public List<TypeCar> GetCarTypes()
        {
            return _service.GetCarTypes();
        }

        
        public void SaveCarImage(Bitmap image, string number) {
            if (image != null && number != null && number.Trim() != "")
            {
                CarPicture img = new CarPicture();
                img.Picture = image;
                img.Number = number;
                _service.SavePicture(img);
            }
        }

        public bool HasImage(string number) {
            return _service.HasCarImage(number);
        }
    }
}
