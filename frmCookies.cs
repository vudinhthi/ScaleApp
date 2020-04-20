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

namespace ScaleApp
{
    public partial class frmCookies : DevExpress.XtraEditors.XtraForm
    {
       
        DataSet ds = new DataSet();

        public frmCookies()
        {
            InitializeComponent();
        }

        private void frmCookies_Load(object sender, EventArgs e)
        {
            lkeItem.EditValue = "1";
            lkeItem.Text = "1";
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
        }

      

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPurgingCookies_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            ds = DataOperation.SelectComponent(2, "sp_GetComponent", lkeItem.EditValue.ToString());
            ds = DataOperation.SelectSrewsize(2, "sp_GetScrewsize", lkeItem.EditValue.ToString(), 0, 1);
           //DataView dvScrewsize, dvComponent;
           // DataViewManager dvm = new DataViewManager(ds);
          //  dvComponent = dvm.CreateDataView(ds.Tables["tbComponent"]);
          //  dvScrewsize = dvm.CreateDataView(ds.Tables["tbScrewsize"]);
            //if (dvComponent != null)
            //{
              
                lkeComponent.Properties.DataSource = ds.Tables["tbComponent"];
                lkeComponent.Properties.ValueMember = "componentID";
                lkeComponent.Properties.DisplayMember = "name";
                lkeComponent.EditValue = ds.Tables["tbComponent"].Rows[0][0];
                lkeComponent.Properties.PopulateColumns();
                lkeComponent.Properties.Columns["ItemID"].Visible = false;
                lkeComponent.Properties.Columns["componentID"].Caption = "ComponentID";
                lkeComponent.Properties.Columns["name"].Caption = "Name";
            //}
            //..
            //if (dvScrewsize != null)
            //{
                lkeScrewsize.Properties.DataSource = ds.Tables["tbScrewsize"];
                lkeScrewsize.Properties.ValueMember = "screwsizeID";
                lkeScrewsize.Properties.DisplayMember = "value";
                lkeScrewsize.EditValue = ds.Tables["tbScrewsize"].Rows[0][0];
                lkeScrewsize.Properties.PopulateColumns();
                lkeScrewsize.Properties.Columns["ItemID"].Visible = false;
                lkeScrewsize.Properties.Columns["componentID"].Visible = false;
                lkeScrewsize.Properties.Columns["screwsizeID"].Caption = "ScrewsizeID";
                lkeScrewsize.Properties.Columns["value"].Caption = "Value";
            
         //   lkeScrewsize.Properties.Columns["screwsizeID"].

            //}

        }
    }
}