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
using DevExpress.XtraPrinting;
using System.Drawing.Printing;

namespace ScaleApp
{    
    public partial class frmReportMixed : Form
    {
        private string  lableTypeReport;
        private int mixID;
        private int labelTypeIndex;

        private PrinterSettings prnSettings;

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

        public int LabelTypeIndex 
        { 
            get { return this.labelTypeIndex; } 
            set { this.labelTypeIndex = value; } 
        }

        public frmReportMixed()
        {
            InitializeComponent();
            
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //labelReport = LableTypeReport;
            //SendToPrint();            
            LoadDataToReport(labelTypeIndex);
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

        private void LoadDataToReport(int labelIndex)
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

            switch (labelIndex)
            {
                case 0:
                    var rptMix = new rptMixing();
                    rptMix.DataSource = ds;
                    rptMix.CreateDocument();
                    ReportPrintTool printToolMix = new ReportPrintTool(rptMix);
                    printToolMix.PrintDialog();
                    //documentViewer1.DocumentSource = rptMix;
                    break;
                case 1:
                    var rptRunner = new rptMixedOut();
                    rptRunner.DataSource = ds;
                    rptRunner.CreateDocument();
                    ReportPrintTool printToolRunner = new ReportPrintTool(rptRunner);
                    printToolRunner.PrintDialog();
                    //documentViewer1.DocumentSource = rptRunner;
                    break;
                case 2:
                    var rptDefect = new rptDefect();
                    rptDefect.DataSource = ds;
                    rptDefect.CreateDocument();
                    ReportPrintTool printToolDefect = new ReportPrintTool(rptDefect);
                    printToolDefect.PrintDialog();
                    //documentViewer1.DocumentSource = rptDefect;
                    break;
                case 3:
                    var rptBlackDot = new rptBlackDot();
                    rptBlackDot.DataSource = ds;
                    rptBlackDot.CreateDocument();
                    ReportPrintTool printToolBlackDot = new ReportPrintTool(rptBlackDot);
                    printToolBlackDot.PrintDialog();
                    //documentViewer1.DocumentSource = rptBlackDot;
                    break;
                case 4:
                    var rptContaminated = new rptContaminated();
                    rptContaminated.DataSource = ds;
                    rptContaminated.CreateDocument();
                    ReportPrintTool printToolContaminated = new ReportPrintTool(rptContaminated);
                    printToolContaminated.PrintDialog();
                    //documentViewer1.DocumentSource = rptContaminated;
                    break;
                case 5:
                    rptRunner = new rptMixedOut();
                    rptRunner.DataSource = ds;
                    rptRunner.CreateDocument();

                    XtraReport[] reports = new XtraReport[] { new rptDefect(), new rptBlackDot(), new rptContaminated() };
                    foreach (XtraReport report in reports)
                    {
                        report.DataSource = ds;
                        report.CreateDocument();
                    }

                    printToolMix = new ReportPrintTool(rptRunner);
                    printToolMix.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);

                    foreach (XtraReport report in reports)
                    {
                        ReportPrintTool pts = new ReportPrintTool(report);
                        pts.PrintingSystem.StartPrint +=
                            new PrintDocumentEventHandler(reportsStartPrintEventHandler);
                    }

                    printToolMix.PrintDialog();
                    foreach (XtraReport report in reports)
                    {
                        ReportPrintTool pts = new ReportPrintTool(report);
                        pts.Print();
                    }

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

        private void reportsStartPrintEventHandler(object sender, PrintDocumentEventArgs e)
        {
            prnSettings = e.PrintDocument.PrinterSettings;
        }

        private void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e)
        {
            int pageCount = e.PrintDocument.PrinterSettings.ToPage;
            e.PrintDocument.PrinterSettings = prnSettings;

            // The following line is required if the number of pages for each report varies, 
            // and you consistently need to print all pages.
            e.PrintDocument.PrinterSettings.ToPage = pageCount;
        }
    }
}
