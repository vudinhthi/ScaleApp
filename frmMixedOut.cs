using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScaleApp
{
    public partial class frmMixedOut : Form
    {
        private SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        private const int BaudRate = 9600;      //<-- BaudRate Constant. 9600 seems to be the scale-units default value

        public frmMixedOut()
        {
            InitializeComponent();
        }        

        private void frmMixedOut_Load(object sender, EventArgs e)
        {
            timer2.Interval = ScaleApp.Properties.Settings.Default.TimeScale;
            //timer2.Interval = int.Parse(ConfigurationManager.AppSettings.Get("TimeScale"));
            txtWeight.Text = "0";
            rdbRunner.Checked = true;
            Start_Timer();
            GetComPort();
            LoadComboBoxMixId();            
            LoadGridControl();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void Start_Timer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            //SplashScreenManager.Default.SetWaitFormCaption("Updating data...");
            //for (int j = 0; j < 100; j++)
            //{
            //    Thread.Sleep(10);
            //}
            //SplashScreenManager.CloseForm();

            if (!String.IsNullOrEmpty(cmbMixId.EditValue.ToString()))
            {
                //CreateMixOut();
                string checkName = GetRadioChecked();
                MessageBox.Show(checkName);
            }              
        }

        //Ham nay dung khi 
        //private void UpdateOneRow()
        //{
              //Double _weightRunner;
              //Double _weightDefect;
              //Double _weightBlackDot;
              //Double _weightContaminated;
              //int i;
        //    //Get data of fields weight
        //    String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
        //    SqlConnection conn = new SqlConnection(connStr);
        //    SqlDataAdapter SqlDa = new SqlDataAdapter();
        //    SqlCommand sqlcmd = new SqlCommand("sp_getFullMixOut", conn);

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        sqlcmd.CommandType = CommandType.StoredProcedure;
        //        sqlcmd.Parameters.AddWithValue("@mixOutId", int.Parse(txtMixOutId.Text.ToString()));
        //        SqlDa.SelectCommand = sqlcmd;
        //        SqlDa.Fill(ds);
        //        i = ds.Tables[0].Rows.Count;
        //        if (i > 0)
        //        {
        //            _weightRunner = double.Parse(ds.Tables[0].Rows[0][1].ToString());
        //            _weightDefect = double.Parse(ds.Tables[0].Rows[0][2].ToString());
        //            _weightBlackDot = double.Parse(ds.Tables[0].Rows[0][3].ToString());
        //            _weightContaminated = double.Parse(ds.Tables[0].Rows[0][4].ToString());

        //            //Update Mixing Out Record by ID
        //            SqlCommand cmdUpdate = new SqlCommand("sp_UpdateMixingOut", conn);
        //            cmdUpdate.CommandType = CommandType.StoredProcedure;

        //            switch (GetRadioChecked())
        //            {
        //                case "rdbRunner":
        //                    _weightRunner = double.Parse(tedRealWeight.Text.ToString());
        //                    break;
        //                case "rdbDefect":
        //                    _weightDefect = double.Parse(tedRealWeight.Text.ToString());
        //                    break;
        //                case "rdbBlackDot":
        //                    _weightBlackDot = double.Parse(tedRealWeight.Text.ToString());
        //                    break;
        //                case "rdbContaminated":
        //                    _weightContaminated = double.Parse(tedRealWeight.Text.ToString());
        //                    break;
        //            }

        //            cmdUpdate.Parameters.AddWithValue("@weightRunner", _weightRunner);
        //            cmdUpdate.Parameters.AddWithValue("@weightDefect", _weightDefect);
        //            cmdUpdate.Parameters.AddWithValue("@weightBlackDot", _weightBlackDot);
        //            cmdUpdate.Parameters.AddWithValue("@weightContaminated", _weightContaminated);
        //            cmdUpdate.Parameters.AddWithValue("@weightRecycle", 0);
        //            cmdUpdate.Parameters.AddWithValue("@weightCookie", 0);

        //            cmdUpdate.Parameters.AddWithValue("@mixRawId", cmbMixId.EditValue);
        //            cmdUpdate.Parameters.AddWithValue("@Id", txtMixOutId.Text);

        //            conn.Open();

        //            i = cmdUpdate.ExecuteNonQuery();

        //            LoadGridControl();

        //            if (i != 0)
        //            {
        //                XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                LoadComboBoxMixId();
        //            }
        //            //End UpdateMixOut
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show("Lỗi: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    ScaleApp.Common.DataOperation.disconnect();
        //    //End get datas weight 
        //}

        private void CreateMixOut()
        {
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_createMixOut", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            switch (GetRadioChecked())
            {
                case "rdbRunner":
                    cmd.Parameters.AddWithValue("@weightRunner", tedRealWeight.Text);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbDefect":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", tedRealWeight.Text);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbBlackDot":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", tedRealWeight.Text);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbContaminated":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", tedRealWeight.Text);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
            }           
            cmd.Parameters.AddWithValue("@mixRawId", cmbMixId.EditValue);
            cmd.Parameters.AddWithValue("@shift", cbeShift.EditValue);

            conn.Open();

            int i = cmd.ExecuteNonQuery();
            LoadGridControl();

            ScaleApp.Common.DataOperation.disconnect();           

            if (i != 0)
            {
                XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }

        private void UpdateMixOut()
        {
            //Lay 1 record ra va luu cac Weight da ton tai, chi cap nhat Weight theo form
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            
            //Update Mixing Out Record by ID
            SqlCommand cmd = new SqlCommand("sp_UpdateMixingOut", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            switch (GetRadioChecked())
            {
                case "rdbRunner":
                    cmd.Parameters.AddWithValue("@weightRunner", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbDefect":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbBlackDot":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbContaminated":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
            }
            cmd.Parameters.AddWithValue("@mixRawId", cmbMixId.EditValue);
            cmd.Parameters.AddWithValue("@shift", cbeShift.EditValue);
            cmd.Parameters.AddWithValue("@Id", txtMixOutId.Text);

            conn.Open();

            int i = cmd.ExecuteNonQuery();
            LoadGridControl();

            ScaleApp.Common.DataOperation.disconnect();            

            if (i != 0)
            {
                XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }

        private string GetRadioChecked()
        {            
            string rdicheckName = "";

            for (int i = 0; i < layoutControlGroup3.Items.Count; i++)
            {
                LayoutControlItem item = layoutControlGroup3[i] as LayoutControlItem;
                RadioButton rb = item.Control as RadioButton;
                if (rb.Checked)
                {
                    rdicheckName = rb.Name;                    
                }
            }
            return rdicheckName;           
        }

        private int CheckExistedMixOut(int mixRawId)
        {
            int mixRawExists;
            
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand sqlcmd = new SqlCommand("sp_checkExistsMixOut", conn);

                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mixRawId", mixRawId);

                SqlParameter returnParameter = new SqlParameter("@LastIdentity", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add(returnParameter);
                conn.Open();
                sqlcmd.ExecuteNonQuery();

                mixRawExists = (int)sqlcmd.Parameters["@LastIdentity"].Value;
                
                ScaleApp.Common.DataOperation.disconnect();
                return mixRawExists;
                        
        }

        private void LoadComboBoxMixId()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getMixRaws", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }                

                cmbMixId.Properties.DataSource = ds.Tables[0];
                cmbMixId.Properties.DisplayMember = "MixBacode";
                cmbMixId.Properties.ValueMember = "MixRawId";

                cmbMixId.Properties.Columns.Add(new LookUpColumnInfo("MixRawId", "MixRawId", 40));
                cmbMixId.Properties.Columns.Add(new LookUpColumnInfo("MixBacode", "MixBacode", 120));
                //enable text editing 
                cmbMixId.Properties.TextEditStyle = TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadMixRaw(int mixId)
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter SqlDa = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand("sp_getMixRaw", conn);

            try
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mixRawId", mixId);
                SqlDa.SelectCommand = sqlcmd;
                SqlDa.Fill(ds);

                qrCodeMixId.Text = ds.Tables[0].Rows[0][12].ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadMixOut(int Id)
        {            
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter SqlDa = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand("sp_getFullMixOut", conn);

            DataSet ds = new DataSet();
            try
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mixOutId", Id);
                SqlDa.SelectCommand = sqlcmd;
                SqlDa.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    txtMixOutId.Text = ds.Tables[0].Rows[0][0].ToString();
                    cmbMixId.EditValue = ds.Tables[0].Rows[0][7].ToString();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void cmbMixId_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrCodeMixId.Text = cmbMixId.Text;
        }        

        private void cmdReset_Click(object sender, EventArgs e)
        {
            cmbMixId.EditValue = null;
            txtWeight.Text = null;
            cmbMixId.Focus();
        }

        private void gridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView1.CurrentCell.RowIndex != -1)
            {
                //do you staff.
                int rowindex = gridView1.CurrentCell.RowIndex;
                int columnindex = gridView1.CurrentCell.ColumnIndex;

                txtMixOutId.Text = gridView1.Rows[rowindex].Cells[0].Value.ToString();
                txtPosted.Text = gridView1.Rows[rowindex].Cells[9].Value.ToString();

                loadMixOut(int.Parse(txtMixOutId.Text.ToString()));
                SetcmdPost();
            }
        }

        private void cmdPosted_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Posting data...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();

            UpdatePosted();
        }

        private void SetcmdPost()
        {
            
        }

        private void UpdatePosted()
        {
            try
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("sp_setMixOutPosted", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", txtMixOutId.Text);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                ScaleApp.Common.DataOperation.disconnect();

                if (i != 0)
                {
                    XtraMessageBox.Show("Data was posted !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridControl();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoadGridControl()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                SqlDataAdapter SqlDaCrush = new SqlDataAdapter("sp_getFullMixOuts", conn);
                SqlDaCrush.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaCrush.Fill(ds, "IncomingCrush");

                gridControl1.DataSource = ds.Tables["IncomingCrush"];
                gridControl1.ForceInitialize();

                foreach (GridColumn column in gridView2.Columns)
                {
                    GridSummaryItem item = column.SummaryItem;
                    if (item != null)
                        column.Summary.Remove(item);
                }

                gridView2.OptionsView.ColumnAutoWidth = true;

                gridView2.Columns["MixRawId"].VisibleIndex = -1;
                gridView2.Columns["WeightRecycle"].VisibleIndex = -1;
                gridView2.Columns["WeightCookie"].VisibleIndex = -1;
                gridView2.Columns["Posted"].VisibleIndex = -1;
                gridView2.Columns["ItemID"].VisibleIndex = -1;
                gridView2.Columns["ItemName"].VisibleIndex = -1;
                gridView2.Columns["MachineName"].VisibleIndex = -1;
                gridView2.Columns["StepName"].VisibleIndex = -1;                

                gridView2.Columns["Id"].VisibleIndex = 0;
                gridView2.Columns["CreateTime"].VisibleIndex = 1;
                gridView2.Columns["Shift"].VisibleIndex = 2;
                gridView2.Columns["MixBacode"].VisibleIndex = 3;
                gridView2.Columns["WeightRunner"].VisibleIndex = 4;
                gridView2.Columns["WeightDefect"].VisibleIndex = 5;
                gridView2.Columns["WeightBlackDot"].VisibleIndex = 6;
                gridView2.Columns["WeighContamination"].VisibleIndex = 7;

                gridView2.Columns["MixBacode"].Caption = "Mix Lot Id";

                //gridView2.Columns["ItemID"].VisibleIndex = 3;
                //gridView2.Columns["ItemName"].VisibleIndex = 4;
                //gridView2.Columns["MachineName"].VisibleIndex = 5;
                //gridView2.Columns["StepName"].VisibleIndex = 6;
                //gridView2.Columns["ShiftName"].VisibleIndex = 7;
                //gridView2.Columns["WeightRunner"].VisibleIndex = 8;
                //gridView2.Columns["WeightDefect"].VisibleIndex = 9;
                //gridView2.Columns["WeightBlackDot"].VisibleIndex = 10;
                //gridView2.Columns["WeighContamination"].VisibleIndex = 11;

                gridView2.Columns["Id"].Width = 50;
                gridView2.Columns["Shift"].Width = 50;
                gridView2.Columns["CreateTime"].Width = 150;
                gridView2.Columns["MixBacode"].Width = 280;

                //gridView2.Columns["WeightRunner"].Width = 100;
                //gridView2.Columns["WeightDefect"].Width = 100;
                //gridView2.Columns["WeightBlackDot"].Width = 100;
                //gridView2.Columns["WeighContamination"].Width = 100;
                //gridView2.Columns["WeightRecycle"].Width = 100;
                //gridView2.Columns["WeightCookie"].Width = 100;
                //gridView2.Columns["Posted"].Width = 50;

                GridColumnSummaryItem totalWeightRunner = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WeightRunner", "{0:n3}");
                gridView2.Columns["WeightRunner"].Summary.Add(totalWeightRunner);
                GridColumnSummaryItem totalWeightDefect = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WeightDefect", "{0:n3}");
                gridView2.Columns["WeightDefect"].Summary.Add(totalWeightDefect);
                GridColumnSummaryItem totalWeightBlackDot = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WeightBlackDot", "{0:n3}");
                gridView2.Columns["WeightBlackDot"].Summary.Add(totalWeightBlackDot);
                GridColumnSummaryItem totalWeighContamination = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WeighContamination", "{0:n3}");
                gridView2.Columns["WeighContamination"].Summary.Add(totalWeighContamination);

                gridView2.Columns["CreateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView2.Columns["CreateTime"].DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";

                gridView2.Columns["WeightRunner"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView2.Columns["WeightRunner"].DisplayFormat.FormatString = "{0:n3}";
                gridView2.Columns["WeightDefect"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView2.Columns["WeightDefect"].DisplayFormat.FormatString = "{0:n3}";
                gridView2.Columns["WeightBlackDot"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView2.Columns["WeightBlackDot"].DisplayFormat.FormatString = "{0:n3}";
                gridView2.Columns["WeighContamination"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView2.Columns["WeighContamination"].DisplayFormat.FormatString = "{0:n3}";

                gridView2.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView gridView = sender as GridView;

            txtMixOutId.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Id"]).ToString(); 
            txtPosted.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Posted"]).ToString();
            cmbMixId.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]);
            cbeShift.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Shift"]);
            qrCodeMixId.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]).ToString();
            //SetcmdPost();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Getting new data...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
            //LoadComboBoxMixId();
            //LoadGridControl();
            gridControl1.RefreshDataSource();            
        }

        //Action for button Export Excel
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmDateRange frmDate = new frmDateRange();
            //frmDate.ExportName = 3;
            //frmDate.Show();            

            ExportExcel("");
        }

        private bool ExportExcel(string filename)
        {
            try
            {
                var dialog = new SaveFileDialog();
                dialog.Title = @"Export file to Excel";
                dialog.FileName = filename;
                dialog.Filter = @"Microsoft Excel|*.xlsx";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    gridView2.OptionsPrint.ShowPrintExportProgress = true;
                    gridView2.OptionsPrint.AllowCancelPrintExport = true;
                    gridView2.OptionsPrint.AutoWidth = true;

                    //Hien cac cot trong grid
                    gridView2.Columns["Id"].VisibleIndex = 0;
                    gridView2.Columns["CreateTime"].VisibleIndex = 1;
                    gridView2.Columns["MixBacode"].VisibleIndex = 2;
                    gridView2.Columns["ItemID"].VisibleIndex = 3;
                    gridView2.Columns["ItemName"].VisibleIndex = 4;
                    gridView2.Columns["MachineName"].VisibleIndex = 5;
                    gridView2.Columns["StepName"].VisibleIndex = 6;
                    gridView2.Columns["ShiftName"].VisibleIndex = 7;
                    gridView2.Columns["WeightRunner"].VisibleIndex = 8;
                    gridView2.Columns["WeightDefect"].VisibleIndex = 9;
                    gridView2.Columns["WeightBlackDot"].VisibleIndex = 10;
                    gridView2.Columns["WeighContamination"].VisibleIndex = 11;

                    XlsxExportOptions options = new XlsxExportOptions();
                    options.TextExportMode = TextExportMode.Value;
                    options.ExportMode = XlsxExportMode.SingleFilePageByPage;
                    options.SheetName = "Incoming Crush";

                    ExportSettings.DefaultExportType = ExportType.Default;
                    gridView2.ExportToXlsx(dialog.FileName, options);

                    //An cac cot trong grid
                    gridView2.Columns["ItemID"].VisibleIndex = -1;
                    gridView2.Columns["ItemName"].VisibleIndex = -1;
                    gridView2.Columns["MachineName"].VisibleIndex = -1;
                    gridView2.Columns["StepName"].VisibleIndex = -1;
                    gridView2.Columns["ShiftName"].VisibleIndex = -1;                    

                    XtraMessageBox.Show("Xuất dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);

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

                    excelWorkBook.SaveAs(dialog.FileName);
                    excelWorkBook.Close();
                    excelApp.Quit();

                    XtraMessageBox.Show("Xuất dữ liệu thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);

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

        private void GetComPort()
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                SerialPort port = new SerialPort(portName);
                if (port.IsOpen)
                {
                    port.Close();
                    port.Dispose();
                }
            }

            string[] portNames = SerialPort.GetPortNames();     //<-- Reads all available comPorts
            foreach (var portName in portNames)
            {
                cboComPort.Items.Add(portName);                  //<-- Adds Ports to combobox
            }
            cboComPort.SelectedIndex = 0;                        //<-- Selects first entry (convenience purposes)

            //<-- This block ensures that no exceptions happen
            if (_serialPort != null && _serialPort.IsOpen)
                _serialPort.Close();
            if (_serialPort != null)
                _serialPort.Dispose();
            //<-- End of Block
        }

        private void CloseSerialPort()
        {            
            if (_serialPort != null && _serialPort.IsOpen)
                _serialPort.Close();
            if (_serialPort != null)
                _serialPort.Dispose();
        }

        private delegate void Closure();

        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            if (InvokeRequired)     //<-- Makes sure the function is invoked to work properly in the UI-Thread
                BeginInvoke(new Closure(() => { SerialPortOnDataReceived(sender, serialDataReceivedEventArgs); }));     //<-- Function invokes itself
            else
            {
                int dataLength = _serialPort.BytesToRead;

                byte[] data = new byte[dataLength];
                int nbrDataRead = _serialPort.Read(data, 0, dataLength);
                if (nbrDataRead == 0)
                {
                    return;
                }
                string str = Encoding.UTF8.GetString(data);

                //Buffers values in a file
                File.AppendAllText("buffer1", str);

                //Read from buffer and write into "strnew" String
                string strnew = File.ReadLines("buffer1").Last();

                //Shows actual true value coming from scale
                txtScaleWeight.Text = strnew;
                Regex digits = new Regex(@"^\D*?((-?(\d+(\.\d+)?))|(-?\.\d+)).*");
                Match mx = digits.Match(txtScaleWeight.Text);
                decimal strValue = mx.Success ? Convert.ToDecimal(mx.Groups[1].Value) : 0;
                txtScaleWeight.Text = strValue.ToString();
            }
        }

        private void ActionScale()
        {
            try 
            {
                //_serialPort = new SerialPort(cboComPort.Text, BaudRate, Parity.None, 8, StopBits.One);       //<-- Creates new SerialPort using the name selected in the combobox
                _serialPort = new SerialPort(ScaleApp.Properties.Settings.Default.COMPort, BaudRate, Parity.None, 8, StopBits.One);
                _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
                _serialPort.Open();     //<-- make the comport listen
                txtScaleWeight.Text = "Scaling... " + _serialPort.PortName + "...\r\n";
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show(ex.Message + " - Cân đang đóng!" + Environment.NewLine + "Vui lòng tắt form và mở lại để tiếp tục nhập !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseSerialPort();
            }
        }

        private void spbScale_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
            timer2.Tick += new EventHandler(Timer2_Tick);
            timer2.Enabled = true;
            ActionScale();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            CloseSerialPort();
            txtScaleWeight.Text = "0";
        }        

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //GridView gridView = sender as GridView;

            //txtMixOutId.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Id"]).ToString();
            //txtPosted.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Posted"]).ToString();
            //cmbMixId.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]);

            //SetcmdPost();
        }

        private void tedRealWeight_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit editorWeightRe = (ButtonEdit)sender;
            EditorButton Button = e.Button;

            if (Button.Kind == ButtonPredefines.OK)
            {
                if (!String.IsNullOrEmpty(txtScaleWeight.Text) && (txtScaleWeight.Text != "0"))
                {
                    editorWeightRe.Text = (Double.Parse(txtScaleWeight.Text) - 2.1966).ToString();

                    editorWeightRe.ToolTipIconType = ToolTipIconType.Information;
                    editorWeightRe.ToolTip = txtScaleWeight.Text + "-2.1966";
                }                

                tedRealWeight.Properties.DisplayFormat.FormatType = FormatType.Numeric;
                tedRealWeight.Properties.DisplayFormat.FormatString = "{0:n3}";
            }
            else if (Button.Kind == ButtonPredefines.Delete)
            {
                editorWeightRe.Text = "";
            }
        }

        private void frmMixedOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSerialPort();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (cmbMixId.EditValue != null || tedRealWeight.EditValue != null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Updating data...");
                for (int j = 0; j < 100; j++)
                {
                    Thread.Sleep(10);
                }
                SplashScreenManager.CloseForm();
                CreateMixOut();
            }
            else
            {
                XtraMessageBox.Show("Chọn Mix Lot Id và thực hiện cân!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
