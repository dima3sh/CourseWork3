using AutoPark.Entity;
using Model;
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

        public ObservableCollection<Car> GetAllElems() {
            return _dataBase.Cars;
        }

        public bool Contains(Car obj)
        {
            return _dataBase.Cars.Contains(obj);
        }

        public Car FindElemByNumber(string number)
        {
            return _dataBase.Cars.Where(car => car.Number.Equals(number)).First();
        }

        public void UpdateElem(Car newObj, string number)
        {
            Car car = _dataBase.Cars.Where(x => x.Number.Equals(number)).First();
            if (car != null) {
                _dataBase.Cars[_dataBase.Cars.IndexOf(car)] = newObj;
            }
            DaoXml.saveAsync();
        }

        public bool DeleteElemByNumber(string number)
        {
            Car car = _dataBase.Cars.Where(x => x.Number.Equals(number)).First();
            if (car != null)
            {
                _dataBase.Cars.Remove(car);
                DaoXml.saveAsync();
                return true;
            }
            return false;
        }
    }
}
