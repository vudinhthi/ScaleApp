namespace ScaleApp
{
    partial class frmCrushing
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
            this.cmbEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLostType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbOperator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbStep = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMixID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbColorCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMaterial = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtWeightRM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeightCrushed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLostType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMixID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightCrushed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEdit
            // 
            this.cmbEdit.EditValue = "X";
            this.cmbEdit.Location = new System.Drawing.Point(148, 12);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdit.Properties.Appearance.Options.UseFont = true;
            this.cmbEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEdit.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbEdit.Size = new System.Drawing.Size(199, 26);
            this.cmbEdit.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Shift";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Lost Type";
            // 
            // cmbLostType
            // 
            this.cmbLostType.Location = new System.Drawing.Point(148, 44);
            this.cmbLostType.Name = "cmbLostType";
            this.cmbLostType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLostType.Properties.Appearance.Options.UseFont = true;
            this.cmbLostType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLostType.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbLostType.Size = new System.Drawing.Size(199, 26);
            this.cmbLostType.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Operator";
            // 
            // cmbOperator
            // 
            this.cmbOperator.Location = new System.Drawing.Point(148, 76);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.Properties.Appearance.Options.UseFont = true;
            this.cmbOperator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOperator.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbOperator.Size = new System.Drawing.Size(199, 26);
            this.cmbOperator.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Machine";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 140);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 20);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Step";
            // 
            // cmbStep
            // 
            this.cmbStep.Location = new System.Drawing.Point(148, 140);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.Properties.Appearance.Options.UseFont = true;
            this.cmbStep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStep.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbStep.Size = new System.Drawing.Size(199, 26);
            this.cmbStep.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(376, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 20);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Mix Lot ID";
            // 
            // cmbMixID
            // 
            this.cmbMixID.Location = new System.Drawing.Point(512, 12);
            this.cmbMixID.Name = "cmbMixID";
            this.cmbMixID.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMixID.Properties.Appearance.Options.UseFont = true;
            this.cmbMixID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMixID.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbMixID.Size = new System.Drawing.Size(276, 26);
            this.cmbMixID.TabIndex = 10;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(148, 108);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(199, 26);
            this.textEdit1.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(376, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 20);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Product";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Location = new System.Drawing.Point(512, 44);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.Properties.Appearance.Options.UseFont = true;
            this.cmbProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProduct.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbProduct.Size = new System.Drawing.Size(276, 26);
            this.cmbProduct.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(376, 76);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 20);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Color";
            // 
            // cmbColorCode
            // 
            this.cmbColorCode.Location = new System.Drawing.Point(512, 76);
            this.cmbColorCode.Name = "cmbColorCode";
            this.cmbColorCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorCode.Properties.Appearance.Options.UseFont = true;
            this.cmbColorCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbColorCode.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbColorCode.Size = new System.Drawing.Size(276, 26);
            this.cmbColorCode.TabIndex = 15;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(376, 108);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 20);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Location = new System.Drawing.Point(512, 108);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.Properties.Appearance.Options.UseFont = true;
            this.cmbMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaterial.Properties.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbMaterial.Size = new System.Drawing.Size(276, 26);
            this.cmbMaterial.TabIndex = 17;
            // 
            // txtWeightRM
            // 
            this.txtWeightRM.Location = new System.Drawing.Point(512, 140);
            this.txtWeightRM.Name = "txtWeightRM";
            this.txtWeightRM.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRM.Properties.Appearance.Options.UseFont = true;
            this.txtWeightRM.Size = new System.Drawing.Size(276, 32);
            this.txtWeightRM.TabIndex = 20;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(376, 140);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 20);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Weight";
            // 
            // txtWeightCrushed
            // 
            this.txtWeightCrushed.Location = new System.Drawing.Point(512, 178);
            this.txtWeightCrushed.Name = "txtWeightCrushed";
            this.txtWeightCrushed.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightCrushed.Properties.Appearance.Options.UseFont = true;
            this.txtWeightCrushed.Size = new System.Drawing.Size(276, 32);
            this.txtWeightCrushed.TabIndex = 22;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(376, 178);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(128, 20);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Weight Crushed";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(512, 216);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Size = new System.Drawing.Size(276, 32);
            this.txtTotal.TabIndex = 24;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(376, 216);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(40, 20);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "Total";
            // 
            // frmCrushing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtWeightCrushed);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtWeightRM);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cmbColorCode);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cmbMixID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmbStep);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbLostType);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbEdit);
            this.Name = "frmCrushing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crushing Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCrushing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLostType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMixID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightCrushed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLostType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOperator;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbStep;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMixID;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProduct;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cmbColorCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMaterial;
        private DevExpress.XtraEditors.TextEdit txtWeightRM;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtWeightCrushed;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}