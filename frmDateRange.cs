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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using DevExpress.Utils;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace ScaleApp
{
    public partial class frmDateRange : DevExpress.XtraEditors.XtraForm
    {
        private string productId;
        
        public string ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public frmDateRange()
        {
            InitializeComponent();
        }

        private void spbOK_Click(object sender, EventArgs e)
        {
            if (dateFromdate.EditValue == null || dateTodate.EditValue == null)
            {
                XtraMessageBox.Show("Select date range to export data !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataSet ds = new DataSet();
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);

                try
                {
                    SqlDataAdapter SqlDaMixRaw = new SqlDataAdapter();
                    SqlCommand sqlcmdMixRaw = new SqlCommand("sp_getFullMixRawsEx", conn);
                    sqlcmdMixRaw.CommandType = CommandType.StoredProcedure;
                    sqlcmdMixRaw.Parameters.AddWithValue("@fromDate", dateFromdate.EditValue);
                    sqlcmdMixRaw.Parameters.AddWithValue("@toDate", dateTodate.EditValue);
                    SqlDaMixRaw.SelectCommand = sqlcmdMixRaw;
                    SqlDaMixRaw.Fill(ds, "MixRaw");

                    SqlDataAdapter SqlDaCrush = new SqlDataAdapter();
                    SqlCommand sqlcmdCrush = new SqlCommand("sp_getFullCrushRawsEx", conn);
                    sqlcmdCrush.CommandType = CommandType.StoredProcedure;
                    sqlcmdCrush.Parameters.AddWithValue("@fromDate", dateFromdate.EditValue);
                    sqlcmdCrush.Parameters.AddWithValue("@toDate", dateTodate.EditValue);
                    SqlDaCrush.SelectCommand = sqlcmdCrush;
                    SqlDaCrush.Fill(ds, "CrushRaw");

                    if (!String.IsNullOrEmpty(productId))
                    {
                        SqlDataAdapter SqlDa = new SqlDataAdapter();
                        SqlCommand sqlcmd = new SqlCommand("sp_getMaterialsProduct_Scaled", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@ProductId", productId);
                        SqlDa.SelectCommand = sqlcmd;
                        SqlDa.Fill(ds, "MaterialProduct");
                    }
                    ExportDataSetToExcel(ds, "");

                    this.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void spbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private bool ExportDataSetToExcel(DataSet ds, string filename)
        {
            try
            {
                var dialog = new SaveFileDialog();
                dialog.Title = @"Export file to Excel";
                dialog.FileName = filename;
                dialog.Filter = @"Microsoft Excel|*.xlsx";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //Creae an Excel application instance
                    Excel.Application excelApp = new Excel.Application();

                    //Create an Excel workbook instance and open it from the predefined location
                    Excel.Workbook excelWorkBook = excelApp.Workbooks.Add(1);

                    foreach (DataTable table in ds.Tables)
                    {
                        //Add a new worksheet to workbook with the Datatable name
                        Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                        excelWorkSheet.Name = table.TableName;

                        for (int i = 1; i < table.Columns.Count + 1; i++)
                        {
                            excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                        }

                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            for (int k = 0; k < table.Columns.Count; k++)
                            {
                                excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                            }
                        }
                    }

                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Exproting data to Excel...");
                    for (int i = 0; i < 100; i++)
                    {
                        Thread.Sleep(10);
                    }
                    SplashScreenManager.CloseForm();

                    excelWorkBook.SaveAs(dialog.FileName);
                    excelWorkBook.Close();
                    excelApp.Quit();                    

                    XtraMessageBox.Show("Successed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);

                    if (File.Exists(dialog.FileName))
                    {
                        if (XtraMessageBox.Show("Do you want open file? ", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Process.Start(dialog.FileName);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error: " + e, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}