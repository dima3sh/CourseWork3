using AutoPark.Entity;
using AutoPark.Model.services;
using AutoPark.View;
using AutoPark.View.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;

namespace AutoPark.Presenters
{
    public class ParkPresenter : IParkPresenter
    {
        private IParkView _view;
        private IService _service;

        public ParkPresenter(IParkView view, IService service) {
            _view = view;
            _service = service;
            _service.GetCars().CollectionChanged += UpdateParkForm;
            _service.GetCategories().CollectionChanged += UpdateParkForm;
            _service.GetPictures().CollectionChanged += UpdateParkForm;
        }

        public void CloseForm()
        {
            _view.CloseForm();
        }

        private void UpdateParkForm(object sender, NotifyCollectionChangedEventArgs e) {
            _view.UpdateParkView();
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

        public void ShowCategoriesView()
        {
            ShowCategoryForm(new CategoriesForm());
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

        public Bitmap FindPictureByNumber(string number) {
            CarPicture img = _service.GetImageByNumber(number);
            return img != null ? img.Picture : null;
        }

        private List<string[]> ConvertCars(ICollection cars) {
            List<string[]> result = new List<string[]>();
            foreach (Car car in cars)
            {
                Category category = _service.FindCategoryById(car.CategoryId);
                string[] s = new string[5];
                s[0] = "";
                s[1] = car.Number;
                s[2] = car.Model;
                s[3] = category != null ? category.Name : "";
                s[4] = category != null ? category.Type.ToString() : "";
                result.Add(s);
            }
            return result;
        }
    }
}
