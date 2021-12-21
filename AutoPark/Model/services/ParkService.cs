using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AutoPark.Model.services
{
    public class ParkService : IService
    {
        private IRepository<Car> _carRepository;
        private IRepository<Category> _categoryRepository;
        private IRepository<CarPicture> _imageRepository;

        public ParkService() {
            _carRepository = new CarRepository();
            _categoryRepository = new CategoryRepository();
            _imageRepository = new PictureRepository();
        }

        public bool addCar(Car car)
        {
            if (!_carRepository.Contains(car)) 
            {

                _carRepository.AddElement(car);
                return true;
            }
            return false;
        }

        public void DeleteCar(string number)
        {
            _carRepository.DeleteElemByNumber(number);
            _imageRepository.DeleteElemByNumber(number);
        }

        public bool EditCar(Car request, string number)
        {
            if (!_carRepository.Contains(request) || request.Number.Equals(number))
            {
                _carRepository.UpdateElem(request, number);
                return true;
            } return false;
        }

        public ObservableCollection<Car> GetCars()
        {
            return _carRepository.GetAllElems();
        }

        public Car FindCarByNumber(string number)
        {
            return _carRepository.FindElemByNumber(number);
        }

        public List<Car> FindCarsByPartNumber(string number)
        {
            return _carRepository.GetAllElems()
                .Where(car => car.Number.Contains(number))
                .OrderBy(car => car.Number.IndexOf(number))
                .ToList();
        }

        public bool AddCategory(Category category)
        {
            if (!_categoryRepository.Contains(category)) {
                category.Id = Guid.NewGuid().ToString();
                _categoryRepository.AddElement(category);
                return true;
            }
            return false;
        }

        public bool DeleteCategory(string categoryId) {
            if (_carRepository.GetAllElems().Where(car => categoryId.Equals(car.CategoryId)).Count() == 0)
            {
                return _categoryRepository.DeleteElemByNumber(categoryId);
            }
            throw new ArgumentException(Properties.Resources.DeleteCategoryWithCars);
        }

        public bool UpdateCategory(Category category, string number)
        {
            Category oldCategory = _categoryRepository.FindElemByNumber(number);
            if (oldCategory != null && (!isCarsWithCategoryId(_carRepository.GetAllElems().ToList(), number) 
                || (isCarsWithCategoryId(_carRepository.GetAllElems().ToList(), number) && oldCategory.Type.Equals(category.Type))))
            {
                if (_categoryRepository.FindElemByNumber(category.Id) != null)
                {
                    _categoryRepository.UpdateElem(category, number);
                    return true;
                }
                return false;
            }
            else
            {
                throw new ArgumentException(Properties.Resources.UpdateCategoryBadCarType);
            }
            
        }

        public ObservableCollection<Category> GetCategories() {
            return _categoryRepository.GetAllElems();
        }

        public Category FindCategoryById(string id)
        {
            return _categoryRepository.FindElemByNumber(id);
        }

        public List<TypeCar> GetCarTypes()
        {
            return Enum.GetValues(typeof(TypeCar)).Cast<TypeCar>().ToList();
        }

        public List<Category> GetCategoriesByType(TypeCar type)
        {
            return _categoryRepository.GetAllElems().Where(category => category.Type.Equals(type)).ToList();
        }

        private bool isCarsWithCategoryId(List<Car> cars, string categoryId) {
            return cars.Where(car => car.CategoryId.Equals(categoryId)).Count() > 0;
        }

        public ObservableCollection<CarPicture> GetPictures() {
            return _imageRepository.GetAllElems();
        }

        public CarPicture GetImageByNumber(string number) {
            return _imageRepository.FindElemByNumber(number);
        }

        public void SavePicture(CarPicture image)
        {
            _imageRepository.AddElement(image);
        }

        public bool HasCarImage(string number) {
            return _imageRepository.GetAllElems().Where(picture => picture.Number.Equals(number)).Count() > 0;
        }

        public void UpdatePicture(CarPicture picture)
        {
            _imageRepository.UpdateElem(picture, picture.Number);
        }
    }
}
