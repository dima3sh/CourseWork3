﻿using AutoPark.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.View
{
    interface IParkView : IView<IParkPresenter>
    {
        void UpdateParkView(List<string[]> cars);
    }
}
