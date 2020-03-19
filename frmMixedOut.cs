using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            txtWeight.Text = "0";
            rdbRunner.Checked = true;
            Start_Timer();
            GetComPort();
            LoadComboBoxMixId();            
            LoadGridControl();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
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
            Double _weightRunner;
            Double _weightDefect;
            Double _weightBlackDot;
            Double _weightContaminated;
            int i;

            if (CheckExistedMixOut() == 0)
            {
                CreateMixOut();
            }
            else
            {                
                //Get data of fields weight
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter SqlDa = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("sp_getFullMixOut", conn);

                DataSet ds = new DataSet();
                try
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mixOutId", int.Parse(txtMixOutId.Text.ToString()));
                    SqlDa.SelectCommand = sqlcmd;
                    SqlDa.Fill(ds);
                    i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        _weightRunner = double.Parse(ds.Tables[0].Rows[0][1].ToString());
                        _weightDefect = double.Parse(ds.Tables[0].Rows[0][2].ToString());
                        _weightBlackDot = double.Parse(ds.Tables[0].Rows[0][3].ToString());
                        _weightContaminated = double.Parse(ds.Tables[0].Rows[0][4].ToString());

                        //Update Mixing Out Record by ID
                        SqlCommand cmdUpdate = new SqlCommand("sp_UpdateMixingOut", conn);
                        cmdUpdate.CommandType = CommandType.StoredProcedure;

                        switch (GetRadioChecked())
                        {
                            case "rdbRunner":
                                _weightRunner = double.Parse(txtScaleWeight.Text.ToString());
                                break;
                            case "rdbDefect":
                                _weightDefect = double.Parse(txtScaleWeight.Text.ToString());
                                break;
                            case "rdbBlackDot":
                                _weightBlackDot = double.Parse(txtScaleWeight.Text.ToString());
                                break;
                            case "rdbContaminated":
                                _weightContaminated = double.Parse(txtScaleWeight.Text.ToString());
                                break;
                        }

                        cmdUpdate.Parameters.AddWithValue("@weightRunner", _weightRunner);
                        cmdUpdate.Parameters.AddWithValue("@weightDefect", _weightDefect);
                        cmdUpdate.Parameters.AddWithValue("@weightBlackDot", _weightBlackDot);
                        cmdUpdate.Parameters.AddWithValue("@weightContaminated", _weightContaminated);
                        cmdUpdate.Parameters.AddWithValue("@weightRecycle", 0);
                        cmdUpdate.Parameters.AddWithValue("@weightCookie", 0);

                        cmdUpdate.Parameters.AddWithValue("@mixRawId", cmbMixId.SelectedValue);
                        cmdUpdate.Parameters.AddWithValue("@Id", txtMixOutId.Text);

                        conn.Open();

                        i = cmdUpdate.ExecuteNonQuery();

                        LoadGridControl();

                        if (i != 0)
                        {
                            MessageBox.Show(i + "Data Saved");
                        }
                        //End UpdateMixOut
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ScaleApp.Common.DataOperation.disconnect();
                //End get datas weight  
            }  
        }        
        
        private void CreateMixOut()
        {
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_createMixOut", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            switch (GetRadioChecked())
            {
                case "rdbRunner":
                    cmd.Parameters.AddWithValue("@weightRunner", txtScaleWeight.Text);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbDefect":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", txtScaleWeight.Text);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbBlackDot":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", txtScaleWeight.Text);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbContaminated":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", txtScaleWeight.Text);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
            }           
            cmd.Parameters.AddWithValue("@mixRawId", cmbMixId.SelectedValue);            

            conn.Open();

            int i = cmd.ExecuteNonQuery();
            LoadGridControl();

            ScaleApp.Common.DataOperation.disconnect();           

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }

        private void UpdateMixOut()
        {
            //Lay 1 record ra va luu cac Weight da ton tai, chi cap nhat Weight theo form
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            cmd.Parameters.AddWithValue("@mixRawId", cmbMixId.SelectedValue);
            cmd.Parameters.AddWithValue("@Id", txtMixOutId.Text);

            conn.Open();

            int i = cmd.ExecuteNonQuery();

            ScaleApp.Common.DataOperation.disconnect();

            LoadGridControl();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }

        private string GetRadioChecked()
        {
            string rdicheckName = "";
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    rdicheckName = rb.Name;
                    //MessageBox.Show(rb.Name + "-" + txtWeight.Text.ToString());                    
                }
            }
            return rdicheckName;
        }

        private int CheckExistedMixOut()
        {
            if (txtMixOutId.Text == "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        private void LoadComboBoxMixId()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getMixRaws", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["MixRawId"] = "0";
                blankRow["MixBacode"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow, 0);

                cmbMixId.DataSource = ds.Tables[0];
                cmbMixId.DisplayMember = "MixBacode";
                cmbMixId.ValueMember = "MixRawId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadMixRaw(int mixId)
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
                    cmbMixId.SelectedValue = ds.Tables[0].Rows[0][7].ToString();
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
            cmbMixId.SelectedValue = 0;
            txtWeight.Text = null;
            cmdSave.Enabled = true;
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
            UpdatePosted();
        }

        private void SetcmdPost()
        {
            if (txtPosted.Text.ToString() == "0")
            {
                cmdPosted.Enabled = true;
                cmdSave.Enabled = true;
            }
            else
            {
                cmdPosted.Enabled = false;
                cmdSave.Enabled = false;
            }
        }

        private void UpdatePosted()
        {
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_setMixOutPosted", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", txtMixOutId.Text);

            conn.Open();

            int i = cmd.ExecuteNonQuery();

            ScaleApp.Common.DataOperation.disconnect();

            if (i != 0)
            {
                MessageBox.Show("Data posted !");
                LoadGridControl();
                cmdSave.Enabled = false;
                cmdPosted.Enabled = false;
            }
        }

        private void LoadGridControl()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                SqlDataAdapter SqlDaCrush = new SqlDataAdapter("sp_getFullMixOuts", conn);
                SqlDaCrush.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaCrush.Fill(ds, "IncomingCrush");

                gridControl1.DataSource = ds.Tables["IncomingCrush"];
                gridControl1.ForceInitialize();

                gridView2.OptionsView.ColumnAutoWidth = false;

                gridView2.Columns["MixRawId"].VisibleIndex = -1;
                gridView2.Columns["WeightRecycle"].VisibleIndex = -1;
                gridView2.Columns["WeightCookie"].VisibleIndex = -1;

                gridView2.Columns["Id"].VisibleIndex = 0;
                gridView2.Columns["CreateTime"].VisibleIndex = 1;
                gridView2.Columns["MixBacode"].VisibleIndex = 2;
                gridView2.Columns["WeightRunner"].VisibleIndex = 3;
                gridView2.Columns["WeightDefect"].VisibleIndex = 4;
                gridView2.Columns["WeightBlackDot"].VisibleIndex = 5;
                gridView2.Columns["WeighContamination"].VisibleIndex = 6;                
                gridView2.Columns["Posted"].VisibleIndex = 9;

                gridView2.Columns["Id"].Width = 50;
                gridView2.Columns["CreateTime"].Width = 80;
                gridView2.Columns["MixBacode"].Width = 120;
                gridView2.Columns["WeightRunner"].Width = 100;
                gridView2.Columns["WeightDefect"].Width = 100;
                gridView2.Columns["WeightBlackDot"].Width = 100;
                gridView2.Columns["WeighContamination"].Width = 100;
                gridView2.Columns["WeightRecycle"].Width = 100;
                gridView2.Columns["WeightCookie"].Width = 100;
                gridView2.Columns["Posted"].Width = 50;

                gridView2.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView gridView = sender as GridView;

            txtMixOutId.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Id"]).ToString(); 
            txtPosted.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Posted"]).ToString();
            cmbMixId.SelectedValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]);

            SetcmdPost();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadGridControl();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "D:\\ExportExcel\\IncomingCrush.xlsx";

            XlsxExportOptionsEx xlsxExport = new XlsxExportOptionsEx();
            xlsxExport.ExportType = DevExpress.Export.ExportType.DataAware;

            gridControl1.ExportToXlsx(path);
            // Open the created XLSX file with the default application. 
            Process.Start(path);
        }

        private void GetComPort()
        {
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
            _serialPort = new SerialPort(cboComPort.Text, BaudRate, Parity.None, 8, StopBits.One);       //<-- Creates new SerialPort using the name selected in the combobox
            _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
            _serialPort.Open();     //<-- make the comport listen
            txtScaleWeight.Text = "Scaling... " + _serialPort.PortName + "...\r\n";
        }

        private void spbScale_Click(object sender, EventArgs e)
        {
            timer2.Tick += new EventHandler(Timer2_Tick);
            timer2.Enabled = true;
            ActionScale();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            CloseSerialPort();
            txtScaleWeight.Text = "Off";
        }
    }
}
