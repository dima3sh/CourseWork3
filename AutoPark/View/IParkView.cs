using AutoPark.Presenters;

namespace AutoPark.View
{
    interface IParkView : IView<IParkPresenter>
    {
        void UpdateParkView();
    }
}
