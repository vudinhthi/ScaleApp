﻿namespace ScaleApp
{
    partial class frmReportMixed
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
            this.components = new System.ComponentModel.Container();
            this.documentViewerRibbonController1 = new DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(this.components);
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewerRibbonController1
            // 
            this.documentViewerRibbonController1.DocumentViewer = this.documentViewer1;
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(706, 727);
            this.documentViewer1.TabIndex = 0;
            // 
            // frmReportMixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 727);
            this.Controls.Add(this.documentViewer1);
            this.Name = "frmReportMixed";
            this.Text = "Mixed Label";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController documentViewerRibbonController1;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}