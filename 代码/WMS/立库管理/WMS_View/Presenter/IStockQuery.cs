using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IStockQueryView:IBaseView
    {
        void IniHouseList(List<string> items);
        //void IniHouseAreaList(List<string> items);
        void IniRowList(List<string> items);
        void IniColList(List<string> items);
        void IniMaterialCateList(List<string> items);
        void IniPalletList(List<string> items);
        void IniLayerList(List<string> items);
    }
}
