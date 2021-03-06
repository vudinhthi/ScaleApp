﻿using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using ScaleApp.Common;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScaleApp
{
    public partial class frmCrushing : Form
    {
        private Control _focusedControl;
        private SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        private const int BaudRate = 9600;      //<-- BaudRate Constant. 9600 seems to be the scale-units default value

        public frmCrushing()
        {
            //serialPortCrush = Program._serialPort;
            InitializeComponent();
        }

        private void frmCrushing_Load(object sender, EventArgs e)
        {
            timer2.Interval = ScaleApp.Properties.Settings.Default.TimeScale;
            //Start_Timer();
            GetComPort();
            loadComboBoxOperator();
            loadComboBoxStep();
            LoadLookUpReType();
            LoadLookUpMixId();
            //LoadLookUpProduct();
            //cmdPost.Enabled = false;
            LoadGridControl1();
        }

        private void Start_Timer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //txtNow.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void loadComboBoxOperator()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getOperatorsCrush", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();                

                cmbOperator.Properties.DataSource = ds.Tables[0];
                cmbOperator.Properties.DisplayMember = "OperatorName";
                cmbOperator.Properties.ValueMember = "OperatorCode";

                cmbOperator.Properties.Columns.Add(new LookUpColumnInfo("OperatorCode", "OperatorCode", 40));
                cmbOperator.Properties.Columns.Add(new LookUpColumnInfo("OperatorName", "OperatorName", 120));
                //enable text editing 
                cmbOperator.Properties.TextEditStyle = TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadComboBoxStep()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getSteps", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["StepCode"] = "None";
                blankRow["StepName"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow, 0);

                cmbStep.DataSource = ds.Tables[0];
                cmbStep.DisplayMember = "StepName";
                cmbStep.ValueMember = "StepCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadComboBoxProduct()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getProducts", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["ProductCode"] = "None";
                blankRow["ProductName"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow, 0);

                cmbProduct.DataSource = ds.Tables[0];
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadComboBoxColor()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getColors", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["ColorCode"] = "None";
                blankRow["ColorName"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow, 0);

                cmbColor.DataSource = ds.Tables[0];
                cmbColor.DisplayMember = "ColorName";
                cmbColor.ValueMember = "ColorCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadComboBoxMaterial()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getMaterials", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["MaterialCode"] = "None";
                blankRow["MaterialName"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow, 0);

                cmbMaterial.DataSource = ds.Tables[0];
                cmbMaterial.DisplayMember = "MaterialName";
                cmbMaterial.ValueMember = "MaterialCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void loadColorsByProduct(string productId)
        {
            if (lueProduct.EditValue.IsNullOrEmpty())
            {
                return;
            }
            else
            {
                DataSet ds = new DataSet();
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(2);
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter SqlDa = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("sp_getColorsProduct", conn);
                try
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@ProductId", productId);
                    SqlDa.SelectCommand = sqlcmd;

                    SqlDa.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        tedColorCode.Text = ds.Tables[0].Rows[0][1].ToString();
                        tedColor.Text = ds.Tables[0].Rows[0][2].ToString();
                    }
                    else
                    {
                        tedColorCode.Text = "";
                        tedColor.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ScaleApp.Common.DataOperation.disconnect();
            }

        }

        private void loadComboBoxMixId()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getMixRawsPosted", conn))
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

        private void generateTextQRCode()
        {
            String qrCodeText = "";
            String qrCodeMfunction = ScaleApp.Common.mFunction.GenerateTextQRCode("RE", DateTime.Today);            
            
            qrCodeText = qrCodeMfunction + "|" + lueProduct.EditValue + "|" + getLastCrushRawId().ToString();
            qrCodeCrush.Text = qrCodeText;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem.IsNull())
            {
                return;
            }
            else
            {
                loadColorsByProduct(cmbProduct.SelectedValue.ToString());
            }            
        }        

        private void txtWeightRM_LostFocus(object sender, EventArgs e)
        {
            _focusedControl = (Control)sender;            
        }

        private void loadGridCrush()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getFullCrushRaws", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }                
                //Select only one row
                gridCrushed.MultiSelect = false;
                gridCrushed.AutoGenerateColumns = false;

                gridCrushed.DataSource = ds.Tables[0];

                gridCrushed.Columns["ID"].DataPropertyName = "CrushRawId";
                gridCrushed.Columns["Date"].DataPropertyName = "CreateTime";
                gridCrushed.Columns["RecycledId"].DataPropertyName = "RecycledID";
                gridCrushed.Columns["MixID"].DataPropertyName = "MixBacode";
                gridCrushed.Columns["Shift"].DataPropertyName = "ShiftName";
                gridCrushed.Columns["Operator"].DataPropertyName = "OperatorName";
                gridCrushed.Columns["Item"].DataPropertyName = "ProductName";
                gridCrushed.Columns["Material"].DataPropertyName = "MaterialName";
                gridCrushed.Columns["Color"].DataPropertyName = "ColorName";
                gridCrushed.Columns["Step"].DataPropertyName = "StepName";
                gridCrushed.Columns["Losttype"].DataPropertyName = "LossTypeName";
                gridCrushed.Columns["Weight"].DataPropertyName = "WeightRecycle";
                gridCrushed.Columns["Machine"].DataPropertyName = "MachineName";
                gridCrushed.Columns["Posted"].DataPropertyName = "Posted";

                gridCrushed.Columns["ID"].Width = 40;
                gridCrushed.Columns["Date"].Width = 100;
                gridCrushed.Columns["RecycledId"].Width = 120;
                gridCrushed.Columns["MixID"].Width = 120;
                gridCrushed.Columns["Shift"].Width = 40;
                gridCrushed.Columns["Operator"].Width = 80;
                gridCrushed.Columns["Item"].Width = 120;
                gridCrushed.Columns["Material"].Width = 120;
                gridCrushed.Columns["Color"].Width = 100;
                gridCrushed.Columns["Step"].Width = 40;
                gridCrushed.Columns["Losttype"].Width = 80;
                gridCrushed.Columns["Weight"].Width = 80;
                gridCrushed.Columns["Machine"].Width = 40;
                gridCrushed.Columns["Posted"].Width = 40;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private int CheckValidForm()
        {
            if (lueMixId.EditValue == null || txtWeightRe.Text == null)
            {
                return 0;
            }
            return 1;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Updating data...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();

            if (txtCrushID.Text.IsNullOrEmpty())
            {
                if (CheckValidForm() == 0)
                {
                    XtraMessageBox.Show("Chọn Mix Lot và nhập số cân !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CreateCrushRaw();
                }
            }
            else
            {
                UpdateCrushRaw();
            }                      
        }

        private void CreateCrushRaw()
        {
            try
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("sp_createCrushRaw", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@shiftID", cmbShift.SelectedItem);
                cmd.Parameters.AddWithValue("@operatorCode", cmbOperator.EditValue);
                cmd.Parameters.AddWithValue("@productCode", lueProduct.EditValue);
                cmd.Parameters.AddWithValue("@productName", tedProductName.Text);
                cmd.Parameters.AddWithValue("@materialCode", lueMixId.GetColumnValue("MaterialName"));
                cmd.Parameters.AddWithValue("@materialName", lueMixId.GetColumnValue("MaterialName1"));
                cmd.Parameters.AddWithValue("@colorCode", tedColorCode.Text);
                cmd.Parameters.AddWithValue("@colorName", tedColor.Text);
                cmd.Parameters.AddWithValue("@stepId", cmbStep.SelectedValue);
                cmd.Parameters.AddWithValue("@weightRecycle", txtWeightRe.Text);
                //cmd.Parameters.AddWithValue("@lostType", cmbLostType.SelectedItem);
                cmd.Parameters.AddWithValue("@lostTypeId", lueReType.GetColumnValue("Id"));
                cmd.Parameters.AddWithValue("@lostType", lueReType.GetColumnValue("LossTypeName"));
                cmd.Parameters.AddWithValue("@mixRawId", lueMixId.EditValue);
                cmd.Parameters.AddWithValue("@machineID", txtMachine.Text);
                cmd.Parameters.AddWithValue("@qrCode", qrCodeCrush.Text);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                ScaleApp.Common.DataOperation.disconnect();

                if (i != 0)
                {
                    XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdSave.Enabled = false;
                    //cmdPost.Enabled = false;
                    LoadGridControl1();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void UpdateCrushRaw()
        {
            try
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("sp_editCrushRaw", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@shiftID", cmbShift.SelectedItem);
                cmd.Parameters.AddWithValue("@operatorCode", cmbOperator.EditValue);
                cmd.Parameters.AddWithValue("@productCode", lueProduct.EditValue);
                cmd.Parameters.AddWithValue("@productName", tedProductName.Text);
                cmd.Parameters.AddWithValue("@materialCode", lueMixId.GetColumnValue("MaterialName"));
                cmd.Parameters.AddWithValue("@materialName", lueMixId.GetColumnValue("MaterialName1"));
                cmd.Parameters.AddWithValue("@colorCode", tedColorCode.Text);
                cmd.Parameters.AddWithValue("@colorName", tedColor.Text);
                cmd.Parameters.AddWithValue("@stepId", cmbStep.SelectedValue);
                cmd.Parameters.AddWithValue("@weightRecycle", txtWeightRe.Text);
                cmd.Parameters.AddWithValue("@lostType", cmbLostType.SelectedItem);
                cmd.Parameters.AddWithValue("@mixRawId", lueMixId.EditValue);
                cmd.Parameters.AddWithValue("@machineID", txtMachine.Text);
                cmd.Parameters.AddWithValue("@crushRawId", txtCrushID.Text);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                ScaleApp.Common.DataOperation.disconnect();

                if (i != 0)
                {
                    XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridControl1();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridCrushed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCrushed.CurrentCell.RowIndex != -1)
            {
                //do you staff.
                int rowindex = gridCrushed.CurrentCell.RowIndex;
                int columnindex = gridCrushed.CurrentCell.ColumnIndex;

                txtCrushID.Text = gridCrushed.Rows[rowindex].Cells[0].Value.ToString();
                txtPosted.Text = gridCrushed.Rows[rowindex].Cells[13].Value.ToString();
                loadCrushRaw(int.Parse(txtCrushID.Text.ToString()));
                SetcmdPost();
            }
        }

        private void loadCrushRaw(int crushId)
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter SqlDa = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand("sp_getFullCrushRaw", conn);

            try
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@crushRawId", crushId);
                SqlDa.SelectCommand = sqlcmd;
                SqlDa.Fill(ds);

                cmbShift.SelectedItem = ds.Tables[0].Rows[0][1]; //Get ShiftID
                cmbLostType.SelectedItem = ds.Tables[0].Rows[0][12]; //Get Lost Type
                cmbOperator.EditValue = ds.Tables[0].Rows[0][2]; //Get Operator
                lueProduct.EditValue = ds.Tables[0].Rows[0][4]; //Get Item
                lueMaterial.EditValue = ds.Tables[0].Rows[0][6]; //Get Material
                tedColor.Text = ds.Tables[0].Rows[0][8].ToString(); //Get Color
                cmbStep.SelectedValue = ds.Tables[0].Rows[0][10]; //Get Step
                lueMixId.EditValue = ds.Tables[0].Rows[0][13]; //Get Crush Lot ID

                txtWeightRe.Text = ds.Tables[0].Rows[0][11].ToString(); //Get Weight Recycled
                txtMachine.Text = ds.Tables[0].Rows[0][15].ToString(); //Get Machine
                
                qrCodeCrush.Text = ds.Tables[0].Rows[0][18].ToString(); //Get Crush Lot ID
                
                //txtCrushDate.Text = ds.Tables[0].Rows[0][17].ToString(); //Get Crush Lot Date
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void resetForm()
        {
            cmbShift.SelectedItem = null;
            //cmbLostType.SelectedItem = null;
            lueReType.EditValue = null;
            cmbOperator.EditValue = null;
            txtMachine.Text = null;
            cmbStep.SelectedValue = "None";            
            lueProduct.EditValue = null;
            tedColorCode.Text = null;
            tedColor.Text = null;            
            lueMaterial.EditValue = null;
            lueMixId.EditValue = null;            
            txtWeightRe.Text = null;
            //txtCrushDate.Text = null;
            txtCrushID.Text = null;
            txtPosted.Text = "0";
            lueMixId.Focus();
        }

        private int getLastCrushRawId()
        {
            int lastCrushRawId;

            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlcmd = new SqlCommand("sp_getLastIdentity", conn);
            
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter returnParameter = new SqlParameter("@LastIdentity", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            sqlcmd.Parameters.Add(returnParameter);
            conn.Open();
            sqlcmd.ExecuteNonQuery();
            
            lastCrushRawId = (int)sqlcmd.Parameters["@LastIdentity"].Value + 1;
            ScaleApp.Common.DataOperation.disconnect();

            return lastCrushRawId;
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            resetForm();
            cmdSave.Enabled = true;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdGetWeight_Click(object sender, EventArgs e)
        {
            getLastCrushRawId();
        }

        private void SetcmdPost()
        {
            if (txtPosted.Text.ToString() == "0")
            {
                //cmdPost.Enabled = true;
                cmdSave.Enabled = true;
            }
            else
            {
                //cmdPost.Enabled = false;
                cmdSave.Enabled = false;
            }
        }

        private void UpdatePosted()
        {
            try
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("sp_setCrushPosted", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@crushRawId", txtCrushID.Text);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                ScaleApp.Common.DataOperation.disconnect();

                if (i != 0)
                {
                    XtraMessageBox.Show("Crush Raw Lot posted !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridControl1();
                    cmdSave.Enabled = false;
                    //cmdPost.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdPost_Click(object sender, EventArgs e)
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

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            frmReportCrush reportCrush = new frmReportCrush();

            if (txtCrushID.Text.IsNullOrEmpty())
            {
                XtraMessageBox.Show("Chọn Crush Lot để in !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                reportCrush.MixID = int.Parse(txtCrushID.Text.ToString());
                reportCrush.Show();
            }
        }

        private void LoadLookUpReType()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getReTypes", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                lueReType.Properties.DataSource = ds.Tables[0];
                lueReType.Properties.DisplayMember = "LossTypeName";
                lueReType.Properties.ValueMember = "Id";

                lueReType.Properties.Columns.Add(new LookUpColumnInfo("Id", "Id", 20));
                lueReType.Properties.Columns.Add(new LookUpColumnInfo("LossTypeName", "LossTypeName", 120));

                lueReType.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void LoadLookUpMaterial()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(2);
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
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void LoadLookUpMixId()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getMixRawsPosted", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                lueMixId.Properties.DataSource = ds.Tables[0];
                lueMixId.Properties.DisplayMember = "MixBacode";
                lueMixId.Properties.ValueMember = "MixRawId";

                lueMixId.Properties.Columns.Add(new LookUpColumnInfo("MixRawId", "MixRawId", 20));
                lueMixId.Properties.Columns.Add(new LookUpColumnInfo("MixBacode", "MixBacode", 60));
                lueMixId.Properties.Columns.Add(new LookUpColumnInfo("ProductName", "ProductName", 60));

                lueMixId.Properties.TextEditStyle= TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void lueMixId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMixId.EditValue.IsNullOrEmpty())
            {
                lueProduct.EditValue = null;
                tedProductName.Text = null;
                tedColorCode.Text = null;
                tedColor.Text = null;
                txtMachineMix.Text = null;
            }
            else
            {
                lueProduct.EditValue = lueMixId.GetColumnValue("ProductName");
                tedProductName.Text = lueMixId.GetColumnValue("ProductName1").ToString();
                tedColorCode.Text = lueMixId.GetColumnValue("ColorName").ToString();
                tedColor.Text = lueMixId.GetColumnValue("ColorName1").ToString();
                txtMachineMix.Text = lueMixId.GetColumnValue("MachineName").ToString();
                cmbStep.SelectedValue = lueMixId.GetColumnValue("StepName");
            }            
        }

        private void LoadLookUpProduct()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(2);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getProductsWinline", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                lueProduct.Properties.DataSource = ds.Tables[0];
                lueProduct.Properties.DisplayMember = "ProductName";
                lueProduct.Properties.ValueMember = "ProductCode";
                lueProduct.Properties.KeyMember = "ProductCode";

                lueProduct.Properties.Columns.Add(new LookUpColumnInfo("ProductCode", "ProductCode", 60));
                lueProduct.Properties.Columns.Add(new LookUpColumnInfo("ProductName", "ProductName", 120));
                //enable text editing 
                lueProduct.Properties.TextEditStyle = TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void LoadLookUpColor()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(2);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getColorsProducts", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }


                //lueColor.Properties.DataSource = ds.Tables[0];
                //lueColor.Properties.DisplayMember = "ColorName";
                //lueColor.Properties.ValueMember = "ColorCode";

                //lueColor.Properties.Columns.Add(new LookUpColumnInfo("ColorCode", "ColorCode", 60));
                //lueColor.Properties.Columns.Add(new LookUpColumnInfo("ColorName", "ColorName", 120));
                ////lueColor.Properties.Columns.Add(new LookUpColumnInfo("ProductName", "ProductName", 120));

                ////enable text editing 
                //lueColor.Properties.TextEditStyle = TextEditStyles.Standard;
                //lueColor.CascadingOwner = lueProduct;
                //lueColor.Properties.CascadingMember = "ProductCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void lueMaterial_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbColor.SelectedValue != null)
            {
                generateTextQRCode();
            }
            else
            {
                qrCodeCrush.Text = "framas.com";
            }
        }

        private void lueProduct_EditValueChanged(object sender, EventArgs e)
        {            
            if (lueProduct.EditValue.IsNull())
            {
                return;
            }
            else
            {
                tedProductName.Text = lueProduct.Text;
                loadColorsByProduct(lueProduct.EditValue.ToString());                
                generateTextQRCode();
            }
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
            LoadGridControl1();
        }

        //Action for Export to Excel
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ExportExcel("");
            //frmDateRange frmDate = new frmDateRange();
            //frmDate.ExportName = 2;
            //frmDate.Show();
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
                    gridView1.OptionsPrint.ShowPrintExportProgress = true;
                    gridView1.OptionsPrint.AllowCancelPrintExport = true;
                    gridView1.OptionsPrint.AutoWidth = true;

                    //Hien cac cot trong grid
                    gridView1.Columns["CrushRawId"].VisibleIndex = 0;
                    gridView1.Columns["CreateTime"].VisibleIndex = 1;
                    gridView1.Columns["RecycledID"].VisibleIndex = 2;
                    gridView1.Columns["MixBacode"].VisibleIndex = 3;
                    gridView1.Columns["ShiftName"].VisibleIndex = 4;
                    gridView1.Columns["OperatorName"].VisibleIndex = 5;
                    gridView1.Columns["ProductCode"].VisibleIndex = 6;
                    gridView1.Columns["ProductName"].VisibleIndex = 7;
                    gridView1.Columns["ColorCode"].VisibleIndex = 8;
                    gridView1.Columns["ColorName"].VisibleIndex = 9;
                    gridView1.Columns["StepName"].VisibleIndex = 10;
                    gridView1.Columns["LossTypeName"].VisibleIndex = 11;
                    gridView1.Columns["WeightRecycle"].VisibleIndex = 12;
                    gridView1.Columns["MachineName"].VisibleIndex = 13;

                    XlsxExportOptions options = new XlsxExportOptions();
                    options.TextExportMode = TextExportMode.Value;
                    options.ExportMode = XlsxExportMode.SingleFilePageByPage;
                    options.SheetName = "Incoming Crush";

                    ExportSettings.DefaultExportType = ExportType.Default;
                    gridView1.ExportToXlsx(dialog.FileName, options);

                    //An cac cot trong grid
                    gridView1.Columns["ProductCode"].VisibleIndex = -1;
                    gridView1.Columns["ColorName"].VisibleIndex = -1;

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

        private void LoadGridControl1()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                SqlDataAdapter SqlDaCrush = new SqlDataAdapter("sp_getFullCrushRaws", conn);
                SqlDaCrush.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaCrush.Fill(ds, "CrushRaw");                

                gridControl1.DataSource = ds.Tables["CrushRaw"];
                gridControl1.ForceInitialize();

                foreach (GridColumn column in gridView1.Columns)
                {
                    GridSummaryItem item = column.SummaryItem;
                    if (item != null)
                        column.Summary.Remove(item);
                }

                gridView1.OptionsView.ColumnAutoWidth = true;

                gridView1.Columns["OperatorCode"].VisibleIndex = -1;
                gridView1.Columns["ProductCode"].VisibleIndex = -1;                
                gridView1.Columns["CreateBy"].VisibleIndex = -1;
                gridView1.Columns["MixRawId"].VisibleIndex = -1;
                gridView1.Columns["LossTypeId"].VisibleIndex = -1;
                gridView1.Columns["ColorName"].VisibleIndex = -1;
                gridView1.Columns["Posted"].VisibleIndex = -1;


                gridView1.Columns["CrushRawId"].VisibleIndex = 0;
                gridView1.Columns["CreateTime"].VisibleIndex = 1;                
                gridView1.Columns["RecycledID"].VisibleIndex = 2;
                gridView1.Columns["MixBacode"].VisibleIndex = 3;
                gridView1.Columns["ShiftName"].VisibleIndex = 4;
                gridView1.Columns["OperatorName"].VisibleIndex = 5;                
                gridView1.Columns["ProductName"].VisibleIndex = 7;
                gridView1.Columns["ColorCode"].VisibleIndex = 8;
                gridView1.Columns["StepName"].VisibleIndex = 10;
                gridView1.Columns["LossTypeName"].VisibleIndex = 11;
                gridView1.Columns["WeightRecycle"].VisibleIndex = 12;
                gridView1.Columns["MachineName"].VisibleIndex = 13;
                
                gridView1.Columns["CrushRawId"].Width = 60;
                gridView1.Columns["CreateTime"].Width = 130;
                gridView1.Columns["RecycledID"].Width = 280;
                gridView1.Columns["MixBacode"].Width = 280;
                gridView1.Columns["ShiftName"].Width = 60;
                gridView1.Columns["ProductName"].Width = 320;
                gridView1.Columns["ColorCode"].Width = 80;
                gridView1.Columns["StepName"].Width = 70;
                gridView1.Columns["MachineName"].Width = 100;

                GridColumnSummaryItem totalWeightRecycled = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WeightRecycle", "{0:n3}");
                gridView1.Columns["WeightRecycle"].Summary.Add(totalWeightRecycled);

                gridView1.Columns["CreateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["CreateTime"].DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";

                gridView1.Columns["WeightRecycle"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["WeightRecycle"].DisplayFormat.FormatString = "{0:n3}";
                gridView1.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView gridView = sender as GridView;
            cmbShift.SelectedItem = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ShiftName"]);
            //cmbLostType.SelectedItem = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["LossTypeName"]);
            lueReType.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["LossTypeName"]).ToString();
            cmbOperator.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["OperatorCode"]);
            txtMachine.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MachineName"]).ToString();
            cmbStep.SelectedValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["StepName"]);
            lueProduct.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ProductCode"]);
            tedColorCode.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ColorCode"]).ToString();
            lueMixId.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]);
            lueMaterial.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MaterialCode"]);
            txtWeightRe.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["WeightRecycle"]).ToString();
            qrCodeCrush.Text= gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["RecycledID"]).ToString();
            //txtCrushDate.Text = String.Format("{0:MM/dd/yyyy HH:mm:ss}", gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CreateTime"]));
            txtCrushID.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CrushRawId"]).ToString();
            txtPosted.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Posted"]).ToString();

            txtWeightRe.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            txtWeightRe.Properties.DisplayFormat.FormatString = "{0:n3}";

            SetcmdPost();
        }

        private void txtWeightRe_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit editorWeightRe = (ButtonEdit)sender;
            EditorButton Button = e.Button;

            if (Button.Kind == ButtonPredefines.OK)
            {                
                if (!String.IsNullOrEmpty(txtScaleWeight.Text) && (txtScaleWeight.Text != "Off"))
                {
                    editorWeightRe.Text = (float.Parse(txtScaleWeight.Text) - 1.14).ToString();

                    editorWeightRe.ToolTipIconType = ToolTipIconType.Information;
                    editorWeightRe.ToolTip = txtScaleWeight.Text + "-1.14";
                }                

                txtWeightRe.Properties.DisplayFormat.FormatType = FormatType.Numeric;
                txtWeightRe.Properties.DisplayFormat.FormatString = "{0:n3}";
            }
            else if (Button.Kind == ButtonPredefines.Delete)
            {
                editorWeightRe.Text = "";
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
            //foreach (var portName in portNames)
            //{
            //    cboComPort.Items.Add(portName);                  //<-- Adds Ports to combobox
            //}
            //cboComPort.SelectedIndex = 0;                        //<-- Selects first entry (convenience purposes)

            //< --This block ensures that no exceptions happen
            if (_serialPort != null && _serialPort.IsOpen)
                _serialPort.Close();
            if (_serialPort != null)
                _serialPort.Dispose();
            //< --End of Block
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
                //_serialPort = new SerialPort(cboComPort.Text, BaudRate, Parity.None, 8, StopBits.One);  //<-- this event happens everytime when new data is received by the ComPort 
                _serialPort = new SerialPort(ScaleApp.Properties.Settings.Default.COMPort, BaudRate, Parity.None, 8, StopBits.One);
                _serialPort.DataReceived += SerialPortOnDataReceived;
                _serialPort.Open();     //<-- make the comport listen
                txtScaleWeight.Text = "Scaling... " + _serialPort.PortName + "...\r\n";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + " - Cân đang đóng!" + Environment.NewLine + "Vui lòng tắt form và mở lại để tiếp tục nhập !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseSerialPort();
            }         
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //GridView gridView = sender as GridView;
            //cmbShift.SelectedItem = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ShiftName"]);
            ////Dung cho combobox cu
            ////cmbLostType.SelectedItem = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["LossTypeName"]);
            ////lueReType.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["LossTypeName"]).ToString();
            //cmbOperator.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["OperatorCode"]);
            //txtMachine.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MachineName"]).ToString();
            //cmbStep.SelectedValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["StepName"]);
            //lueProduct.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ProductCode"]);
            //tedColorCode.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ColorCode"]).ToString();
            //lueMixId.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]);
            //lueMaterial.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MaterialCode"]);
            //txtWeightRe.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["WeightRecycle"]).ToString();
            //qrCodeCrush.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["RecycledID"]).ToString();
            ////txtCrushDate.Text = String.Format("{0:MM/dd/yyyy HH:mm:ss}", gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CreateTime"]));
            //txtCrushID.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CrushRawId"]).ToString();
            //txtPosted.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Posted"]).ToString();

            //txtWeightRe.Properties.Mask.UseMaskAsDisplayFormat = true;

            //SetcmdPost();
        }

        private void frmCrushing_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSerialPort();
        }
        
    }
}
