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
using DevExpress.XtraLayout;

namespace ScaleApp
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            LoginUserControl myControl = new LoginUserControl();
            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, "Sign in", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                MessageBox.Show("You pressed Ok");
            }
            else
            {
                MessageBox.Show("You pressed Cancel");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }

    public class LoginUserControl : XtraUserControl
    {
        public LoginUserControl()
        {
            LayoutControl lc = new LayoutControl();
            lc.Dock = DockStyle.Fill;
            
            TextEdit teLogin = new TextEdit();
            TextEdit tePassword = new TextEdit();
            tePassword.Properties.UseSystemPasswordChar = true;

            CheckEdit ceKeep = new CheckEdit() { Text = "Keep me signed in" };
            SeparatorControl separatorControl = new SeparatorControl();
            lc.AddItem(String.Empty, teLogin).TextVisible = false;
            lc.AddItem(String.Empty, tePassword).TextVisible = false;
            lc.AddItem(String.Empty, ceKeep);
            this.Controls.Add(lc);
            this.Height = 100;
            this.Dock = DockStyle.Top;

        }
    }
}