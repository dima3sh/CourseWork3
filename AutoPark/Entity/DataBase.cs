using AutoPark.Entity;
using System;
using System.Collections.ObjectModel;

namespace AutoPark
{
    [Serializable]
    public class DataBase
    {
        public DataBase() {
            Cars = new ObservableCollection<Car>();
            Categories = new ObservableCollection<Category>();
            Pictures = new ObservableCollection<CarPicture>();
        }
        public ObservableCollection<Car> Cars { get; set; }

        public ObservableCollection<Category> Categories { get; set; }

        public ObservableCollection<CarPicture> Pictures { get; set; }
    }
}
