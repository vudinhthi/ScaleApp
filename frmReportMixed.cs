using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.Configuration;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleApp
{
    public partial class frmReportMixed : Form
    {
        public frmReportMixed()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            
        }

       

        

        private void LoadDataByDataSet()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getFullMixRaws", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();

            var rpt = new rptMixed();

            rpt.FindControl("lblColorCode", false).Text = ds.Tables[0].Rows[0][1].ToString();
            rpt.FindControl("lblColorName", false).Text = ds.Tables[0].Rows[0][2].ToString();
            rpt.FindControl("lblItemName", false).Text = ds.Tables[0].Rows[0][4].ToString();
            rpt.FindControl("lblMaterialName", false).Text = ds.Tables[0].Rows[0][6].ToString();
            rpt.FindControl("lblMachine", false).Text = ds.Tables[0].Rows[0][7].ToString();
            rpt.FindControl("lblKg", false).Text = ds.Tables[0].Rows[0][8].ToString();
            rpt.FindControl("lblStep", false).Text = ds.Tables[0].Rows[0][9].ToString();
            rpt.FindControl("lblOperator", false).Text = ds.Tables[0].Rows[0][11].ToString();
            rpt.FindControl("lblMixID", false).Text = ds.Tables[0].Rows[0][12].ToString();
            rpt.FindControl("xrBarCode1", false).Text = ds.Tables[0].Rows[0][12].ToString();
            rpt.FindControl("lblDateTime", false).Text = ds.Tables[0].Rows[0][13].ToString();

            rpt.DataSource = ds;

            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;

            //var rpt = new rptMixed();

            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}
