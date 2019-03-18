using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class MainFrameHandler
    {
        private static IWMSFrame MAINFRAME = null;
        private MainFrameHandler()
        { }
        public static void SetMainFrame(IWMSFrame mainFrame)
        {
            MAINFRAME = mainFrame;
        }
        public static IWMSFrame GetMainFrame()
        {
            return MAINFRAME;
        }
    }
}
