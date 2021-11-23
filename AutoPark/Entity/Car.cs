using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutoPark.Entity
{
    [Serializable]
    [XmlInclude(typeof(PassengerCar))]
    [XmlInclude(typeof(Truck))]
    public abstract class Car
    {
        public string Model { get; set; }

        public string Category { get; set; }

        public string Number { get; set; }

        public override bool Equals(object obj)
        {
            return Number.Equals(obj);
        }
    }
}
