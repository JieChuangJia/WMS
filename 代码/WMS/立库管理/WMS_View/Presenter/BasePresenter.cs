using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class BasePresenter
    {
        private static List<BasePresenter> presenterList = new List<BasePresenter>();
        public BasePresenter()
        {
            presenterList.Add(this);
        }
        public static BasePresenter GetPresenter(string type)
        {
            foreach(BasePresenter presenter in presenterList)
            {
                if(presenter.GetType ().ToString() == type)
                {
                    return presenter;
                }
            }
            return null;
        }
    }
}
