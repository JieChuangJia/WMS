using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Service_Main
{
    public class BasePresenter<IView>
    {
        public IView View { get; set; }
        public BasePresenter(IView view)
        {
            this.View = view;
        }
    }
}
