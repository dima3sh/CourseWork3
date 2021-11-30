using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Presenters
{
    public interface IParkPresenter : IPresenter
    {
        void ShowCarView();
        void ShowCarView(string number);

        void ShowAddCategoryView();
        void ShowEditCategoryView();
        List<string[]> GetCars();
        List<string[]> GetCarsByPartNumber(string number);
        void DeleteCar(string number);
    }
}
