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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrushing));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMachine = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtScaleWeight = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNow = new System.Windows.Forms.TextBox();
            this.txtCrushDate = new System.Windows.Forms.TextBox();
            this.gridCrushed = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecycledID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MixID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.cmbLostType = new System.Windows.Forms.ComboBox();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbMixId = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtWeightCrushed = new System.Windows.Forms.TextBox();
            this.txtCrushID = new System.Windows.Forms.TextBox();
            this.qrCodeCrush = new DevExpress.XtraEditors.BarCodeControl();
            this.txtPosted = new System.Windows.Forms.TextBox();
            this.lueMaterial = new DevExpress.XtraEditors.LookUpEdit();
            this.lueMixId = new DevExpress.XtraEditors.LookUpEdit();
            this.lueProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPost = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.cmbOperator = new DevExpress.XtraEditors.LookUpEdit();
            this.txtWeightRe = new DevExpress.XtraEditors.ButtonEdit();
            this.tedColorCode = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.spbScale = new DevExpress.XtraEditors.SimpleButton();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.tedColor = new System.Windows.Forms.TextBox();
            this.tedProductName = new System.Windows.Forms.TextBox();
            this.txtMachineMix = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrushed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMixId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineMix.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 7);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
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
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 42);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(78, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Lost Type";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(395, 7);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(72, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Operator";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.labelControl4, 2);
            this.labelControl4.Location = new System.Drawing.Point(395, 42);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 1);
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
            this.tablePanel5.SetColumn(this.labelControl5, 2);
            this.labelControl5.Location = new System.Drawing.Point(394, 138);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel5.SetRow(this.labelControl5, 3);
            this.labelControl5.Size = new System.Drawing.Size(38, 20);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Step";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.tablePanel5.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(3, 7);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel5.SetRow(this.labelControl6, 0);
            this.labelControl6.Size = new System.Drawing.Size(105, 20);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Mix Lot ID (*)";
            // 
            // txtMachine
            // 
            this.tablePanel1.SetColumn(this.txtMachine, 3);
            this.txtMachine.Location = new System.Drawing.Point(493, 39);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Properties.Appearance.Options.UseFont = true;
            this.tablePanel1.SetRow(this.txtMachine, 1);
            this.txtMachine.Size = new System.Drawing.Size(267, 26);
            this.txtMachine.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.tablePanel5.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(3, 42);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel5.SetRow(this.labelControl7, 1);
            this.labelControl7.Size = new System.Drawing.Size(86, 20);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Product (*)";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.tablePanel5.SetColumn(this.labelControl8, 2);
            this.labelControl8.Location = new System.Drawing.Point(394, 42);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel5.SetRow(this.labelControl8, 1);
            this.labelControl8.Size = new System.Drawing.Size(86, 20);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Color code";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.labelControl11, 0);
            this.labelControl11.Location = new System.Drawing.Point(3, 81);
            this.labelControl11.Name = "labelControl11";
            this.tablePanel1.SetRow(this.labelControl11, 2);
            this.labelControl11.Size = new System.Drawing.Size(56, 20);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Weight";
            // 
            // txtScaleWeight
            // 
            this.txtScaleWeight.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtScaleWeight.Location = new System.Drawing.Point(12, 305);
            this.txtScaleWeight.Name = "txtScaleWeight";
            this.txtScaleWeight.Size = new System.Drawing.Size(210, 81);
            this.txtScaleWeight.TabIndex = 27;
            this.txtScaleWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNow
            // 
            this.tablePanel4.SetColumn(this.txtNow, 0);
            this.txtNow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNow.Location = new System.Drawing.Point(3, 3);
            this.txtNow.Name = "txtNow";
            this.txtNow.ReadOnly = true;
            this.tablePanel4.SetRow(this.txtNow, 0);
            this.txtNow.Size = new System.Drawing.Size(212, 25);
            this.txtNow.TabIndex = 32;
            this.txtNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrushDate
            // 
            this.tablePanel4.SetColumn(this.txtCrushDate, 0);
            this.txtCrushDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrushDate.Location = new System.Drawing.Point(3, 187);
            this.txtCrushDate.Name = "txtCrushDate";
            this.txtCrushDate.ReadOnly = true;
            this.tablePanel4.SetRow(this.txtCrushDate, 2);
            this.txtCrushDate.Size = new System.Drawing.Size(212, 26);
            this.txtCrushDate.TabIndex = 33;
            this.txtCrushDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridCrushed
            // 
            this.gridCrushed.AllowUserToAddRows = false;
            this.gridCrushed.AllowUserToDeleteRows = false;
            this.gridCrushed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrushed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.RecycledID,
            this.MixID,
            this.Shift,
            this.Operator,
            this.Item,
            this.Material,
            this.Color,
            this.Step,
            this.LostType,
            this.Weight,
            this.Machine,
            this.Posted});
            this.gridCrushed.Location = new System.Drawing.Point(26, 590);
            this.gridCrushed.Name = "gridCrushed";
            this.gridCrushed.ReadOnly = true;
            this.gridCrushed.Size = new System.Drawing.Size(666, 100);
            this.gridCrushed.TabIndex = 34;
            this.gridCrushed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrushed_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // RecycledID
            // 
            this.RecycledID.HeaderText = "Recycled ID";
            this.RecycledID.Name = "RecycledID";
            this.RecycledID.ReadOnly = true;
            // 
            // MixID
            // 
            this.MixID.HeaderText = "Mix ID";
            this.MixID.Name = "MixID";
            this.MixID.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Step
            // 
            this.Step.HeaderText = "Step";
            this.Step.Name = "Step";
            this.Step.ReadOnly = true;
            // 
            // LostType
            // 
            this.LostType.HeaderText = "LostType";
            this.LostType.Name = "LostType";
            this.LostType.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // Machine
            // 
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // Posted
            // 
            this.Posted.HeaderText = "Posted";
            this.Posted.Name = "Posted";
            this.Posted.ReadOnly = true;
            // 
            // cmbShift
            // 
            this.tablePanel1.SetColumn(this.cmbShift, 1);
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "",
            "X",
            "Y",
            "Z"});
            this.cmbShift.Location = new System.Drawing.Point(116, 3);
            this.cmbShift.Name = "cmbShift";
            this.tablePanel1.SetRow(this.cmbShift, 0);
            this.cmbShift.Size = new System.Drawing.Size(273, 28);
            this.cmbShift.TabIndex = 36;
            // 
            // cmbLostType
            // 
            this.tablePanel1.SetColumn(this.cmbLostType, 1);
            this.cmbLostType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLostType.FormattingEnabled = true;
            this.cmbLostType.Items.AddRange(new object[] {
            "",
            "Recycle",
            "Defect",
            "Framapur",
            "Framaprene",
            "Mix Material/Contaminated"});
            this.cmbLostType.Location = new System.Drawing.Point(116, 38);
            this.cmbLostType.Name = "cmbLostType";
            this.tablePanel1.SetRow(this.cmbLostType, 1);
            this.cmbLostType.Size = new System.Drawing.Size(273, 28);
            this.cmbLostType.TabIndex = 37;
            // 
            // cmbStep
            // 
            this.tablePanel5.SetColumn(this.cmbStep, 3);
            this.cmbStep.Enabled = false;
            this.cmbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(492, 134);
            this.cmbStep.Name = "cmbStep";
            this.tablePanel5.SetRow(this.cmbStep, 3);
            this.cmbStep.Size = new System.Drawing.Size(268, 28);
            this.cmbStep.TabIndex = 38;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownWidth = 400;
            this.cmbProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(70, 394);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(23, 30);
            this.cmbProduct.TabIndex = 39;
            this.cmbProduct.Visible = false;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownWidth = 250;
            this.cmbColor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(99, 392);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(23, 30);
            this.cmbColor.TabIndex = 40;
            this.cmbColor.Visible = false;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbMixId
            // 
            this.cmbMixId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMixId.FormattingEnabled = true;
            this.cmbMixId.Location = new System.Drawing.Point(512, 12);
            this.cmbMixId.Name = "cmbMixId";
            this.cmbMixId.Size = new System.Drawing.Size(28, 30);
            this.cmbMixId.TabIndex = 41;
            this.cmbMixId.Visible = false;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownWidth = 300;
            this.cmbMaterial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(512, 53);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(28, 30);
            this.cmbMaterial.TabIndex = 42;
            this.cmbMaterial.Visible = false;
            // 
            // txtWeightCrushed
            // 
            this.txtWeightCrushed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightCrushed.Location = new System.Drawing.Point(512, 97);
            this.txtWeightCrushed.Name = "txtWeightCrushed";
            this.txtWeightCrushed.Size = new System.Drawing.Size(28, 29);
            this.txtWeightCrushed.TabIndex = 44;
            this.txtWeightCrushed.Visible = false;
            // 
            // txtCrushID
            // 
            this.txtCrushID.Location = new System.Drawing.Point(12, 435);
            this.txtCrushID.Name = "txtCrushID";
            this.txtCrushID.ReadOnly = true;
            this.txtCrushID.Size = new System.Drawing.Size(170, 20);
            this.txtCrushID.TabIndex = 45;
            this.txtCrushID.Visible = false;
            // 
            // qrCodeCrush
            // 
            this.qrCodeCrush.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrCodeCrush.Appearance.Options.UseFont = true;
            this.qrCodeCrush.AutoModule = true;
            this.tablePanel4.SetColumn(this.qrCodeCrush, 0);
            this.qrCodeCrush.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrCodeCrush.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrCodeCrush.Location = new System.Drawing.Point(3, 54);
            this.qrCodeCrush.Name = "qrCodeCrush";
            this.qrCodeCrush.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.tablePanel4.SetRow(this.qrCodeCrush, 1);
            this.qrCodeCrush.Size = new System.Drawing.Size(212, 106);
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version3;
            this.qrCodeCrush.Symbology = qrCodeGenerator1;
            this.qrCodeCrush.TabIndex = 25;
            // 
            // txtPosted
            // 
            this.txtPosted.Location = new System.Drawing.Point(12, 461);
            this.txtPosted.Name = "txtPosted";
            this.txtPosted.Size = new System.Drawing.Size(170, 20);
            this.txtPosted.TabIndex = 46;
            this.txtPosted.Visible = false;
            // 
            // lueMaterial
            // 
            this.lueMaterial.Location = new System.Drawing.Point(12, 391);
            this.lueMaterial.Name = "lueMaterial";
            this.lueMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMaterial.Properties.Appearance.Options.UseFont = true;
            this.lueMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaterial.Properties.NullText = "";
            this.lueMaterial.Size = new System.Drawing.Size(52, 30);
            this.lueMaterial.TabIndex = 49;
            this.lueMaterial.Visible = false;
            this.lueMaterial.EditValueChanged += new System.EventHandler(this.lueMaterial_EditValueChanged);
            // 
            // lueMixId
            // 
            this.tablePanel5.SetColumn(this.lueMixId, 1);
            this.tablePanel5.SetColumnSpan(this.lueMixId, 3);
            this.lueMixId.Location = new System.Drawing.Point(117, 4);
            this.lueMixId.Name = "lueMixId";
            this.lueMixId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMixId.Properties.Appearance.Options.UseFont = true;
            this.lueMixId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMixId.Properties.NullText = "";
            this.tablePanel5.SetRow(this.lueMixId, 0);
            this.lueMixId.Size = new System.Drawing.Size(643, 26);
            this.lueMixId.TabIndex = 50;
            this.lueMixId.EditValueChanged += new System.EventHandler(this.lueMixId_EditValueChanged);
            // 
            // lueProduct
            // 
            this.tablePanel5.SetColumn(this.lueProduct, 1);
            this.lueProduct.Location = new System.Drawing.Point(117, 39);
            this.lueProduct.Name = "lueProduct";
            this.lueProduct.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueProduct.Properties.Appearance.Options.UseFont = true;
            this.lueProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProduct.Properties.NullText = "";
            this.lueProduct.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueProduct.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.tablePanel5.SetRow(this.lueProduct, 1);
            this.lueProduct.Size = new System.Drawing.Size(271, 26);
            this.lueProduct.TabIndex = 51;
            this.lueProduct.EditValueChanged += new System.EventHandler(this.lueProduct_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.simpleButton2, 5);
            this.simpleButton2.ImageOptions.Image = global::ScaleApp.Properties.Resources.refresh_32x32;
            this.simpleButton2.Location = new System.Drawing.Point(376, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel3.SetRow(this.simpleButton2, 0);
            this.simpleButton2.Size = new System.Drawing.Size(84, 81);
            this.simpleButton2.TabIndex = 55;
            this.simpleButton2.Text = "Refesh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.simpleButton1, 4);
            this.simpleButton1.ImageOptions.Image = global::ScaleApp.Properties.Resources.exporttoxls_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(284, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel3.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(85, 81);
            this.simpleButton1.TabIndex = 54;
            this.simpleButton1.Text = "Export";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdPost
            // 
            this.tablePanel3.SetColumn(this.cmdPost, 1);
            this.cmdPost.Image = global::ScaleApp.Properties.Resources.Mark_32x32;
            this.cmdPost.Location = new System.Drawing.Point(72, 3);
            this.cmdPost.Name = "cmdPost";
            this.tablePanel3.SetRow(this.cmdPost, 0);
            this.cmdPost.Size = new System.Drawing.Size(64, 81);
            this.cmdPost.TabIndex = 47;
            this.cmdPost.UseVisualStyleBackColor = true;
            this.cmdPost.Click += new System.EventHandler(this.cmdPost_Click);
            // 
            // cmdPrint
            // 
            this.tablePanel3.SetColumn(this.cmdPrint, 3);
            this.cmdPrint.Image = global::ScaleApp.Properties.Resources.Print_32x32;
            this.cmdPrint.Location = new System.Drawing.Point(212, 3);
            this.cmdPrint.Name = "cmdPrint";
            this.tablePanel3.SetRow(this.cmdPrint, 0);
            this.cmdPrint.Size = new System.Drawing.Size(66, 81);
            this.cmdPrint.TabIndex = 31;
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdReset
            // 
            this.tablePanel3.SetColumn(this.cmdReset, 2);
            this.cmdReset.Image = global::ScaleApp.Properties.Resources.Cancel_32x32;
            this.cmdReset.Location = new System.Drawing.Point(142, 3);
            this.cmdReset.Name = "cmdReset";
            this.tablePanel3.SetRow(this.cmdReset, 0);
            this.cmdReset.Size = new System.Drawing.Size(65, 81);
            this.cmdReset.TabIndex = 30;
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdSave
            // 
            this.tablePanel3.SetColumn(this.cmdSave, 0);
            this.cmdSave.Image = global::ScaleApp.Properties.Resources.Save_32x32;
            this.cmdSave.Location = new System.Drawing.Point(3, 3);
            this.cmdSave.Name = "cmdSave";
            this.tablePanel3.SetRow(this.cmdSave, 0);
            this.cmdSave.Size = new System.Drawing.Size(63, 81);
            this.cmdSave.TabIndex = 29;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(12, 396);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1457, 378);
            this.gridControl1.TabIndex = 56;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 23.69F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 58.58F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.38F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 57.35F)});
            this.tablePanel1.Controls.Add(this.cmbOperator);
            this.tablePanel1.Controls.Add(this.txtWeightRe);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl11);
            this.tablePanel1.Controls.Add(this.cmbShift);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.cmbLostType);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.txtMachine);
            this.tablePanel1.Location = new System.Drawing.Point(15, 184);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 37F)});
            this.tablePanel1.Size = new System.Drawing.Size(763, 112);
            this.tablePanel1.TabIndex = 57;
            // 
            // cmbOperator
            // 
            this.tablePanel1.SetColumn(this.cmbOperator, 3);
            this.cmbOperator.Location = new System.Drawing.Point(493, 4);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.Properties.Appearance.Options.UseFont = true;
            this.cmbOperator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOperator.Properties.NullText = "";
            this.cmbOperator.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbOperator.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.tablePanel1.SetRow(this.cmbOperator, 0);
            this.cmbOperator.Size = new System.Drawing.Size(267, 26);
            this.cmbOperator.TabIndex = 61;
            // 
            // txtWeightRe
            // 
            this.tablePanel1.SetColumn(this.txtWeightRe, 1);
            this.tablePanel1.SetColumnSpan(this.txtWeightRe, 3);
            this.txtWeightRe.Location = new System.Drawing.Point(116, 75);
            this.txtWeightRe.Name = "txtWeightRe";
            this.txtWeightRe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRe.Properties.Appearance.Options.UseFont = true;
            this.txtWeightRe.Properties.Appearance.Options.UseTextOptions = true;
            this.txtWeightRe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtWeightRe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtWeightRe.Properties.Mask.EditMask = "f";
            this.txtWeightRe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeightRe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.txtWeightRe, 2);
            this.txtWeightRe.Size = new System.Drawing.Size(644, 32);
            this.txtWeightRe.TabIndex = 60;
            this.txtWeightRe.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtWeightRe_ButtonClick);
            // 
            // tedColorCode
            // 
            this.tablePanel5.SetColumn(this.tedColorCode, 3);
            this.tedColorCode.Location = new System.Drawing.Point(492, 39);
            this.tedColorCode.Name = "tedColorCode";
            this.tedColorCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedColorCode.Properties.Appearance.Options.UseFont = true;
            this.tedColorCode.Properties.ReadOnly = true;
            this.tablePanel5.SetRow(this.tedColorCode, 1);
            this.tedColorCode.Size = new System.Drawing.Size(268, 26);
            this.tedColorCode.TabIndex = 61;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.47F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.89F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.47F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.51F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60.11F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59.55F)});
            this.tablePanel3.Controls.Add(this.cmdSave);
            this.tablePanel3.Controls.Add(this.cmdPost);
            this.tablePanel3.Controls.Add(this.cmdReset);
            this.tablePanel3.Controls.Add(this.cmdPrint);
            this.tablePanel3.Controls.Add(this.simpleButton2);
            this.tablePanel3.Controls.Add(this.simpleButton1);
            this.tablePanel3.Location = new System.Drawing.Point(315, 302);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(463, 88);
            this.tablePanel3.TabIndex = 59;
            // 
            // tablePanel4
            // 
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel4.Controls.Add(this.qrCodeCrush);
            this.tablePanel4.Controls.Add(this.txtNow);
            this.tablePanel4.Controls.Add(this.txtCrushDate);
            this.tablePanel4.Location = new System.Drawing.Point(784, 12);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 31F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 153F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(218, 216);
            this.tablePanel4.TabIndex = 60;
            // 
            // spbScale
            // 
            this.spbScale.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbScale.Appearance.Options.UseFont = true;
            this.spbScale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbScale.ImageOptions.Image")));
            this.spbScale.Location = new System.Drawing.Point(228, 305);
            this.spbScale.Name = "spbScale";
            this.spbScale.Size = new System.Drawing.Size(75, 81);
            this.spbScale.TabIndex = 61;
            this.spbScale.Text = "Scale";
            this.spbScale.Click += new System.EventHandler(this.spbScale_Click);
            // 
            // cboComPort
            // 
            this.cboComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(787, 234);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(212, 24);
            this.cboComPort.TabIndex = 62;
            // 
            // timer2
            // 
            this.timer2.Interval = 20000;
            // 
            // tablePanel5
            // 
            this.tablePanel5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 23.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 58.1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.39F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 57.56F)});
            this.tablePanel5.Controls.Add(this.tedColor);
            this.tablePanel5.Controls.Add(this.tedProductName);
            this.tablePanel5.Controls.Add(this.txtMachineMix);
            this.tablePanel5.Controls.Add(this.labelControl9);
            this.tablePanel5.Controls.Add(this.tedColorCode);
            this.tablePanel5.Controls.Add(this.labelControl6);
            this.tablePanel5.Controls.Add(this.lueMixId);
            this.tablePanel5.Controls.Add(this.labelControl7);
            this.tablePanel5.Controls.Add(this.lueProduct);
            this.tablePanel5.Controls.Add(this.labelControl8);
            this.tablePanel5.Controls.Add(this.labelControl5);
            this.tablePanel5.Controls.Add(this.cmbStep);
            this.tablePanel5.Location = new System.Drawing.Point(15, 12);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F)});
            this.tablePanel5.Size = new System.Drawing.Size(763, 166);
            this.tablePanel5.TabIndex = 63;
            // 
            // tedColor
            // 
            this.tablePanel5.SetColumn(this.tedColor, 3);
            this.tedColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedColor.Location = new System.Drawing.Point(492, 73);
            this.tedColor.Multiline = true;
            this.tedColor.Name = "tedColor";
            this.tedColor.ReadOnly = true;
            this.tablePanel5.SetRow(this.tedColor, 2);
            this.tedColor.Size = new System.Drawing.Size(268, 54);
            this.tedColor.TabIndex = 66;
            // 
            // tedProductName
            // 
            this.tablePanel5.SetColumn(this.tedProductName, 1);
            this.tedProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedProductName.Location = new System.Drawing.Point(117, 73);
            this.tedProductName.Multiline = true;
            this.tedProductName.Name = "tedProductName";
            this.tedProductName.ReadOnly = true;
            this.tablePanel5.SetRow(this.tedProductName, 2);
            this.tedProductName.Size = new System.Drawing.Size(271, 54);
            this.tedProductName.TabIndex = 65;
            // 
            // txtMachineMix
            // 
            this.tablePanel5.SetColumn(this.txtMachineMix, 1);
            this.txtMachineMix.Location = new System.Drawing.Point(117, 135);
            this.txtMachineMix.Name = "txtMachineMix";
            this.txtMachineMix.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineMix.Properties.Appearance.Options.UseFont = true;
            this.txtMachineMix.Properties.ReadOnly = true;
            this.tablePanel5.SetRow(this.txtMachineMix, 3);
            this.txtMachineMix.Size = new System.Drawing.Size(271, 26);
            this.txtMachineMix.TabIndex = 64;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.tablePanel5.SetColumn(this.labelControl9, 0);
            this.labelControl9.Location = new System.Drawing.Point(3, 138);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel5.SetRow(this.labelControl9, 3);
            this.labelControl9.Size = new System.Drawing.Size(67, 20);
            this.labelControl9.TabIndex = 63;
            this.labelControl9.Text = "Machine";
            // 
            // frmCrushing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 781);
            this.Controls.Add(this.tablePanel5);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.spbScale);
            this.Controls.Add(this.tablePanel4);
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.txtScaleWeight);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lueMaterial);
            this.Controls.Add(this.txtPosted);
            this.Controls.Add(this.txtCrushID);
            this.Controls.Add(this.txtWeightCrushed);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbMixId);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.gridCrushed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrushing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crushing Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCrushing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrushed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMixId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            this.tablePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineMix.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMachine;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txtScaleWeight;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtNow;
        private System.Windows.Forms.TextBox txtCrushDate;
        private System.Windows.Forms.DataGridView gridCrushed;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.ComboBox cmbLostType;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbMixId;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtWeightCrushed;
        private System.Windows.Forms.TextBox txtCrushID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecycledID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MixID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private DevExpress.XtraEditors.BarCodeControl qrCodeCrush;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posted;
        private System.Windows.Forms.TextBox txtPosted;
        private System.Windows.Forms.Button cmdPost;
        private DevExpress.XtraEditors.LookUpEdit lueMaterial;
        private DevExpress.XtraEditors.LookUpEdit lueMixId;
        private DevExpress.XtraEditors.LookUpEdit lueProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.ButtonEdit txtWeightRe;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.TextEdit tedColorCode;
        private DevExpress.XtraEditors.SimpleButton spbScale;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private DevExpress.XtraEditors.TextEdit txtMachineMix;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox tedColor;
        private System.Windows.Forms.TextBox tedProductName;
        private DevExpress.XtraEditors.LookUpEdit cmbOperator;
    }
}