using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS_Interface
{

    public partial class ChildViewBase : DevExpress.XtraBars.Ribbon.RibbonForm, IBaseView
    {
        private static List<object> ChildViewList = new List<object>();
        public  IWMSFrame IWmsFrame {get;set;}
        public ChildViewBase ()
        {
            InitializeComponent();
            
            //ChildViewList.Add(this);
        }
        public static ChildViewBase GetView(string viewType)
        {
            foreach( ChildViewBase view in ChildViewList)
            {
                if (view.GetType().ToString() == viewType)
                {
                    return view;
                }
            }
            return null;
        }
        public  virtual void Init(IWMSFrame iWmsFrame)
        {
            this.IWmsFrame = iWmsFrame;
        }
        public void ShowMessage(string title, string content)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public int AskMessage(string title, string content)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //ChildViewList.Remove(this);
        }

    }
}
