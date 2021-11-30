using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Model.services
{
    interface IService
    {
        bool addCar(Car car);

        ObservableCollection<Car> GetCars();

        ObservableCollection<Category> GetCategories();

        List<Category> GetCategoriesByType(TypeCar type);

        Category FindCategoryById(string id);

        Car FindCarByNumber(string number);

        List<Car> FindCarsByPartNumber(string number);

        void EditCar(Car request, string number);

        void DeleteCar(string number);

        bool AddCategory(Category category);

        bool DeleteCategory(string categoryId);

        void UpdateCategory(Category category, string number);

        List<TypeCar> GetCarTypes();
    }
}
