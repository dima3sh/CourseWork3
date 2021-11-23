using AutoPark.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Presenters
{
    public interface ICarPresenter : IPresenter
    {
        bool AddCar(Car car);
    }
}
