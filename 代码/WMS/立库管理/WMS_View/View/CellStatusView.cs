using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Interface;

namespace WMS_Kernel
{
    public partial class CellStatusView : ChildViewBase
    {
        public bool IsSure = false;
        public string GSStatus { get; set; }
        public string GSTaskStatus { get; set; }
        public CellStatusView()
        {
            InitializeComponent();
        }
        private void CellStatusView_Load(object sender, EventArgs e)
        {
            IniGSStatus();
            IniGSTaskStatus();
        }
        private void IniGSStatus()
        {
            this.cb_GSStatus.Properties.Items.Clear();

            for (int i = 0; i < Enum.GetNames(typeof(EnumCellStatus)).Count(); i++)
            {
                string houseName = Enum.GetNames(typeof(EnumCellStatus))[i];
                this.cb_GSStatus.Properties.Items.Add(houseName);
            }
            if (this.cb_GSStatus.Properties.Items.Count > 0)
            {
                this.cb_GSStatus.SelectedIndex = 0;
            }
        }

        private void IniGSTaskStatus()
        {
            this.cbe_TaskStatus.Properties.Items.Clear();

            for (int i = 0; i < Enum.GetNames(typeof(EnumGSTaskStatus)).Count(); i++)
            {
                string houseName = Enum.GetNames(typeof(EnumGSTaskStatus))[i];
                this.cbe_TaskStatus.Properties.Items.Add(houseName);
            }
            if (this.cbe_TaskStatus.Properties.Items.Count > 0)
            {
                this.cbe_TaskStatus.SelectedIndex = 0;
            }
        }

        private void bt_Sure_Click(object sender, EventArgs e)
        {
            this.GSStatus = this.cb_GSStatus.Text.Trim();
            this.GSTaskStatus = this.cbe_TaskStatus.Text.Trim();

            this.IsSure = true;
            this.Close();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.IsSure = false;
            this.Close();
        }

    
    }
}
