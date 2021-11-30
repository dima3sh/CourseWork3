using AutoPark.Entity;
using AutoPark.Model;
using AutoPark.Model.services;
using AutoPark.View;
using System;
using System.Collections;
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
            _service.GetCategories().CollectionChanged += UpdateParkForm;
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        private void UpdateParkForm(object sender, NotifyCollectionChangedEventArgs e) {
            _view.UpdateParkView(GetCars());
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

        public void DeleteCar(string number) {
            _service.DeleteCar(number);
        }

        public List<string[]> GetCars()
        {
            return ConvertCars(_service.GetCars());
        }

        public void ShowCarView(string number)
        {
            Car car = _service.FindCarByNumber(number);            
            CarForm carForm = new CarForm(car);
            ICarPresenter carPresenter = new CarPresenter(carForm, _service);
            carForm.Presenter = carPresenter;
            carForm.ShowForm();
        }

        public void ShowAddCategoryView()
        {
            ShowCategoryForm(new AddCategoryForm());
        }
        public void ShowEditCategoryView()
        {
            ShowCategoryForm(new EditCategoryForm());
        }

        private void ShowCategoryForm(ICategoryView categoryView) {
            ICategoryPresenter carPresenter = new CategoryPresenter(categoryView, _service);
            categoryView.Presenter = carPresenter;
            categoryView.ShowForm();
        }

        public List<string[]> GetCarsByPartNumber(string number)
        {
            return ConvertCars(_service.FindCarsByPartNumber(number));
        }

        private List<string[]> ConvertCars(ICollection cars) {
            List<string[]> result = new List<string[]>();
            foreach (Car car in cars)
            {
                string[] s = new string[4];
                s[0] = car.Number;
                s[1] = car.Model;
                s[2] = _service.FindCategoryById(car.CategoryId) != null ? _service.FindCategoryById(car.CategoryId).Name : "";
                s[3] = car.Type.ToString();
                result.Add(s);
            }
            return result;
        }
    }
}
