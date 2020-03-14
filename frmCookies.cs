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
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace ScaleApp
{
    public partial class frmCookies : DevExpress.XtraEditors.XtraForm
    {
        

        public frmCookies()
        {
            InitializeComponent();
        }

        private void frmCookies_Load(object sender, EventArgs e)
        {
            Start_Timer();
            LoadLueItem();
            LoadLueMaterial();
        }

        private void LoadLueItem()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getProducts", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                lueItem.Properties.DataSource = ds.Tables[0];
                lueItem.Properties.DisplayMember = "ProductName";
                lueItem.Properties.ValueMember = "ProductCode";
                lueItem.Properties.KeyMember = "ProductCode";

                lueItem.Properties.Columns.Add(new LookUpColumnInfo("ProductCode", "ProductCode", 60));
                lueItem.Properties.Columns.Add(new LookUpColumnInfo("ProductName", "ProductName", 120));
                //enable text editing 
                lueItem.Properties.TextEditStyle = TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void LoadLueMaterial()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getMaterials", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                lueMaterial.Properties.DataSource = ds.Tables[0];
                lueMaterial.Properties.DisplayMember = "MaterialName";
                lueMaterial.Properties.ValueMember = "MaterialCode";

                lueMaterial.Properties.Columns.Add(new LookUpColumnInfo("MaterialCode", "MaterialCode", 60));
                lueMaterial.Properties.Columns.Add(new LookUpColumnInfo("MaterialName", "MaterialName", 120));

                lueMaterial.Properties.TextEditStyle = TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCurrentDate.Text = DateTime.Now.ToString();
        }

        private void Start_Timer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}