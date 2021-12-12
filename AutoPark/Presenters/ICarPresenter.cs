using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System.Collections.Generic;
using System.Drawing;

namespace AutoPark.Presenters
{
    public interface ICarPresenter : IPresenter
    {
        void AddCar(Car car);
        void EditCar(Car car, string number);
        List<Category> GetCategoriesByType(TypeCar type);

        List<TypeCar> GetCarTypes();

        Category FindCategoryById(string number);

        void SaveCarImage(Bitmap image, string path);

        bool HasImage(string number);
    }
}
