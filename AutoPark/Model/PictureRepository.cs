using AutoPark.Entity;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace AutoPark.Model
{
    public class PictureRepository : IRepository<CarPicture>
    {
        private DataBase _dataBase;
        public PictureRepository()
        {
            _dataBase = DaoXml.GetDataBase();
            _dataBase.Pictures.CollectionChanged += SaveChanges;
        }
        public void AddElement(CarPicture obj)
        {            
            _dataBase.Pictures.Add(obj); 
        }

        public bool Contains(CarPicture obj)
        {
            return _dataBase.Pictures.Contains(obj);
        }

        public bool DeleteElemByNumber(string number)
        {
            CarPicture img = FindElemByNumber(number);
            return _dataBase.Pictures.Remove(img);
        }

        public CarPicture FindElemByNumber(string number)
        {
            List<CarPicture> list =  _dataBase.Pictures.Where(picture => picture.Number.Equals(number)).ToList();

            return list.Count > 0 ? list.First() : null;
        }

        public ObservableCollection<CarPicture> GetAllElems()
        {
            return _dataBase.Pictures;
        }

        public void UpdateElem(CarPicture newObj, string number)
        {
            CarPicture img = FindElemByNumber(number);
            if (img != null)
            {
                _dataBase.Pictures.Remove(img);
            }
                _dataBase.Pictures.Add(newObj);
        }

        private void SaveChanges(object sender, NotifyCollectionChangedEventArgs e) {
            DaoXml.Save();
        }
    }
}
