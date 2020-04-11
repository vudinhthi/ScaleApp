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
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Menu;

namespace ScaleApp
{
    public partial class frmComponent : DevExpress.XtraEditors.XtraForm
    {
        GridView gvComponent;
        DataSet ds = new DataSet();
        //   GridView gridviewScrewsize;
        public frmComponent()
        {
            InitializeComponent();
        }
        private void frmComponent_Load(object sender, EventArgs e)
        {
            gvComponent = gctComponent.MainView as GridView;
            gvComponent.OptionsBehavior.Editable = true;
            gvComponent.OptionsSelection.MultiSelect = false;
            gvComponent.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gctComponent.ForceInitialize();
            gvComponent.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gvComponent.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplaceHideCurrentRow;
            //gvComponent.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            //gvComponent.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            bool isLoading = true;
            GridControlLoad(isLoading);
            // TextEdit edit = null;
            gvComponent.PopupMenuShowing += (s, o) =>
            {
                // Add a custom item to the column header menu
                if (o.Menu != null)
                {
                    GridView view = s as GridView;
                  //  view.Appearance.FocusedRow.BackColor = Color.Cyan;
                    //DXMenuItem DeleteMenu = new DXMenuItem("Delete");
                    //DeleteMenu.ImageOptions.Image = ScaleApp.Properties.Resources.delete_32x321;
                    //DeleteItemClick = (se, ea) =>
                    //{
                    //    DeleteMenu.Click -= DeleteItemClick;
                    //    if (XtraMessageBox.Show("Do you wish to remove this row?", "Confirmation Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //    {
                    //        gvComponent.DeleteRow(gvComponent.FocusedRowHandle);
                    //    }
                    //    //XtraMessageBox.Show("CustomItem is clicked");
                    //};
                    EventHandler AddItemClick = null;
                    DXMenuItem AddMenu = new DXMenuItem("Add Screw size");
                    AddMenu.ImageOptions.Image = ScaleApp.Properties.Resources.add_32x32;
                    AddMenu.Click += AddItemClick;
                    AddItemClick += (se, ea) =>
                    {
                        AddMenu.Click -= AddItemClick;
                        //Lay hang hien tai
                        int index = view.FocusedRowHandle;
                        //int componentID =Convert.ToInt32(view.GetRowCellValue(index,"componentID"));
                        //string ItemID = lkeItem.Text;
                        //Goi form Screwsize

                        frmScrewsize frmScrewsize = new frmScrewsize() {componentID =Convert.ToInt32(view.GetRowCellValue(index, "componentID")) , ItemID = lkeItem.Text };
                        DialogResult result=frmScrewsize.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            GridControlLoad(false);
                        }
                    };
                    AddMenu.Click += AddItemClick;
                    o.Menu.Items.Add(AddMenu);
                }
            };
            gvComponent.EditFormPrepared += (s, o) =>
            {
                GridView view = s as GridView;
                GridColumn colComponentID = view.Columns["componentID"];
                GridColumn colName = view.Columns["name"];
                int rowcount = view.DataRowCount +1;
                string componentID = view.GetRowCellValue(o.RowHandle, colComponentID).ToString();
                if (string.IsNullOrWhiteSpace(componentID))
                {
                    view.SetRowCellValue(o.RowHandle, colComponentID, rowcount);
                    var IdEdit = o.BindableControls[colComponentID];
                    IdEdit.Text = rowcount.ToString();
                }
                o.FocusField(colName); //focus field Name
            };
            #region EditFormShowing
            //gvComponent.EditFormShowing += (s, o) =>
            //{
            //    GridView view = s as GridView;

            //    view.RowUpdated += (sd, oj) =>
            //    {

            //        DataTable tbComponent = ds.Tables["tbComponent"];
            //        DataTable tbScrewsize = ds.Tables["tbScrewsize"];
            //        //Neu la hang moi thi add vao database
            //        if (!view.IsNewItemRow(oj.RowHandle))
            //        {
            //            int result1 = DataOperation.UpdateTable(2, ref tbComponent, $"SELECT * from Component where ItemID = 1 order by componentID asc");
            //        }
            //        else
            //        {

            //            var Ctr_NameEdit = oj.Row;
            //            int id = Convert.ToInt32(view.GetRowCellValue(o.RowHandle, "componentID"));
            //            string name = Ctr_NameEdit.

