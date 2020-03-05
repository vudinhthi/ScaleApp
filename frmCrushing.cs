using ScaleApp.Common;
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
    public partial class frmCrushing : Form
    {
        private Control _focusedControl;

        public frmCrushing()
        {
            InitializeComponent();
        }

        private void frmCrushing_Load(object sender, EventArgs e)
        {
            Start_Timer();
            loadComboBoxOperator();
            loadComboBoxStep();
            loadComboBoxProduct();
            loadComboBoxColor();
            loadComboBoxMaterial();
            loadComboBoxMixId();
            loadGridCrush();            
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

                DataRow blankRow = ds.Tables[0].NewRow();
                blankRow["ColorCode"] = "None";
                blankRow["ColorName"] = "";
                ds.Tables[0].Rows.InsertAt(blankRow, 0);

                cmbColor.DataSource = ds.Tables[0];
                cmbColor.DisplayMember = "ColorCode";
                cmbColor.ValueMember = "ColorCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();

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
            String ItemCode = cmbProduct.SelectedValue.ToString();
            String ColorCode = cmbColor.SelectedValue.ToString();

            getLastCrushRawId();
            qrCodeText = ScaleApp.Common.mFunction.GenerateTextQRCode("RE", DateTime.Today) + "." + cmbProduct.SelectedValue.ToString() + "." + cmbColor.SelectedValue.ToString() + "." + getLastCrushRawId().ToString();            
            qrCodeCrush.Text = qrCodeText;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem.IsNull())
            {
                loadComboBoxColor();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            double weightCrush;
            if (String.IsNullOrEmpty(txtWeightCrushed.Text))
            {
                weightCrush = 0;
            }
            else
            {
                weightCrush = double.Parse(txtWeightCrushed.Text.ToString());
            }

            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_createCrushRaw", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@shiftID", cmbShift.SelectedItem);
            cmd.Parameters.AddWithValue("@operatorCode", cmbOperator.SelectedValue);
            cmd.Parameters.AddWithValue("@productCode", cmbProduct.SelectedValue);
            cmd.Parameters.AddWithValue("@materialCode", cmbMaterial.SelectedValue);
            cmd.Parameters.AddWithValue("@colorCode", cmbColor.SelectedValue);
            cmd.Parameters.AddWithValue("@stepId", cmbStep.SelectedValue);
            cmd.Parameters.AddWithValue("@weightRecycle", weightCrush);
            cmd.Parameters.AddWithValue("@lostType", cmbLostType.SelectedItem);
            cmd.Parameters.AddWithValue("@mixRawId", int.Parse(cmbMixId.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@machineID", txtMachine.Text);            
            cmd.Parameters.AddWithValue("@qrCode", qrCodeCrush.Text);

            conn.Open();

            int i = cmd.ExecuteNonQuery();

            ScaleApp.Common.DataOperation.disconnect();

            loadGridCrush();

            if (i != 0)
            {
                MessageBox.Show(i + " Crushed Lot saved!");
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
                loadCrushRaw(int.Parse(txtCrushID.Text.ToString()));
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
                cmbProduct.SelectedValue = ds.Tables[0].Rows[0][4]; //Get Item
                cmbMaterial.SelectedValue = ds.Tables[0].Rows[0][6]; //Get Material
                cmbColor.SelectedValue = ds.Tables[0].Rows[0][8]; //Get Color
                cmbStep.SelectedValue = ds.Tables[0].Rows[0][10]; //Get Step
                cmbMixId.SelectedValue = ds.Tables[0].Rows[0][13]; //Get Crush Lot ID

                txtWeightCrushed.Text = ds.Tables[0].Rows[0][11].ToString(); //Get Weight Recycled
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
            cmbProduct.SelectedValue = "None";
            cmbColor.SelectedValue = "None";
            cmbMaterial.SelectedValue = "None";
            cmbMixId.SelectedValue = 0;
            txtWeightCrushed.Text = null;
            txtCrushDate.Text = null;
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
            
            lastCrushRawId = (int)sqlcmd.Parameters["@LastIdentity"].Value;
            return lastCrushRawId;
            
            ScaleApp.Common.DataOperation.disconnect();
            
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateTextQRCode();
        }

        private void cmdGetWeight_Click(object sender, EventArgs e)
        {
            getLastCrushRawId();
        }
    }
}
