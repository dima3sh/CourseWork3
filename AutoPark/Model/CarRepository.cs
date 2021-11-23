using AutoPark.Entity;
using Bar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Model
{
    public class CarRepository : IRepository<Car>
    {
        private DataBase _dataBase;
        public CarRepository()
        {            
            _dataBase = DaoXml.GetDataBase();
        }

        public void AddElement(Car car) {
            _dataBase.Cars.Add(car);
            DaoXml.saveAsync();
        }

        public ObservableCollection<Car> GetAllCars() {
            return _dataBase.Cars;
        }

        public bool Contains(Car obj)
        {
            return _dataBase.Cars.Contains(obj);
        }
    }
}
