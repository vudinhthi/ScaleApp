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

        private void ComboBoxMixId()
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

                cmbMixId.DataSource = ds.Tables[0];
                cmbMixId.DisplayMember = "MixRawId";
                cmbMixId.ValueMember = "MixRawId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
        }

        private string getTotalWeight()
        {
            Double weightRM = 0;
            Double weightRe = 0;
            Double weightTotal = 0;

            if (String.IsNullOrEmpty(txtWeightRM.Text))
            {
                weightRM = 0;
            }
            else
            {
                weightRM = double.Parse(txtWeightRM.Text);
            }

            if (String.IsNullOrEmpty(txtWeightCrushed.Text))
            {
                weightRe = 0;
            }
            else
            {
                weightRe = double.Parse(txtWeightCrushed.Text);
            }
            weightTotal = weightRM + weightRe;
            return weightTotal.ToString();
        }

        private void txtWeightRM_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = getTotalWeight();
        }

        private void txtWeightCrushed_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = getTotalWeight();
        }

        private string generateTextQRCode()
        {
            String qrCodeText = "";
            qrCodeText = ScaleApp.Common.mFunction.GenerateTextQRCode("RE", DateTime.Today);
            return qrCodeText;
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
            qrCodeCrush.Text = generateTextQRCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_focusedControl != null)
            {
                //Change the color of the previously-focused textbox
                _focusedControl.BackColor = Color.Red;
            }

        }

        private void txtWeightRM_LostFocus(object sender, EventArgs e)
        {
            _focusedControl = (Control)sender;            
        }
    }
}
