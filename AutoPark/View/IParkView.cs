using AutoPark.Presenters;

namespace AutoPark.View
{
    public interface IParkView : IView<IParkPresenter>
    {
        void UpdateParkView();
    }
}
