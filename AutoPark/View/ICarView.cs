using AutoPark.Presenters;

namespace AutoPark.View
{
    interface ICarView : IView<ICarPresenter>
    {
        void SaveImage(string number);
    }
}
