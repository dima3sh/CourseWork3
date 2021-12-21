using AutoPark.Entity.Enums;
using System;
using System.Xml.Serialization;

namespace AutoPark.Entity
{
    [Serializable]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(PassengerCar))]
    public abstract class Car
    {
        public string Model { get; set; }

        public string CategoryId { get; set; }

        public string Number { get; set; }

        public override bool Equals(object obj)
        {
            return Number.Equals(((Car)obj).Number);
        }
        public TypeCar Type { get;}
    }
}
