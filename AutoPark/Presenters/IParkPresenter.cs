using System.Collections.Generic;
using System.Drawing;

namespace AutoPark.Presenters
{
    public interface IParkPresenter : IPresenter
    {
        void ShowCarView();
        void ShowCarView(string number);

        void ShowCategoriesView();
        List<string[]> GetCars();
        List<string[]> GetCarsByPartNumber(string number);
        void DeleteCar(string number);
        Bitmap FindPictureByNumber(string number);
    }
}
