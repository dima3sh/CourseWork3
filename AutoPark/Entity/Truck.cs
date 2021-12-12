using AutoPark.Entity.Enums;
using System;

namespace AutoPark.Entity
{
    [Serializable]
    public class Truck : Car
    {
        public Truck() {

        }

        public TypeCar Type { get { return TypeCar.TRUCK; } }
    }
}
