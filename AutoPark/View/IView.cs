using AutoPark.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
