using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleApp
{
    public partial class frmCrushing : Form
    {
        private Control _focusedControl;
        private SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        private const int BaudRate = 9600;      //<-- BaudRate Constant. 9600 seems to be the scale-units default value

        public frmCrushing()
        {
            InitializeComponent();
        }

        private void frmCrushing_Load(object sender, EventArgs e)
        {
            Start_Timer();
            GetComPort();
            loadComboBoxOperator();
            loadComboBoxStep();
            //loadComboBoxProduct();
            //loadComboBoxMaterial();
            LoadLookUpMaterial();
            LoadLookUpProduct();
            LoadLookUpColor();
            //loadComboBoxMixId();
            LoadLookUpMixId();
            cmdPost.Enabled = false;
            //loadGridCrush();
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
           txtNow.Text = DateTime.Now.ToString();
        }

        private void loadComboBoxOperator()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getOperators", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }
                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["OperatorCode"] = "None";
                blankRow["OperatorName"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow,0);

                cmbOperator.DataSource = ds.Tables[0];
                cmbOperator.DisplayMember = "OperatorName";
                cmbOperator.ValueMember = "OperatorCode";
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
            if (txtCrushID.Text.IsNullOrEmpty())
            {
                if (CheckValidForm() == 0)
                {
                    MessageBox.Show("Do you miss Item?");
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_createCrushRaw", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@shiftID", cmbShift.SelectedItem);
            cmd.Parameters.AddWithValue("@operatorCode", cmbOperator.SelectedValue);
            cmd.Parameters.AddWithValue("@productCode", lueProduct.EditValue);
            cmd.Parameters.AddWithValue("@materialCode", lueMaterial.EditValue);
            cmd.Parameters.AddWithValue("@colorCode", tedColorCode.Text);
            cmd.Parameters.AddWithValue("@stepId", cmbStep.SelectedValue);
            cmd.Parameters.AddWithValue("@weightRecycle", txtWeightRe.Text);
            cmd.Parameters.AddWithValue("@lostType", cmbLostType.SelectedItem);
            cmd.Parameters.AddWithValue("@mixRawId", lueMixId.EditValue);
            cmd.Parameters.AddWithValue("@machineID", txtMachine.Text);
            cmd.Parameters.AddWithValue("@qrCode", qrCodeCrush.Text);

            conn.Open();

            int i = cmd.ExecuteNonQuery();

            ScaleApp.Common.DataOperation.disconnect();            

            if (i != 0)
            {
                MessageBox.Show(i + " Crushed Lot saved!");
                //loadGridCrush();
                LoadGridControl1();
            }
        }

        private void UpdateCrushRaw()
        {
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_editCrushRaw", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@shiftID", cmbShift.SelectedItem);
            cmd.Parameters.AddWithValue("@operatorCode", cmbOperator.SelectedValue);
            cmd.Parameters.AddWithValue("@productCode", lueProduct.EditValue);
            cmd.Parameters.AddWithValue("@materialCode", lueMaterial.EditValue);
            cmd.Parameters.AddWithValue("@colorCode", tedColorCode.Text);
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
                MessageBox.Show(i + "Data Saved");
                //loadGridCrush();
                LoadGridControl1();
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
                cmbOperator.SelectedValue = ds.Tables[0].Rows[0][2]; //Get Operator
                lueProduct.EditValue = ds.Tables[0].Rows[0][4]; //Get Item
                lueMaterial.EditValue = ds.Tables[0].Rows[0][6]; //Get Material
                tedColor.Text = ds.Tables[0].Rows[0][8].ToString(); //Get Color
                cmbStep.SelectedValue = ds.Tables[0].Rows[0][10]; //Get Step
                lueMixId.EditValue = ds.Tables[0].Rows[0][13]; //Get Crush Lot ID

                txtWeightRe.Text = ds.Tables[0].Rows[0][11].ToString(); //Get Weight Recycled
                txtMachine.Text = ds.Tables[0].Rows[0][15].ToString(); //Get Machine
                
                qrCodeCrush.Text = ds.Tables[0].Rows[0][18].ToString(); //Get Crush Lot ID
                
                txtCrushDate.Text = ds.Tables[0].Rows[0][17].ToString(); //Get Crush Lot Date
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
            cmbLostType.SelectedItem = null;
            cmbOperator.SelectedValue = "None";
            txtMachine.Text = null;
            cmbStep.SelectedValue = "None";
            //cmbProduct.SelectedValue = "None";
            //cmbColor.SelectedValue = "None";
            lueProduct.EditValue = null;
            tedColorCode.Text = null;
            tedColor.Text = null;
            //cmbMaterial.SelectedValue = "None";
            lueMaterial.EditValue = null;
            lueMixId.EditValue = null;
            //cmbMixId.SelectedValue = 0;
            //txtWeightCrushed.Text = null;
            txtWeightRe.Text = null;
            txtCrushDate.Text = null;
            txtCrushID.Text = null;
            txtPosted.Text = "0";
        }

        private int getLastCrushRawId()
        {
            int lastCrushRawId;

            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sqlcmd = new SqlCommand("sp_getLastIdentity", conn);
            
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter returnParameter = new SqlParameter("@LastIdentity", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            sqlcmd.Parameters.Add(returnParameter);
            conn.Open();
            sqlcmd.ExecuteNonQuery();
            
            lastCrushRawId = (int)sqlcmd.Parameters["@LastIdentity"].Value + 1;
            return lastCrushRawId;
            
            ScaleApp.Common.DataOperation.disconnect();
            
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
                cmdPost.Enabled = true;
                cmdSave.Enabled = true;
            }
            else
            {
                cmdPost.Enabled = false;
                cmdSave.Enabled = false;
            }
        }

        private void UpdatePosted()
        {
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_setCrushPosted", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@crushRawId", txtCrushID.Text);

            conn.Open();

            int i = cmd.ExecuteNonQuery();

            ScaleApp.Common.DataOperation.disconnect();            

            if (i != 0)
            {
                MessageBox.Show("Data posted !");
                loadGridCrush();
                cmdSave.Enabled = false;
                cmdPost.Enabled = false;
            }
        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            UpdatePosted();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            frmReportCrush reportCrush = new frmReportCrush();

            if (txtCrushID.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Select a Mix Lot Id to print !");
            }
            else
            {
                reportCrush.MixID = int.Parse(txtCrushID.Text.ToString());
                reportCrush.Show();
            }
            
        }

        private void LoadLookUpMaterial()
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

        private void LoadLookUpMixId()
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

                lueMixId.Properties.DataSource = ds.Tables[0];
                lueMixId.Properties.DisplayMember = "MixBacode";
                lueMixId.Properties.ValueMember = "MixRawId";

                lueMixId.Properties.Columns.Add(new LookUpColumnInfo("MixRawId", "MixRawId", 60));
                lueMixId.Properties.Columns.Add(new LookUpColumnInfo("MixBacode", "MixBacode", 120));

                lueMixId.Properties.TextEditStyle= TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void LoadLookUpProduct()
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
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
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
                loadColorsByProduct(lueProduct.EditValue.ToString());                
                generateTextQRCode();
            }
        }        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //loadGridCrush();
            LoadGridControl1();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "D:\\ExportExcel\\Crush.xlsx";

            XlsxExportOptionsEx xlsxExport = new XlsxExportOptionsEx();
            xlsxExport.ExportType = DevExpress.Export.ExportType.DataAware;

            gridControl1.ExportToXlsx(path);
            // Open the created XLSX file with the default application. 
            Process.Start(path);
        }

        private void LoadGridControl1()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                SqlDataAdapter SqlDaCrush = new SqlDataAdapter("sp_getFullCrushRaws", conn);
                SqlDaCrush.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaCrush.Fill(ds, "CrushRaw");

                gridControl1.DataSource = ds.Tables["CrushRaw"];
                gridControl1.ForceInitialize();

                gridView1.OptionsView.ColumnAutoWidth = false;

                gridView1.Columns["OperatorCode"].VisibleIndex = -1;
                gridView1.Columns["ProductCode"].VisibleIndex = -1;                
                gridView1.Columns["CreateBy"].VisibleIndex = -1;
                gridView1.Columns["MixRawId"].VisibleIndex = -1;

                gridView1.Columns["CrushRawId"].VisibleIndex = 0;
                gridView1.Columns["CreateTime"].VisibleIndex = 1;                
                gridView1.Columns["RecycledID"].VisibleIndex = 2;
                gridView1.Columns["MixBacode"].VisibleIndex = 3;
                gridView1.Columns["ShiftName"].VisibleIndex = 4;
                gridView1.Columns["OperatorName"].VisibleIndex = 5;
                //gridView1.Columns["ProductName"].VisibleIndex = 6;                
                gridView1.Columns["ColorCode"].VisibleIndex = 8;
                //gridView1.Columns["ColorName"].VisibleIndex = 9;
                gridView1.Columns["StepName"].VisibleIndex = 10;
                gridView1.Columns["LossTypeName"].VisibleIndex = 11;
                gridView1.Columns["WeightRecycle"].VisibleIndex = 12;
                gridView1.Columns["MachineName"].VisibleIndex = 13;                                
                gridView1.Columns["Posted"].VisibleIndex = 14;

                gridView1.Columns["CrushRawId"].Width = 40;
                gridView1.Columns["StepName"].Width = 60;
                gridView1.Columns["OperatorName"].Width = 100;
                //gridView1.Columns["ProductName"].Width = 180;                
                gridView1.Columns["ColorCode"].Width = 80;
                //gridView1.Columns["ColorName"].Width = 170;
                gridView1.Columns["WeightRecycle"].Width = 80;
                gridView1.Columns["LossTypeName"].Width = 60;
                gridView1.Columns["MixBacode"].Width = 150;
                gridView1.Columns["MachineName"].Width = 80;
                gridView1.Columns["RecycledID"].Width = 150;
                gridView1.Columns["MixBacode"].Width = 150;
                gridView1.Columns["Posted"].Width = 40;

                gridView1.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView gridView = sender as GridView;
            cmbShift.SelectedItem = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ShiftName"]);
            cmbLostType.SelectedItem = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["LossTypeName"]);
            cmbOperator.SelectedValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["OperatorCode"]);
            txtMachine.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MachineName"]).ToString();
            cmbStep.SelectedValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["StepName"]);
            lueProduct.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ProductCode"]);
            tedColorCode.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["ColorCode"]).ToString();
            lueMixId.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MixRawId"]);
            lueMaterial.EditValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["MaterialCode"]);
            txtWeightRe.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["WeightRecycle"]).ToString();
            qrCodeCrush.Text= gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["RecycledID"]).ToString();
            txtCrushDate.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CreateTime"]).ToString();
            txtCrushID.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CrushRawId"]).ToString();
            txtPosted.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["Posted"]).ToString();

            SetcmdPost();
        }

        private void txtWeightRe_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit editorWeightRe = (ButtonEdit)sender;
            EditorButton Button = e.Button;

            if (Button.Kind == ButtonPredefines.OK)            {
                
                editorWeightRe.Text = txtScaleWeight.Text;
            }
            else if (Button.Kind == ButtonPredefines.Delete)
            {
                editorWeightRe.Text = "";
            }
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
    }
}
