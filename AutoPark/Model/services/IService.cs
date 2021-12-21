using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutoPark.Model.services
{
    public interface IService
    {
        bool addCar(Car car);

        void DeleteCar(string number);

        bool EditCar(Car request, string number);

        ObservableCollection<Car> GetCars();

        Car FindCarByNumber(string number);

        List<Car> FindCarsByPartNumber(string number);

        bool AddCategory(Category category);

        bool DeleteCategory(string categoryId);

        bool UpdateCategory(Category category, string number);

        ObservableCollection<Category> GetCategories();

        Category FindCategoryById(string id);

        List<TypeCar> GetCarTypes();

        List<Category> GetCategoriesByType(TypeCar type);

        ObservableCollection<CarPicture> GetPictures();

        CarPicture GetImageByNumber(string number);

        void SavePicture(CarPicture image);

        void UpdatePicture(CarPicture picture);

        bool HasCarImage(string number);
    }
}
