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
using DevExpress.XtraSplashScreen;
using System.Threading;
using System.Data.SqlClient;

namespace ScaleApp
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            string MachineName1 = Environment.MachineName;
            tedComputerName.EditValue = MachineName1;
            GetUserRoles(MachineName1);
        }

        private void GetUserRoles(string machineName)
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
                checkCbeRoles.SetEditValue(ds.Tables[0].Rows[0][2]);
                checkCbeRoles.ReadOnly = true;
                tedComputerName.ReadOnly = true;
                simpleButton1.Enabled = false;
            }
            ScaleApp.Common.DataOperation.disconnect();           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            //SplashScreenManager.Default.SetWaitFormCaption("Updating data...");
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(10);
            //}
            //SplashScreenManager.CloseForm();

            try
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("sp_createRUserRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@rComputerName", tedComputerName.EditValue);
                cmd.Parameters.AddWithValue("@rRoles", checkCbeRoles.EditValue);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                tedComputerName.ReadOnly = true;

                ScaleApp.Common.DataOperation.disconnect();
            }
            catch (SqlException sqlEx)
            {
                int exNumber = sqlEx.Number;
                switch (sqlEx.Number)
                {
                    case 2601:
                        XtraMessageBox.Show("Dữ liệu đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        XtraMessageBox.Show("Lỗi: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            this.Dispose();
        }
    }
}