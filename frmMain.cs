using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string MachineName1;
        string UserRoles;

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
            MachineName1 = Environment.MachineName;
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Kiểm tra kết nối máy chủ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();

            mixingToolStripMenuItem.Enabled = false;
            mixedOutStationToolStripMenuItem.Enabled = false;
            recycledStationToolStripMenuItem.Enabled = false;
            cookiesStationToolStripMenuItem.Enabled = false;
            toolStripMenuItem1.Enabled = false;

            if (ScaleApp.Common.DataOperation.ConnectToDB() == 0)
            {                
                XtraMessageBox.Show("Không có kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra tín hiệu mạng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                XtraMessageBox.Show("Kết nối cơ sở dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cookiesStationToolStripMenuItem.Enabled = true;
                mixingToolStripMenuItem.Enabled = true;
                mixedOutStationToolStripMenuItem.Enabled = true;
                recycledStationToolStripMenuItem.Enabled = true;

                //string URoles = GetUserRoles(MachineName1);

                //string[] uRolesArray = URoles.Split(',');
                //foreach (var roles in uRolesArray)
                //{
                //    SetMenuByRoles(roles.Trim());
                //}
            }
        }   

        private string GetUserRoles(string machineName)
        {           
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter SqlDa = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand("sp_getRUserRoles", conn);

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@rComputerName", machineName);
            SqlDa.SelectCommand = sqlcmd;
            SqlDa.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                UserRoles = ds.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                UserRoles = "0";
            }            
            ScaleApp.Common.DataOperation.disconnect();
            return UserRoles;
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
             //   mixingToolStripMenuItem.Enabled = true;
              //  mixedOutStationToolStripMenuItem.Enabled = true;
              //  recycledStationToolStripMenuItem.Enabled = true;
                cookiesStationToolStripMenuItem.Enabled = true;
                XtraMessageBox.Show("Kết nối cơ sở dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmUser fUser = new frmUser();
            fUser.TopLevel = false;
            fUser.Parent = this;
            fUser.StartPosition = FormStartPosition.CenterParent;
            fUser.Show();
        }
        
        private void SetMenuByRoles(string userRoles)
        {
            Form fMixing = new frmMixing();
            switch (userRoles)
            {
                case "21":
                    mixingToolStripMenuItem.Enabled = true;
                    //foreach (Control c in fMixing.Controls)
                    //{
                    //    if (c is SimpleButton)
                    //    {
                    //        if (c.Name.Equals("spbSave"))
                    //        {
                    //            c.Enabled = true;
                    //        }
                    //    }
                    //}
                    break;                
                case "31":
                    mixedOutStationToolStripMenuItem.Enabled = true;
                    break;
                case "41":
                    recycledStationToolStripMenuItem.Enabled = true;
                    break;
            }
        }
    }
}
