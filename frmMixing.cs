using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScaleApp.Common;

namespace ScaleApp
{
    public partial class frmMixing : Form
    {
        public frmMixing()
        {
            InitializeComponent();            
        }

        private void frmMixing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'colorMixDataSet.ProductColor' table. You can move, or remove it, as needed.
            this.productColorTableAdapter.Fill(this.colorMixDataSet.ProductColor);
            // TODO: This line of code loads data into the 'colorMixDataSet.Recycle' table. You can move, or remove it, as needed.
            this.recycleTableAdapter.Fill(this.colorMixDataSet.Recycle);
            // TODO: This line of code loads data into the 'colorMixDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.colorMixDataSet.Materials);
            // TODO: This line of code loads data into the 'colorMixDataSet.Color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.colorMixDataSet.Color);
            // TODO: This line of code loads data into the 'colorMixDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.colorMixDataSet.Product);
            // TODO: This line of code loads data into the 'colorMixDataSet.MixRaw' table. You can move, or remove it, as needed.
            this.mixRawTableAdapter.Fill(this.colorMixDataSet.MixRaw);
            // TODO: This line of code loads data into the 'colorMixDataSet.Step' table. You can move, or remove it, as needed.
            this.stepTableAdapter.Fill(this.colorMixDataSet.Step);
            // TODO: This line of code loads data into the 'colorMixDataSet.Operator' table. You can move, or remove it, as needed.
            this.operatorTableAdapter.Fill(this.colorMixDataSet.Operator);
            

            txtWeightRM.Text = "0";
            txtWeightRecycled.Text = "0";
            txtTotal.Text = "0";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ScaleApp.Properties.Settings.ColorMixConnectionString"].ConnectionString;
            if (cmbProduct.SelectedItem.IsNull())
            {
                txtScaleWeight.Text = "";
            }
            else
            {
                DataTable dt = new DataTable();
                using (SqlConnection Cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand("SELECT * FROM  ProductColor  where ProductCode = @oid", Cn))
                    {
                        Cn.Open();
                        Cmd.Parameters.AddWithValue("@oid", cmbProduct.SelectedValue.ToString());
                        SqlDataAdapter adpt = new SqlDataAdapter(Cmd);
                        adpt.Fill(dt);
                        
                        cmbColor.DataSource = dt;
                        cmbColor.DisplayMember = "ColorCode";
                        cmbColor.ValueMember = "ColorCode";
                    }

                }
                
            }

        }

        private void btnSendToMaterial_Click(object sender, EventArgs e)
        {
            txtWeightRM.Text = txtScaleWeight.Text;
        }

        private void btnSendToRecycled_Click(object sender, EventArgs e)
        {
            txtWeightRecycled.Text = txtScaleWeight.Text;
        }
    }
}