            //            string itemID = "1";
            //           DataOperation.InsertComponent(2, "sp_createComponent", id, name, itemID);
            //        }
            //        // int result2 = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = 1 order by componentID asc");
            //        //  Debug.WriteLine(ds.Tables["tbComponent"].Rows[oj.RowHandle]["name"].ToString());
            //    };
            //};
            #endregion
            gvComponent.EditFormHidden += (s, o) =>
          {
              if (o.Result ==EditFormResult.Update)
              {
                  GridView view = s as GridView;
                  DataTable tbComponent = ds.Tables["tbComponent"];
                  DataTable tbScrewsize = ds.Tables["tbScrewsize"];
                  //Neu la hang moi thi add vao database
                  if (!view.IsNewItemRow(o.RowHandle))
                  {
                      int result1 = DataOperation.UpdateTable(2, ref tbComponent, $"SELECT * from Component where ItemID = 1 order by componentID asc");
                  }
                  else
                  {
                      int id = Convert.ToInt32(o.BindableControls["componentID"].Text);
                      string name = o.BindableControls["name"].Text;
                      string itemID = lkeItem.Text;
                      DataOperation.InsertComponent(2, "sp_createComponent", id, name, itemID);
                  }
                  gctComponent.RefreshDataSource();
              }
              // int result2 = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = 1 order by componentID asc");


              // gvComponent.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
          };

