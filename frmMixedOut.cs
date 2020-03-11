using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScaleApp
{
    public partial class frmMixedOut : Form
    {
        public frmMixedOut()
        {
            InitializeComponent();
        }        

        private void frmMixedOut_Load(object sender, EventArgs e)
        {
            txtWeight.Text = "0";
            rdbRunner.Checked = true;
            Start_Timer();

            LoadComboBoxMixId();
            //LoaddataGridView1();
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
                                _weightRunner = double.Parse(txtWeightSacle.Text.ToString());
                                break;
                            case "rdbDefect":
                                _weightDefect = double.Parse(txtWeightSacle.Text.ToString());
                                break;
                            case "rdbBlackDot":
                                _weightBlackDot = double.Parse(txtWeightSacle.Text.ToString());
                                break;
                            case "rdbContaminated":
                                _weightContaminated = double.Parse(txtWeightSacle.Text.ToString());
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

                        LoaddataGridView1();

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
                    cmd.Parameters.AddWithValue("@weightRunner", txtWeightSacle.Text);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbDefect":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", txtWeightSacle.Text);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbBlackDot":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", txtWeightSacle.Text);
                    cmd.Parameters.AddWithValue("@weightContaminated", 0);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
                case "rdbContaminated":
                    cmd.Parameters.AddWithValue("@weightRunner", 0);
                    cmd.Parameters.AddWithValue("@weightDefect", 0);
                    cmd.Parameters.AddWithValue("@weightBlackDot", 0);
                    cmd.Parameters.AddWithValue("@weightContaminated", txtWeightSacle.Text);
                    cmd.Parameters.AddWithValue("@weightRecycle", 0);
                    cmd.Parameters.AddWithValue("@weightCookie", 0);
                    break;
            }           
            cmd.Parameters.AddWithValue("@mixRawId", cmbMixId.SelectedValue);            

            conn.Open();

            int i = cmd.ExecuteNonQuery();
            LoaddataGridView1();

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

            LoaddataGridView1();

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

        private void LoaddataGridView1()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_getFullMixOuts", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                //Select only one row
                gridView1.MultiSelect = false;
                gridView1.AutoGenerateColumns = false;

                gridView1.DataSource = ds.Tables[0];
                //Change name of Columns
                gridView1.Columns["Id"].DataPropertyName = "Id";
                gridView1.Columns["WeightDate"].DataPropertyName = "CreateTime";
                gridView1.Columns["MixId"].DataPropertyName = "MixBacode";
                gridView1.Columns["WeightRunner"].DataPropertyName = "WeightRunner";
                gridView1.Columns["WeightDefect"].DataPropertyName = "WeightDefect";
                gridView1.Columns["WeightBlackDot"].DataPropertyName = "WeightBlackDot";
                gridView1.Columns["WeighContamination"].DataPropertyName = "WeighContamination";
                gridView1.Columns["WeightRecycle"].DataPropertyName = "WeightRecycle";
                gridView1.Columns["WeightCookie"].DataPropertyName = "WeightCookie";                
                gridView1.Columns["Posted"].DataPropertyName = "Posted";

                //gridView1.Columns["MixId"].Width = 50;
                //gridView1.Columns["WeightDate"].Width = 80;
                //gridView1.Columns["MixId"].Width = 120;
                //gridView1.Columns["WeightRunner"].Width = 60;
                //gridView1.Columns["WeightDefect"].Width = 60;
                //gridView1.Columns["WeightBlackDot"].Width = 60;
                //gridView1.Columns["WeightContaminated"].Width = 60;
                //gridView1.Columns["WeightRecycle"].Width = 60;
                //gridView1.Columns["WeightCookie"].Width = 60;
                //gridView1.Columns["Posted"].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();
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
                LoaddataGridView1();
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
    }
}
