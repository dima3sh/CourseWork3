using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Presenters
{
    public interface ICategoryPresenter : IPresenter
    {
        void AddCategory(Category category);

        List<Category> GetCategories();

        bool DeleteCategory(string categoryId);

        void UpdateCategory(Category category);

        List<TypeCar> GetCarTypes();
    }
}
