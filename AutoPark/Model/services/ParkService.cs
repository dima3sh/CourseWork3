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
    class ParkService : IService
    {
        private IRepository<Car> _carRepository;
        private IRepository<Category> _categoryRepository;

        public ParkService() {
            _carRepository = new CarRepository();
            _categoryRepository = new CategoryRepository();
        }

        public bool addCar(Car car)
        {
            if (!_carRepository.Contains(car)) {

                _carRepository.AddElement(car);
                return true;
            }
            return false;
        }

        public void DeleteCar(string number)
        {
            _carRepository.DeleteElemByNumber(number);
        }

        public ObservableCollection<Category> GetCategories() {
            return _categoryRepository.GetAllElems();
        }

        public void EditCar(Car request, string number)
        {
            _carRepository.UpdateElem(request, number);
        }

        public Car FindCarByNumber(string number)
        {
            return _carRepository.FindElemByNumber(number);
        }

        public Category FindCategoryById(string id)
        {
            return _categoryRepository.FindElemByNumber(id);
        }

        public ObservableCollection<Car> GetCars()
        {
            return _carRepository.GetAllElems();
        }

        public bool AddCategory(Category category)
        {
            category.Id = Guid.NewGuid().ToString();
            if (!_categoryRepository.Contains(category)) {
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
            throw new ArgumentException("There are cars with category : " + _categoryRepository.FindElemByNumber(categoryId));
        }

        public void UpdateCategory(Category category, string number)
        {
            if (!_categoryRepository.Contains(category) && isCarsWithCategoryId(_carRepository.GetAllElems().ToList(), number))
            {
                _categoryRepository.UpdateElem(category, number);
            }
            else
            {
                throw new ArgumentException("Category with this name already exists or an attempt to change the car type, if there is an cars.");
            }
        }

        public List<Car> FindCarsByPartNumber(string number)
        {
            return _carRepository.GetAllElems()
                .Where(car => car.Number.Contains(number))
                .OrderBy(car => car.Number.IndexOf(number))
                .ToList();
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
    }
}
