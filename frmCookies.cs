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
using ScaleApp.Models;
using ScaleApp.Common;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using DevExpress.Export;
using DevExpress.XtraPrinting;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace ScaleApp
{
    public partial class frmCookies : DevExpress.XtraEditors.XtraForm
    {
       
        DataSet ds = new DataSet();
        private SerialPort _serialPort;
        private const int BaudRate = 9600;
        System.Timers.Timer tm = new System.Timers.Timer();
        public frmCookies()
        {
            InitializeComponent();
        }

        private void frmCookies_Load(object sender, EventArgs e)
        {
           
            //List<ItemClass> litem = new  List<ItemClass>();
            // lkeItem.Properties.DataSource = litem;
            // lkeItem.Properties.DisplayMember = "name";
            foreach (var item in grcMeasureValue.Items)
            { 
                if (item is LayoutControlItem)
                {
                    LayoutControlItem controlItem = item as LayoutControlItem;
                    if (controlItem.Control is ButtonEdit)
                    {
                        ButtonEdit btnEdit = controlItem.Control as ButtonEdit;
                        btnEdit.Properties.Buttons[0].Click += (s, o) => {
                            btnEdit.Text = txtPurgingInput.Text;
                        };
                        btnEdit.Properties.Buttons[1].Click += (s, o) => {
                            btnEdit.Text = "";
                        };
                    }



                }
            }
            InitLookupEdit();
            InitDataGridview();
        
        }
        private void InitLookupEdit()
        {
            ds.Clear();
            if (ds.Tables[""] != null)
            {
                ds.Tables["tbComponent"].Clear();
            }
            if (ds.Tables["tbScrewsize"] != null)
            {
                ds.Tables["tbScrewsize"].Clear();
            }
            if (ds.Tables["tbItem"] != null)
            {
                ds.Tables["tbItem"].Clear();
            }
            ds = DataOperation.SelectItem(2, "sp_getProductsWinLine");
            ds = DataOperation.SelectReason(2, "sp_GetReason");
            //  DataView dvScrewsize, dvComponent;
            // DataViewManager dvm = new DataViewManager(ds);
            //  dvComponent = dvm.CreateDataView(ds.Tables["tbComponent"]);
            //  dvScrewsize = dvm.CreateDataView(ds.Tables["tbScrewsize"]);
            //Item
           lkeItem.Properties.DataSource = ds.Tables["tbItem"];
           lkeItem.Properties.ValueMember = "c002";
           lkeItem.Properties.DisplayMember = "c003";
           lkeItem.EditValue = ds.Tables["tbItem"].Rows[0][0];
            lkeItem.Properties.Columns.Add(new LookUpColumnInfo("c002", "Item Code", 200));
            lkeItem.Properties.Columns.Add(new LookUpColumnInfo("c003", "Item Name", 500));

            //lkeItem.Properties.PopulateColumns();
            //Component
            
            //Screwsize
            //Reason
            lkeReason.Properties.DataSource = ds.Tables["tbReason"];
            lkeReason.Properties.ValueMember = "ReasonID";
            lkeReason.Properties.DisplayMember = "Cause";
            lkeReason.EditValue = ds.Tables["tbReason"].Rows[0][0];
            lkeReason.Properties.PopulateColumns();
            lkeReason.Properties.Columns["ItemID"].Visible = false;
            lkeReason.Properties.Columns["ReasonID"].Width = 60;
        }
        private void InitDataGridview()
        {
            
            if (ds.Tables["tbCookies"] != null)
            {
                ds.Tables["tbCookies"].Clear();
            }
         
            ds = DataOperation.SelectCookies(2, "sp_GetCookies", lkeItem.EditValue.ToString());
            if (ds!=null)
            {
                gctCookies.DataSource = ds.Tables["tbCookies"];
                gvCookies.OptionsBehavior.ReadOnly = true;
                gvCookies.Columns["PurgeDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gvCookies.Columns["PurgeDate"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss";
          
                gvCookies.Columns["ItemID"].Visible = false;
                gvCookies.Columns["CookiesID"].Width = 40;
                gvCookies.Columns["Shift"].Width = 30;
                gvCookies.Columns["PurgeDate"].Width = 120;
                gvCookies.Columns["MachineNo"].Width = 50;
                gvCookies.Columns["Screwsize"].Width = 50;
                gvCookies.Columns["Item"].Width = 300;
                //gvCookies.Columns["Item"].BestFit();

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                CookiesClass cookiesClass = new CookiesClass();

                cookiesClass.MachineNo = txtMachineNo.Text;
                cookiesClass.Item = lkeItem.Text;
                cookiesClass.Component = lkeComponent.Text;
                cookiesClass.Screwsize = lkeScrewsize.Text;
                cookiesClass.Shift = cbbShift.Text;
                cookiesClass.PurgingMaterial = cbbPurgingMaterial.Text;
                cookiesClass.PurgingInput = txtPurgingInput.Text;
                cookiesClass.PurgingCookies = btnPurgingCookies.Text;
                cookiesClass.TPUCookies = btnTPUCookies.Text;
                cookiesClass.MixedCookies = btnMixedCookies.Text;
                cookiesClass.Reason = lkeReason.Text;
                cookiesClass.ItemID = lkeItem.EditValue.ToString();
                DataOperation.InsertorUpdate(2, "sp_InsertOrUpdateCookies", cookiesClass);
                InitDataGridview();
                XtraMessageBox.Show("Lưu thành công!", "Thông báo");
            }
            //cookiesClass.MachineNo = Convert.ToInt32(txtMachineNo.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = @"Export file to Excel";
            dialog.Filter = @"Microsoft Excel|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                    //SplashScreenManager.Default.SetWaitFormCaption("Exporting...");
                    //for (int i = 0; i < 100; i++)
                    //{
                    //    Thread.Sleep(10);
                    //}
                    XlsxExportOptionsEx optionsEx = new XlsxExportOptionsEx();
                    // gvCookies.OptionsPrint.ShowPrintExportProgress = true;
                    optionsEx.AllowFixedColumnHeaderPanel = DevExpress.Utils.DefaultBoolean.True;
                    optionsEx.AllowConditionalFormatting = DevExpress.Utils.DefaultBoolean.True;
                    optionsEx.ApplyFormattingToEntireColumn = DevExpress.Utils.DefaultBoolean.True;
                    optionsEx.SheetName = "Data";
                    gctCookies.ExportToXlsx(dialog.FileName, optionsEx);
                    // SplashScreenManager.CloseForm();
                    Process.Start("Report.xlsx");
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bảng tính đang mở, vui lòng tắt bảng tính trước khi xuất Excel ", "Lỗi");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gctCookies.DataSource = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitDataGridview();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            //CloseSerialPort();
            btnScale.Enabled = false;
            tm.Interval = 3000;
            tm.Enabled = true;
            tm.Elapsed += (s,o) =>
            {
                CloseSerialPort();
                tm.Enabled = true;
                btnScale.Invoke(new MethodInvoker(() => { btnScale.Enabled = true; }
                ));  
            };
            ActionScale();
        }
        private void CloseSerialPort()
        {
            if (_serialPort != null && _serialPort.IsOpen)
                _serialPort.Close();
            if (_serialPort != null)
                _serialPort.Dispose();
        }
        private void ActionScale()
        {
            _serialPort = new SerialPort("COM2", BaudRate, Parity.None, 8, StopBits.One);       //<-- Creates new SerialPort using the name selected in the combobox
            _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
            _serialPort.Open();     //<-- make the comport listen
        }
        private delegate void Closure();
        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            if (InvokeRequired)     //<-- Makes sure the function is invoked to work properly in the UI-Thread
                BeginInvoke(new Closure(() => {SerialPortOnDataReceived(sender, serialDataReceivedEventArgs); }));     //<-- Function invokes itself
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
                Regex digits = new Regex(@"^\D*?((-?(\d+(\.\d+)?))|(-?\.\d+)).*");
                Match mx = digits.Match(strnew);
                decimal strValue = mx.Success ? Convert.ToDecimal(mx.Groups[1].Value) : 0;
                txtPurgingInput.Text = strValue.ToString();
            }
        }

        private void frmCookies_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSerialPort();
        }
        bool isLoaded = false;
        private void lkeItem_EditValueChanged(object sender, EventArgs e)
        {
            ds = DataOperation.SelectComponent(2, "sp_GetComponent", lkeItem.EditValue.ToString());
            lkeComponent.Properties.DataSource = ds.Tables["tbComponent"];
            if (ds.Tables["tbComponent"] != null && ds.Tables["tbComponent"].Rows.Count != 0)
            {
                lkeComponent.Properties.ValueMember = "componentID";
                lkeComponent.Properties.DisplayMember = "name";
                lkeComponent.EditValue = ds.Tables["tbComponent"].Rows[0][0];
                lkeComponent.Properties.PopulateColumns();
                lkeComponent.Properties.Columns["ItemID"].Visible = false;
                lkeComponent.Properties.Columns["componentID"].Caption = "ComponentID";
                lkeComponent.Properties.Columns["name"].Caption = "Name";
                lkeComponent.Properties.Columns["name"].Width = 200;
                isLoaded = true;
            }
            else
            {
                lkeComponent.Properties.DataSource = null;
                lkeComponent.ResetText();
                lkeScrewsize.Properties.DataSource = null;
                lkeScrewsize.Text = "";
            }

        }

        private void lkeScrewsize_EditValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void lkeComponent_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                ds = DataOperation.SelectSrewsize(2, "sp_GetScrewsize", lkeItem.EditValue.ToString(), Convert.ToInt32(lkeComponent.EditValue), 2);
                lkeScrewsize.Properties.DataSource = ds.Tables["tbScrewsize"];
                if (ds.Tables["tbScrewsize"] != null && ds.Tables["tbScrewsize"].Rows.Count != 0)
                {
                    lkeScrewsize.Properties.ValueMember = "screwsizeID";
                    lkeScrewsize.Properties.DisplayMember = "value";
                    lkeScrewsize.EditValue = ds.Tables["tbScrewsize"].Rows[0][0];
                    lkeScrewsize.Properties.PopulateColumns();
                    lkeScrewsize.Properties.Columns["ItemID"].Visible = false;
                    lkeScrewsize.Properties.Columns["componentID"].Visible = false;
                    lkeScrewsize.Properties.Columns["screwsizeID"].Caption = "ScrewsizeID";
                    lkeScrewsize.Properties.Columns["screwsizeID"].Width = 30;
                    lkeScrewsize.Properties.Columns["value"].Caption = "Value";
                }
            }
        }
    }
}