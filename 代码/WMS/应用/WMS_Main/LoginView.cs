using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;

namespace Aoyou_WMS
{
    public partial class LoginView : ChildViewBase
    {
        public LoginView()
        {
            InitializeComponent();
         
            InitTabbedMDI();
          
        }
       
        private void sBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.txtEdit_UserName.Text = string.Empty;
            this.txtEdit_UserPassword.Text = string.Empty;
            
        }
        private void InitTabbedMDI()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //Dark Side,Visual Studio 2013 Blue,Office 2007 Black,Office 2010 Silver,Office 2007 Blue,DevExpress Dark Style,DevExpress Style,Office 2016 Black
            this.defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Stardust");
          
        }
        private void sBtn_Sure_Click(object sender, EventArgs e)
        {
           
           
            MainFrame mainView = new MainFrame();
            mainView.Show();
            this.Hide();
        }

     

 
    }
}