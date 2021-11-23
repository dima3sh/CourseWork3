using AutoPark.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Model
{
    interface IRepository<T>
    {
        bool Contains(T obj);
        void AddElement(T obj);
        ObservableCollection<Car> GetAllCars();
    }
}
