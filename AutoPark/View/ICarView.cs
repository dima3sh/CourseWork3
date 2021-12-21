using AutoPark.Presenters;

namespace AutoPark.View
{
    public interface ICarView : IView<ICarPresenter>
    {
        void SaveImage(string number);
    }
}
