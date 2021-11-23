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

        List<string[]> GetCars();
    }
}
