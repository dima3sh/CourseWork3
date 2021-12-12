using AutoPark.Presenters;

namespace AutoPark.View
{
    interface IView<T> where T : IPresenter
    {
        T Presenter { set; }
        void ShowForm();
        void CloseForm();
        void ShowMessage(string message);
    }
}
