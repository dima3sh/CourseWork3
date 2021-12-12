using AutoPark.Entity;
using AutoPark.Entity.Enums;
using AutoPark.Model.services;
using AutoPark.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoPark.Presenters
{
    class CategoryPresenter : ICategoryPresenter
    {
        private ICategoryView _view;
        private IService _service;

        public CategoryPresenter(ICategoryView carForm, IService service)
        {
            _view = carForm;
            _service = service;
        }

        public void AddCategory(Category category)
        {
            if (_service.AddCategory(category)) {
                CloseForm();
                _view.ShowMessage(Properties.Resources.AddCategoryResponse);
            }
            else
            {
                _view.ShowMessage(Properties.Resources.AddCategoryBadResponse);
            }
        }

        public void CloseForm()
        {
            _view.CloseForm();
        }

        public List<Category> GetCategories()
        {
            return _service.GetCategories().ToList();
        }

        public void ShowForm()
        {
            _view.ShowForm();
        }

        public bool DeleteCategory(string categoryId) {
            try
            {
               return _service.DeleteCategory(categoryId);
            }
            catch (ArgumentException ex) {
                _view.ShowMessage(ex.Message);
                return false;
            } 
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                if (_service.UpdateCategory(category, category.Id)) {
                    CloseForm();
                    _view.ShowMessage(Properties.Resources.UpdateCategoryResponse);
                }
                else
                {
                    _view.ShowMessage(Properties.Resources.UpdateCategoryBadResponse);
                }
            }
            catch (ArgumentException e) {
                _view.ShowMessage(e.Message);
            }
        }

        public List<TypeCar> GetCarTypes()
        {
            return _service.GetCarTypes();
        }
    }
}
