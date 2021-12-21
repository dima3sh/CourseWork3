using AutoPark.Entity;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace AutoPark.Model
{
    public class CategoryRepository : IRepository<Category>
    {

        private DataBase _dataBase;
        public CategoryRepository()
        {
            _dataBase = DaoXml.GetDataBase();
            _dataBase.Categories.CollectionChanged += SaveChanges;
        }
        public void AddElement(Category obj)
        {
            _dataBase.Categories.Add(obj);
        }

        public bool Contains(Category obj)
        {
            return _dataBase.Categories.Contains(obj);
        }

        public bool DeleteElemByNumber(string categoryId)
        {
            Category category = _dataBase.Categories.Where(x => x.Id.Equals(categoryId)).First();
            if (category != null) {
                _dataBase.Categories.Remove(category);
                return true;
            }
            return false;
        }

        public Category FindElemByNumber(string number)
        {
            List<Category> categories =  _dataBase.Categories.Where(x => x.Id == (number)).ToList();
            return categories.Count() != 0 ? categories.First() : null;
            
        }

        public ObservableCollection<Category> GetAllElems()
        {
            return _dataBase.Categories;
        }

        public void UpdateElem(Category newObj, string number)
        {
            Category category = FindElemByNumber(number);
            if (category != null) {
                _dataBase.Categories.Remove(category);
                _dataBase.Categories.Add(newObj);
            }
        }
        private void SaveChanges(object sender, NotifyCollectionChangedEventArgs e)
        {
            DaoXml.Save();
        }
    }
}
