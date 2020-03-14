﻿using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.Configuration;
using DevExpress.XtraReports.UI;
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
    public partial class frmReportCrush : Form
    {
        private int mixID;

        public int MixID
        {
            get { return this.mixID; }
            set { this.mixID = value; }
        }

        public frmReportCrush()
        {
            InitializeComponent();
        }

        private void LoadDataToReport()
        {
            DataSet ds = new DataSet();
            String connStr = ScaleApp.Common.DataOperation.GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter SqlDa = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand("sp_getFullCrushRaw", conn);

            try
            {
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@crushRawId", MixID);
                SqlDa.SelectCommand = sqlcmd;
                SqlDa.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScaleApp.Common.DataOperation.disconnect();

            var rptRe = new rptCrushed();
            rptRe.DataSource = ds;
            rptRe.CreateDocument();
            documentViewer1.DocumentSource = rptRe;           

            //rpt.FindControl("lblColorCode", false).Text = ds.Tables[0].Rows[0][8].ToString();                       
        }

        private void frmReportCrush_Load(object sender, EventArgs e)
        {
            LoadDataToReport();
        }
    }
}