using AutoPark.Entity.Enums;
using System;

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
