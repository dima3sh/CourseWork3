using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Presenters
{
    public interface ICarPresenter : IPresenter
    {
        bool AddCar(Car car);
        bool EditCar(Car car, string number);
        List<Category> GetCategoriesByType(TypeCar type);

        List<TypeCar> GetCarTypes();

        Category FindCategoryById(string number);
    }
}
