using AutoPark.Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Model
{
    class CategoryRepository : IRepository<Category>
    {

        private DataBase _dataBase;
        public CategoryRepository()
        {
            _dataBase = DaoXml.GetDataBase();
        }
        public void AddElement(Category obj)
        {
            _dataBase.Categories.Add(obj);
            DaoXml.saveAsync();
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
                DaoXml.saveAsync();
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
            DaoXml.saveAsync();
        }
    }
}
