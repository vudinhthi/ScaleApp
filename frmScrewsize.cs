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
using DevExpress.XtraGrid.Views.Grid;
using ScaleApp.Common;
using DevExpress.XtraGrid.Columns;
using ScaleApp.Models;
using System.Diagnostics;

namespace ScaleApp
{
    public partial class frmScrewsize : DevExpress.XtraEditors.XtraForm
    {
      
        public  int componentID { get; set; }
        public  string ItemID { get; set; }
        DataSet ds = new DataSet();
        public frmScrewsize()
        {
            InitializeComponent();
           
        }
        private void frmScrewsize_Load(object sender, EventArgs e)
        {
            //Load data from Screwsize table
            gvScrewsize = gct_Screwsize.MainView as GridView;
            gvScrewsize.OptionsBehavior.Editable = true;
            gvScrewsize.OptionsSelection.MultiSelect = false;
            gvScrewsize.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            //gctComponent.DataSource = ds.Tables["tbComponent"];
            gct_Screwsize.ForceInitialize();
            gvScrewsize.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gvScrewsize.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplaceHideCurrentRow;
            ds = DataOperation.SelectSrewsize(2, "sp_GetScrewsize", ItemID,componentID, 2);
            gvScrewsize.OptionsBehavior.AutoPopulateColumns = false;
            gct_Screwsize.DataSource = null;
            gct_Screwsize.DataSource =ds.Tables["tbScrewsize"] ;
            gvScrewsize.EditFormPrepared += (s, o) =>
            {
                GridView view = s as GridView;
                GridColumn colscrewsizeID = view.Columns["screwsizeID"];
                GridColumn colValue= view.Columns["value"];
                //Lay max screwsizeID 
                //int rowcount = view.DataRowCount + 1;
                DataTable dt = ds.Tables["tbScrewsize"];
                //var nextindex =Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0]);
                int nextindex =   DataOperation.SelectLastIndex(2, "sp_GetLastScrewsizeID")+1;
                string screwsizeID = view.GetRowCellValue(o.RowHandle, colscrewsizeID).ToString();
                if (string.IsNullOrWhiteSpace(screwsizeID))
                {
                    if (nextindex == 0)
                    {
                        nextindex++;
                    }
                    view.SetRowCellValue(o.RowHandle, colscrewsizeID, nextindex);
                    var IdEdit = o.BindableControls[colscrewsizeID];
                    IdEdit.Text = nextindex.ToString();
                }
                o.FocusField(colValue); //focus field Name
            };
            gvScrewsize.EditFormHidden += (s, o) =>
            {
                if (o.Result == EditFormResult.Update)
                {
                    GridView view = s as GridView;
                    //DataTable tbComponent = ds.Tables["tbComponent"];
                    DataTable tbScrewsize = ds.Tables["tbScrewsize"];
                    //Neu la hang moi thi add vao database
                    if (!view.IsNewItemRow(o.RowHandle))
                    {
                        int result = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = {ItemID} and componentID = {componentID}  order by componentID asc");
                        if (result == -1)
                        {
                            MessageBox.Show("Cập nhật lỗi!");
                        }
                    }
                    else
                    {
                        int id = Convert.ToInt32(o.BindableControls["screwsizeID"].Text);
                        int value = Convert.ToInt32(o.BindableControls["value"].Text);
                        DataOperation.InsertScrewsize(2, "sp_createScrewsize", id, value, componentID, ItemID);
                    }
                    gct_Screwsize.RefreshDataSource();
                }
                
                // int result2 = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = 1 order by componentID asc");


                // gvComponent.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            };
        }
        private void frmScrewsize_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
                