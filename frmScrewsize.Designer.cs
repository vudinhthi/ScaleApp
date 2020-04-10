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
            this.gct_Screwsize.Size = new System.Drawing.Size(1083, 652);
            this.gct_Screwsize.TabIndex = 0;
            this.gct_Screwsize.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvScrewsize});
            // 
            // gvScrewsize
            // 
            this.gvScrewsize.GridControl = this.gct_Screwsize;
            this.gvScrewsize.Name = "gvScrewsize";
            // 
            // frmScrewsize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 652);
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
    }
}