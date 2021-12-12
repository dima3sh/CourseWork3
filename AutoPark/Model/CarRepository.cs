using AutoPark.Entity;
using Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace AutoPark.Model
{
    public class CarRepository : IRepository<Car>
    {
        private DataBase _dataBase;
        public CarRepository()
        {            
            _dataBase = DaoXml.GetDataBase();
            _dataBase.Cars.CollectionChanged += SaveChanges;
        }

        public void AddElement(Car car) {
            _dataBase.Cars.Add(car);
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
        }

        public bool DeleteElemByNumber(string number)
        {
            Car car = _dataBase.Cars.Where(x => x.Number.Equals(number)).First();
            if (car != null)
            {
                _dataBase.Cars.Remove(car);                
                return true;
            }
            return false;
        }

        private void SaveChanges(object sender, NotifyCollectionChangedEventArgs e) {
            DaoXml.saveAsync();
        }
    }
}
