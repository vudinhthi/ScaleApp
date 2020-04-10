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
            gct_Screwsize.DataSource = null;
            gct_Screwsize.DataSource =ds.Tables["tbScrewsize"] ;
        }

        private void frmScrewsize_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
                