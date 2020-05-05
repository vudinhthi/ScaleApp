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
using ScaleApp.Common;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace ScaleApp
{
    public partial class frmReason : DevExpress.XtraEditors.XtraForm
    {
        DataSet ds = new DataSet();
        
        public frmReason()
        {
            InitializeComponent();
        }

        private void frmReason_Load(object sender, EventArgs e)
        {
            ds = DataOperation.SelectReason(2, "sp_GetReason");
            gvReason.OptionsBehavior.AutoPopulateColumns = false;
            
            if (ds.Tables["tbScrewsize"] != null)
            {
                ds.Tables["tbScrewsize"].Clear();
            }
            gctReason.DataSource = ds.Tables["tbReason"];
            gvReason.PopulateColumns();
            gvReason.Columns["ItemID"].Visible = false;
            gvReason.Columns["ReasonID"].Width = 50;
            gvReason.Columns["ReasonID"].OptionsColumn.ReadOnly = true;
            gvReason.EditFormPrepared += (s, o) =>
            {
                GridView view = s as GridView;
                GridColumn colReasonID = view.Columns["ReasonID"];
                GridColumn colCause = view.Columns["Cause"];
                //Lay max screwsizeID 
                //int rowcount = view.DataRowCount + 1;
                DataTable dt = ds.Tables["tbReason"];
                //var nextindex =Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0]);
                if (view.IsNewItemRow(o.RowHandle))
                {
                    int nextindex = DataOperation.SelectLastIndex(2, "sp_GetLastIndexReason") + 1;
                    if (nextindex == 0)
                    {
                        nextindex = 1;
                    }
                    var IdEdit = o.BindableControls[colReasonID];
                    IdEdit.Text = nextindex.ToString();
                    view.SetRowCellValue(o.RowHandle, colReasonID, nextindex);
                }
              
                o.FocusField(colCause); //focus field Name
            };
            gvReason.EditFormHidden += (s, o) =>
            {
                GridView view = s as GridView;
                GridColumn colReasonID = view.Columns["ReasonID"];
                GridColumn colCause = view.Columns["Cause"];
                if (o.Result == EditFormResult.Update)
                {
                   
                    //DataTable tbComponent = ds.Tables["tbComponent"];
                    DataTable tbReason = ds.Tables["tbReason"];
                    //Neu la hang moi thi add vao database
                    if (!view.IsNewItemRow(o.RowHandle))
                    {
                        int result = DataOperation.UpdateTable(2, ref tbReason, $"Select * from Reason order by ReasonID asc");
                        if (result == -1)
                        {
                            MessageBox.Show("Cập nhật lỗi!");
                        }
                    }
                    else
                    {
                    int id =Convert.ToInt32((o.BindableControls[colReasonID] as TextEdit).EditValue);
                        // int id = view.RowCount+1;
                        string value = o.BindableControls["Cause"].Text;
                     DataOperation.InsertReason(2, "sp_createReason", id, value);
                   
                    }
                    gctReason.RefreshDataSource();
                }
                else
                {
                    if (view.IsNewItemRow(o.RowHandle))
                    {
                        view.SetRowCellValue(o.RowHandle, colReasonID, view.RowCount);
                    }
                   
                }

                // int result2 = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = 1 order by componentID asc");


                // gvComponent.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds = DataOperation.SelectReason(2, "sp_GetReason");
            gctReason.DataSource = ds.Tables["tbReason"];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ds = null;
            gctReason.DataSource = null;
           // gctReason.RefreshDataSource();
        }
    }
}