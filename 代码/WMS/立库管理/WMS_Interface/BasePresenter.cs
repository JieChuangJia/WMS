using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class BasePresenter<IView>
    {
        private static List<BasePresenter<IView>> presenterList = new List<BasePresenter<IView>>();
        public IView View { get; set; }
        public IWMSFrame WmsFrame { get; set; }
        public BasePresenter(IView view,IWMSFrame wmsFrame)
        {
            presenterList.Add(this);
            this.View = view;
            this.WmsFrame = wmsFrame;
        }
        public static BasePresenter<IView> GetPresenter(string type)
        {
            foreach (BasePresenter<IView> presenter in presenterList)
            {
                if (presenter.GetType().ToString() == type)
                {
                    return presenter;
                }
            }
            return null;
        }
        public virtual void Init()
        { }
    }
 
}
