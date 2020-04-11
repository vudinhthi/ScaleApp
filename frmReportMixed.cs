using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
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
        private string  lableTypeReport;
        private int mixID;

        public string LableTypeReport
        {
            get { return this.lableTypeReport; }
            set { this.lableTypeReport = value; }
        }

        public int MixID
        {
            get {return this.mixID; }
            set {this.mixID = value; }
        }

        public frmReportMixed()
        {
            InitializeComponent();
            
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //labelReport = LableTypeReport;
            //SendToPrint();            
            LoadDataToReport(LableTypeReport);
            this.Close();
            this.Dispose();
        }

        private void SendToPrint()
        {
            var rpt = new rptMixing();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.PrintDialog();
            // Send the report to the specified printer.
            //printTool.Print("Canon B&W");
        }

        private void LoadDataToReport(string typeReport)
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter SqlDa = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand("sp_getFullMixRaw3", conn);

            try
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mixRawId", MixID);
                SqlDa.SelectCommand = sqlcmd;
                SqlDa.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();

            switch (typeReport)
            {
                case "Mixed":
                    var rptMix = new rptMixing();
                    rptMix.DataSource = ds;
                    rptMix.CreateDocument();
                    ReportPrintTool printToolMix = new ReportPrintTool(rptMix);
                    printToolMix.PrintDialog();
                    //documentViewer1.DocumentSource = rptMix;
                    break;
                case "Runner":
                    var rptRunner = new rptMixedOut();
                    rptRunner.DataSource = ds;
                    rptRunner.CreateDocument();
                    ReportPrintTool printToolRunner = new ReportPrintTool(rptRunner);
                    printToolRunner.PrintDialog();
                    //documentViewer1.DocumentSource = rptRunner;
                    break;
                case "Defect":
                    var rptDefect = new rptDefect();
                    rptDefect.DataSource = ds;
                    rptDefect.CreateDocument();
                    ReportPrintTool printToolDefect = new ReportPrintTool(rptDefect);
                    printToolDefect.PrintDialog();
                    //documentViewer1.DocumentSource = rptDefect;
                    break;
                case "BlackDot":
                    var rptBlackDot = new rptBlackDot();
                    rptBlackDot.DataSource = ds;
                    rptBlackDot.CreateDocument();
                    ReportPrintTool printToolBlackDot = new ReportPrintTool(rptBlackDot);
                    printToolBlackDot.PrintDialog();
                    //documentViewer1.DocumentSource = rptBlackDot;
                    break;
                case "Contaminated":
                    var rptContaminated = new rptContaminated();
                    rptContaminated.DataSource = ds;
                    rptContaminated.CreateDocument();
                    ReportPrintTool printToolContaminated = new ReportPrintTool(rptContaminated);
                    printToolContaminated.PrintDialog();
                    //documentViewer1.DocumentSource = rptContaminated;
                    break;
                default:
                    rptMix = new rptMixing();
                    rptMix.DataSource = ds;
                    rptMix.CreateDocument();
                    printToolMix = new ReportPrintTool(rptMix);
                    printToolMix.PrintDialog();
                    //documentViewer1.DocumentSource = rptMix;
                    break;
            }                                   
        }
    }
}
