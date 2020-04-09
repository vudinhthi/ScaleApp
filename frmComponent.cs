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

namespace ScaleApp
{
    public partial class frmComponent : DevExpress.XtraEditors.XtraForm
    {
        GridView gridviewComponent;
          DataSet ds = new DataSet();
        //   GridView gridviewScrewsize;
        public frmComponent()
        {
            InitializeComponent();
        }

        private void frmComponent_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'colorMixDataSet.Component' table. You can move, or remove it, as needed.
            // componentTableAdapter.Fill(colorMixDataSet.Screwsize);
            gridviewComponent = gctComponent.MainView as GridView;
            //gridviewComponent.OptionsBehavior.Editable = true;
            gridviewComponent.OptionsSelection.MultiSelect = false;
            gridviewComponent.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gctComponent.DataSource = ds.Tables["tbComponent"];
            gctComponent.ForceInitialize();
            gridviewComponent.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridviewComponent.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            GridControlLoad();
            BaseEdit edit = null;
            gridviewComponent.EditFormShowing += (s, o) =>
            {
                GridView view = s as GridView;
                edit = view.ActiveEditor;
                view.CellValueChanged += (sd, oj) =>
                {
                    
                };
                view.RowUpdated += (sd,oj)=>
                {
                    Debug.WriteLine(ds.Tables["tbComponent"].Rows[oj.RowHandle]["name"].ToString());
                };
            };
              gridviewComponent.EditFormHidden += (s, o) =>
            {
                GridView view = s as GridView;
                //Update database
                Debug.WriteLine("Thoat editform");
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
            gridviewComponent = gctComponent.MainView as GridView;
            //var currentrow = gridviewComponent.FocusedRowHandle;
            //int id = Convert.ToInt32(gridviewComponent.GetFocusedRowCellValue("id").ToString());
            //string name = gridviewComponent.GetFocusedRowCellValue("name").ToString();
            //string ItemID = gridviewComponent.GetFocusedRowCellValue("ItemID").ToString();
            DataTable dt = ds.Tables["tbComponent"];
            DataOperation.UpdateComponent(2,ref dt, $"SELECT * from Component where ItemID = 1 order by componentID asc");
            GridControlLoad();
            //gctComponent.DataSource = null;
            //  gctComponent.DataSource = ds.Tables[""];
        }
        private void GridControlLoad()
        {
            ds = DataOperation.SelectComponent(2, "sp_GetComponent","1");
            ds = DataOperation.SelectSrewsize(2, "sp_GetScrewsize","1");
            DataColumn keyColumn = ds.Tables["tbComponent"].Columns["componentID"];
            DataColumn foreignKeyColumn = ds.Tables["tbScrewsize"].Columns["componentID"];
            ds.Relations.Add("Component_Screwsize", keyColumn, foreignKeyColumn);
            //Bind the grid control to the data source 
            gctComponent.DataSource = ds.Tables["tbComponent"];
            //Ẩn cột ItemID
            gridviewComponent.Columns["ItemID"].VisibleIndex = -1;
            gridviewComponent.Columns["componentID"].Caption = "ComponentID";
            gridviewComponent.Columns["name"].Caption = "Name";
            gridviewComponent.Columns["ItemID"].Caption = "ItemID";
            gridviewComponent.Columns["ItemID"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gridviewComponent.Columns["componentID"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gridviewComponent.Columns["name"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gridviewComponent.Appearance.Row.Font = new Font(FontFamily.GenericSansSerif,10,FontStyle.Bold);
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
            gridview.Columns["value"].AppearanceHeader.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            gridview.Appearance.Row.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

        }
    }
}