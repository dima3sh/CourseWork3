using AutoPark.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Entity
{
    [Serializable]
    public class PassengerCar : Car
    {
        public PassengerCar() { 
            
        }

        public TypeCar Type { get { return TypeCar.PASSENGER_CAR; } }
    }
}
