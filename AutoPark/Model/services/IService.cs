using AutoPark.Entity;
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
    }
}
