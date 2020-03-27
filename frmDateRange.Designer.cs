namespace ScaleApp
{
    partial class frmDateRange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDateRange));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dateTodate = new DevExpress.XtraEditors.DateEdit();
            this.dateFromdate = new DevExpress.XtraEditors.DateEdit();
            this.spbOK = new DevExpress.XtraEditors.SimpleButton();
            this.spbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTodate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTodate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.77F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.59F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.35F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.29F)});
            this.tablePanel1.Controls.Add(this.dateTodate);
            this.tablePanel1.Controls.Add(this.dateFromdate);
            this.tablePanel1.Controls.Add(this.spbOK);
            this.tablePanel1.Controls.Add(this.spbCancel);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(342, 128);
            this.tablePanel1.TabIndex = 0;
            // 
            // dateTodate
            // 
            this.tablePanel1.SetColumn(this.dateTodate, 1);
            this.tablePanel1.SetColumnSpan(this.dateTodate, 3);
            this.dateTodate.EditValue = null;
            this.dateTodate.Location = new System.Drawing.Point(109, 43);
            this.dateTodate.Name = "dateTodate";
            this.dateTodate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTodate.Properties.Appearance.Options.UseFont = true;
            this.dateTodate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTodate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.dateTodate, 1);
            this.dateTodate.Size = new System.Drawing.Size(230, 22);
            this.dateTodate.TabIndex = 5;
            // 
            // dateFromdate
            // 
            this.tablePanel1.SetColumn(this.dateFromdate, 1);
            this.tablePanel1.SetColumnSpan(this.dateFromdate, 3);
            this.dateFromdate.EditValue = null;
            this.dateFromdate.Location = new System.Drawing.Point(109, 6);
            this.dateFromdate.Name = "dateFromdate";
            this.dateFromdate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromdate.Properties.Appearance.Options.UseFont = true;
            this.dateFromdate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dateFromdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFromdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.dateFromdate, 0);
            this.dateFromdate.Size = new System.Drawing.Size(230, 22);
            this.dateFromdate.TabIndex = 4;
            // 
            // spbOK
            // 
            this.spbOK.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbOK.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbOK.Appearance.Options.UseFont = true;
            this.spbOK.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.spbOK, 1);
            this.spbOK.Location = new System.Drawing.Point(109, 83);
            this.spbOK.Name = "spbOK";
            this.tablePanel1.SetRow(this.spbOK, 2);
            this.spbOK.Size = new System.Drawing.Size(104, 34);
            this.spbOK.TabIndex = 3;
            this.spbOK.Text = "OK";
            this.spbOK.Click += new System.EventHandler(this.spbOK_Click);
            // 
            // spbCancel
            // 
            this.spbCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbCancel.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbCancel.Appearance.Options.UseFont = true;
            this.spbCancel.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.spbCancel, 3);
            this.spbCancel.Location = new System.Drawing.Point(231, 83);
            this.spbCancel.Name = "spbCancel";
            this.tablePanel1.SetRow(this.spbCancel, 2);
            this.spbCancel.Size = new System.Drawing.Size(108, 34);
            this.spbCancel.TabIndex = 2;
            this.spbCancel.Text = "Cancel";
            this.spbCancel.Click += new System.EventHandler(this.spbCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 46);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "To date";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 9);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "From date";
            // 
            // frmDateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 152);
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmDateRange.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDateRange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select date range";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTodate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTodate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.DateEdit dateTodate;
        private DevExpress.XtraEditors.DateEdit dateFromdate;
        private DevExpress.XtraEditors.SimpleButton spbOK;
        private DevExpress.XtraEditors.SimpleButton spbCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}