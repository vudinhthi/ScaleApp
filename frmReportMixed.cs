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

        private SqlDataSource BindToData()
        {
            // Create a data source with the required connection parameters.  
            MsSqlConnectionParameters connectionParameters = new MsSqlConnectionParameters(
                "(localdb)\MSSQLLocalDB", "ColorMix", "sa", "12345678", MsSqlAuthorizationType.SqlServer);
            SqlDataSource ds = new SqlDataSource(connectionParameters);

            // Create an SQL query to access the Products table.
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = "customQuery";
            query.Sql = "SELECT * FROM CrushRaw";

            // Add the query to the collection. 
            ds.Queries.Add(query);

            // Make the data source structure displayed  
            // in the Field List of an End-User Report Designer. 
            ds.RebuildResultSchema();

            return ds;
        }

        private XtraReport CreateReport()
        {
            // Create a new report instance.
            XtraReport report = new XtraReport();

            // Assign the data source to the report.
            report.DataSource = BindToData();
            report.DataMember = "customQuery";

            // Add a detail band to the report.
            DetailBand detailBand = new DetailBand();
            detailBand.Height = 50;
            report.Bands.Add(detailBand);

            // Create a new label.
            XRLabel label = new XRLabel { WidthF = 300 };
            // Specify the label's binding depending on the data binding mode.
            if (Settings.Default.UserDesignerOptions.DataBindingMode == DataBindingMode.Bindings)
                label.DataBindings.Add("Text", null, "customQuery.ProductName");
            else label.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[ProductName]"));
            // Add a label to the detail band. 
            detailBand.Controls.Add(label);

            return report;
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
