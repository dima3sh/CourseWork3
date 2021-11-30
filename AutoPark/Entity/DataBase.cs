using AutoPark.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    [Serializable]
    public class DataBase
    {
        public DataBase() {
            Cars = new ObservableCollection<Car>();
            Categories = new ObservableCollection<Category>();
        }
        public ObservableCollection<Car> Cars { get; set; }

        public ObservableCollection<Category> Categories { get; set; }
    }
}
