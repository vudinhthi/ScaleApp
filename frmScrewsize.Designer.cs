namespace ScaleApp
{
    partial class frmScrewsize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gct_Screwsize = new DevExpress.XtraGrid.GridControl();
            this.gvScrewsize = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.screwsizeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.value = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gct_Screwsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScrewsize)).BeginInit();
            this.SuspendLayout();
            // 
            // gct_Screwsize
            // 
            this.gct_Screwsize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gct_Screwsize.Location = new System.Drawing.Point(0, 0);
            this.gct_Screwsize.MainView = this.gvScrewsize;
            this.gct_Screwsize.Name = "gct_Screwsize";
            this.gct_Screwsize.Size = new System.Drawing.Size(1218, 730);
            this.gct_Screwsize.TabIndex = 0;
            this.gct_Screwsize.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvScrewsize});
            // 
            // gvScrewsize
            // 
            this.gvScrewsize.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.screwsizeID,
            this.value});
            this.gvScrewsize.GridControl = this.gct_Screwsize;
            this.gvScrewsize.Name = "gvScrewsize";
            // 
            // screwsizeID
            // 
            this.screwsizeID.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screwsizeID.AppearanceCell.Options.UseFont = true;
            this.screwsizeID.AppearanceCell.Options.UseTextOptions = true;
            this.screwsizeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.screwsizeID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.screwsizeID.AppearanceHeader.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.screwsizeID.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screwsizeID.AppearanceHeader.Options.UseBackColor = true;
            this.screwsizeID.AppearanceHeader.Options.UseFont = true;
            this.screwsizeID.AppearanceHeader.Options.UseTextOptions = true;
            this.screwsizeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.screwsizeID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.screwsizeID.Caption = "ScrewsizeID";
            this.screwsizeID.FieldName = "screwsizeID";
            this.screwsizeID.Name = "screwsizeID";
            this.screwsizeID.OptionsColumn.ReadOnly = true;
            this.screwsizeID.Visible = true;
            this.screwsizeID.VisibleIndex = 0;
            // 
            // value
            // 
            this.value.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.AppearanceCell.Options.UseFont = true;
            this.value.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.AppearanceHeader.Options.UseFont = true;
            this.value.AppearanceHeader.Options.UseTextOptions = true;
            this.value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.value.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.value.Caption = "Value";
            this.value.FieldName = "value";
            this.value.Name = "value";
            this.value.Visible = true;
            this.value.VisibleIndex = 1;
            // 
            // frmScrewsize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 730);
            this.Controls.Add(this.gct_Screwsize);
            this.Name = "frmScrewsize";
            this.Text = "frmScrewsize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScrewsize_FormClosed);
            this.Load += new System.EventHandler(this.frmScrewsize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gct_Screwsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScrewsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gct_Screwsize;
        private DevExpress.XtraGrid.Views.Grid.GridView gvScrewsize;
        private DevExpress.XtraGrid.Columns.GridColumn screwsizeID;
        private DevExpress.XtraGrid.Columns.GridColumn value;
    }
}