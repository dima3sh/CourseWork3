using AutoPark.Entity.Enums;
using AutoPark.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
