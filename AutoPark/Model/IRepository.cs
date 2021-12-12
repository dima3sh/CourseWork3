using System.Collections.ObjectModel;

namespace AutoPark.Model
{
    interface IRepository<T>
    {
        bool Contains(T obj);
        void AddElement(T obj);
        ObservableCollection<T> GetAllElems();

        T FindElemByNumber(string number);

        void UpdateElem(T newObj, string number);

        bool DeleteElemByNumber(string number);
    }
}
