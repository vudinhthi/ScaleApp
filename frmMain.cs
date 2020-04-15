using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ScaleApp.Common;

namespace ScaleApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mixingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            frmMixing mixing = new frmMixing();
            mixing.TopLevel = false;
            mixing.Parent = this;
            mixing.Show();
        }

        private void recycledStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            frmCrushing crushing = new frmCrushing();
            crushing.TopLevel = false;
            crushing.Parent = this;
            crushing.Show();
        }

        private void mixedOutStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            frmMixedOut mixing = new frmMixedOut();
            mixing.TopLevel = false;
            mixing.Parent = this;
            mixing.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Kiểm tra kết nối máy chủ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();

            if (ScaleApp.Common.DataOperation.ConnectToDB() == 0)
            {
                mixingToolStripMenuItem.Enabled = false;
                mixedOutStationToolStripMenuItem.Enabled = false;
                recycledStationToolStripMenuItem.Enabled = false;
                cookiesStationToolStripMenuItem.Enabled = false;
                XtraMessageBox.Show("Không có kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra tín hiệu mạng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mixingToolStripMenuItem.Enabled = true;
                mixedOutStationToolStripMenuItem.Enabled = true;
                recycledStationToolStripMenuItem.Enabled = true;
                cookiesStationToolStripMenuItem.Enabled = true;
                XtraMessageBox.Show("Kết nối cơ sở dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }   

        private void connectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmLogin frmLogin = new frmLogin();            
        }

        private void cookiesStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmCookies cookies = new frmCookies();
            cookies.TopLevel = false;
            cookies.Parent = this;
            cookies.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmAbout about = new frmAbout();
            about.TopLevel = false;
            about.Parent = this;
            about.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Kiểm tra kết nối máy chủ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();

            if (ScaleApp.Common.DataOperation.ConnectToDB() == 0)
            {
                mixingToolStripMenuItem.Enabled = false;
                mixedOutStationToolStripMenuItem.Enabled = false;
                recycledStationToolStripMenuItem.Enabled = false;
                cookiesStationToolStripMenuItem.Enabled = false;
                XtraMessageBox.Show("Không có kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra tín hiệu mạng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mixingToolStripMenuItem.Enabled = true;
                mixedOutStationToolStripMenuItem.Enabled = true;
                recycledStationToolStripMenuItem.Enabled = true;
                cookiesStationToolStripMenuItem.Enabled = true;
                XtraMessageBox.Show("Kết nối cơ sở dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
