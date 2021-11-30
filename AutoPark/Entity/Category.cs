using AutoPark.Entity;
using AutoPark.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Entity
{
    [Serializable]
    public class Category
    {
        public Category() { 
            
        }
        public string Name { get; set; }

        public string Id { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Category)
            {
                return Name.ToLower().Equals(((Category)obj).Name.ToLower());
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + 31 * Id.GetHashCode();
        }

        public TypeCar Type { get; set; }
    }
}
