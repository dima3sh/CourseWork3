using AutoPark.Entity;
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

        public ParkService(IRepository<Car> carRepository) {
            _carRepository = carRepository;
        }

        public bool addCar(Car car)
        {
            if (!_carRepository.Contains(car)) {
                _carRepository.AddElement(car);
                return true;
            }
            return false;
        }

        public ObservableCollection<Car> GetCars()
        {
            return _carRepository.GetAllCars();
        }
    }
}