            //Handle the InitNewRow event to initialize newly added rows. To initialize row cells use the SetRowCellValue method
            //gridview.InitNewRow += (s, ex) => {
            //    GridView view = s as GridView;
            //    view.SetRowCellValue(ex.RowHandle, view.Columns["id"],0);
            //    view.SetRowCellValue(ex.RowHandle, view.Columns["name"], "Name");
            //    view.SetRowCellValue(ex.RowHandle, view.Columns["ItemID"], "ItemID");
            //};

        }
        private void spbSave_Click(object sender, EventArgs e)
        {
            //gvComponent = gctComponent.MainView as GridView;
            ////var currentrow = gvComponent.FocusedRowHandle;
            ////int id = Convert.ToInt32(gvComponent.GetFocusedRowCellValue("id").ToString());
            ////string name = gvComponent.GetFocusedRowCellValue("name").ToString();
            ////string ItemID = gvComponent.GetFocusedRowCellValue("ItemID").ToString();
            //DataTable tbComponent = ds.Tables["tbComponent"];
            //DataTable tbScrewsize = ds.Tables["tbScrewsize"];

            //int result1 = DataOperation.UpdateTable(2, ref tbComponent, $"SELECT * from Component where ItemID = 1 order by componentID asc");
            //int result2 = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = 1 order by componentID asc");
            //gctComponent.RefreshDataSource();
            ////GridControlLoad(false);
            ////gctComponent.DataSource = null;
            ////  gctComponent.DataSource = ds.Tables[""];
        }
        private void GridControlLoad(bool isLoading)
        {
            ds.Clear();
            if (ds.Tables["tbComponent"] != null)
            {
                ds.Tables["tbComponent"].Clear();
            }
            if (ds.Tables["tbScrewsize"] != null)
            {
                ds.Tables["tbScrewsize"].Clear();
            }
          
            ds = DataOperation.SelectComponent(2, "sp_GetComponent", "1");
            ds = DataOperation.SelectSrewsize(2, "sp_GetScrewsize", "1",0,1);
            DataColumn keyColumn = ds.Tables["tbComponent"].Columns["componentID"];
            DataColumn foreignKeyColumn = ds.Tables["tbScrewsize"].Columns["componentID"];
            if (isLoading)
            {
                ds.Relations.Add("Component_Screwsize", keyColumn, foreignKeyColumn);
            }
            //Bind the grid control to the data source 
            gctComponent.DataSource = null;
            DataTable dt = ds.Tables["tbComponent"];
            gctComponent.DataSource = dt;
            gvComponent.OptionsBehavior.AutoPopulateColumns = false;
              #region Them editbutton vao gvComponent
            //RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            //EditorButton add = new EditorButton();
            //EditorButton delete = new EditorButton();
            //repositoryItemButtonEdit.ButtonClick += (sender, e) => {
            //        if (e.Button.Kind == ButtonPredefines.Delete)
            //        {
            //            if (XtraMessageBox.Show("Do you wish to remove this row?", "Confirmation Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //            {
            //                gvComponent.DeleteRow(gvComponent.FocusedRowHandle);
            //            }
            //        }
            //    };
            //repositoryItemButtonEdit.Buttons.Add(add);
            //repositoryItemButtonEdit.Buttons.Add(delete);
            //repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Plus;
            //repositoryItemButtonEdit.Buttons[1].Kind = ButtonPredefines.Delete;

            ////edit.Buttons[0].Caption = "Custom Button";
            //gctComponent.RepositoryItems.Add(repositoryItemButtonEdit);
            //    GridColumn column = gvComponent.Columns["Commands"];
            //    column.ColumnEdit = repositoryItemButtonEdit;
            //    column.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRow;
             #endregion
            //Ẩn cột ItemID
            gvComponent.Columns["ItemID"].VisibleIndex = -1;
            gvComponent.Columns["componentID"].Caption = "ComponentID";
            gvComponent.Columns["componentID"].OptionsColumn.ReadOnly = true;
            gvComponent.Columns["name"].Caption = "Name";
            gvComponent.Columns["ItemID"].Caption = "ItemID";
            gvComponent.Columns["ItemID"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gvComponent.Columns["componentID"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gvComponent.Columns["name"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gvComponent.Appearance.Row.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gctComponent.ForceInitialize();
            GridView gridview = new GridView(gctComponent);
            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gctComponent.LevelTree.Nodes.Add("Component_Screwsize", gridview);
            //Specify text to be displayed within detail tabs. 
            gridview.ViewCaption = "Screw size";
            gridview.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            //Hide the CategoryID column for the master View 
            // gridView1.Columns["CategoryID"].VisibleIndex = -1;
            //Present data in the Picture column as Images 
            gridview.PopulateColumns(ds.Tables["tbScrewsize"]);
            gridview.Columns["componentID"].VisibleIndex = -1;
            gridview.Columns["ItemID"].VisibleIndex = -1;
            gridview.Columns["screwsizeID"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gridview.Columns["screwsizeID"].Caption = "Screw size ID";
            gridview.Columns["screwsizeID"].OptionsColumn.ReadOnly = true;
            gridview.Columns["value"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gridview.Columns["value"].Caption = "Value";
            gridview.Appearance.Row.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gvComponent.Columns["componentID"].GroupIndex = 0;
            gvComponent.Columns["componentID"].SortIndex = 0;
            gvComponent.Columns["componentID"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gvComponent.ExpandAllGroups();
            gvComponent.ExpandGroupRow(0);
            //Method of child view
            gridview.EditFormPrepared += (s, o) =>
            {
                GridView view = s as GridView;
                GridColumn colscrewsizeID = view.Columns["screwsizeID"];
                GridColumn colValue = view.Columns["value"];
                //Lay max screwsizeID 
                //int rowcount = view.DataRowCount + 1;
                //var nextindex =Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0]);
                int nextindex = DataOperation.SelectLastIndex(2, "sp_GetLastScrewsizeID") + 1;
                string screwsizeID = view.GetRowCellValue(o.RowHandle, colscrewsizeID).ToString();
                if (string.IsNullOrWhiteSpace(screwsizeID))
                {
                    view.SetRowCellValue(o.RowHandle, colscrewsizeID, nextindex);
                    var IdEdit = o.BindableControls[colscrewsizeID];
                    IdEdit.Text = nextindex.ToString();
                }
                o.FocusField(colValue); //focus field Name
            };
            gridview.EditFormHidden += (s, o) =>
            {
                if (o.Result == EditFormResult.Update)
                {
                    GridView view = s as GridView;
                    //DataTable tbComponent = ds.Tables["tbComponent"];
                    DataTable tbScrewsize = ds.Tables["tbScrewsize"];
                    int componentID = Convert.ToInt32(gvComponent.GetRowCellValue(gvComponent.FocusedRowHandle,"componentID"));
                    //Neu la hang moi thi add vao database
                    if (!view.IsNewItemRow(o.RowHandle))
                    {
                        int result = DataOperation.UpdateTable(2, ref tbScrewsize, $"SELECT * from Screwsize where ItemID = {lkeItem.Text} and componentID = {componentID}  order by componentID asc");
                        if (result == -1)
                        {
                            MessageBox.Show("Loi roi kia");
                        }
                    }
                    else
                    {
                        int id = Convert.ToInt32(o.BindableControls["screwsizeID"].Text);
                        int value = Convert.ToInt32(o.BindableControls["value"].Text);
                        DataOperation.InsertScrewsize(2, "sp_createScrewsize", id, value, componentID, lkeItem.Text);
                    }
                    gctComponent.RefreshDataSource();
                }
            };
        }
    }
}