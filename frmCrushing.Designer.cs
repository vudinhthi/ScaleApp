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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMachine = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdGetWeight = new System.Windows.Forms.Button();
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
            this.cmbOperator = new System.Windows.Forms.ComboBox();
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
            this.cmdPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrushed)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl2.Location = new System.Drawing.Point(12, 53);
            this.labelControl2.Name = "labelControl2";
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
            this.labelControl3.Location = new System.Drawing.Point(12, 97);
            this.labelControl3.Name = "labelControl3";
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
            this.labelControl4.Location = new System.Drawing.Point(12, 139);
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
            this.labelControl5.Location = new System.Drawing.Point(12, 180);
            this.labelControl5.Name = "labelControl5";
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
            this.labelControl6.Location = new System.Drawing.Point(376, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 20);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Mix Lot ID";
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(148, 139);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Properties.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Properties.Appearance.Options.UseFont = true;
            this.txtMachine.Size = new System.Drawing.Size(199, 28);
            this.txtMachine.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 225);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 20);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Product";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 267);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 20);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Color";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(376, 53);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 20);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Material";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(376, 97);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(128, 20);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Weight Crushed";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(378, 139);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(128, 20);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "Recycled Lot ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(12, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(335, 81);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "25";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = global::ScaleApp.Properties.Resources.Print_32x32;
            this.cmdPrint.Location = new System.Drawing.Point(819, 334);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(129, 60);
            this.cmdPrint.TabIndex = 31;
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Image = global::ScaleApp.Properties.Resources.Cancel_32x32;
            this.cmdReset.Location = new System.Drawing.Point(820, 264);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(128, 60);
            this.cmdReset.TabIndex = 30;
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::ScaleApp.Properties.Resources.Save_32x32;
            this.cmdSave.Location = new System.Drawing.Point(820, 125);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(129, 60);
            this.cmdSave.TabIndex = 29;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdGetWeight
            // 
            this.cmdGetWeight.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetWeight.Image = global::ScaleApp.Properties.Resources.GenerateData_32x32;
            this.cmdGetWeight.Location = new System.Drawing.Point(353, 313);
            this.cmdGetWeight.Name = "cmdGetWeight";
            this.cmdGetWeight.Size = new System.Drawing.Size(151, 81);
            this.cmdGetWeight.TabIndex = 28;
            this.cmdGetWeight.UseVisualStyleBackColor = true;
            this.cmdGetWeight.Click += new System.EventHandler(this.cmdGetWeight_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNow
            // 
            this.txtNow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNow.Location = new System.Drawing.Point(795, 12);
            this.txtNow.Name = "txtNow";
            this.txtNow.ReadOnly = true;
            this.txtNow.Size = new System.Drawing.Size(173, 26);
            this.txtNow.TabIndex = 32;
            this.txtNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrushDate
            // 
            this.txtCrushDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrushDate.Location = new System.Drawing.Point(512, 365);
            this.txtCrushDate.Name = "txtCrushDate";
            this.txtCrushDate.ReadOnly = true;
            this.txtCrushDate.Size = new System.Drawing.Size(276, 29);
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
            this.gridCrushed.Location = new System.Drawing.Point(12, 413);
            this.gridCrushed.Name = "gridCrushed";
            this.gridCrushed.ReadOnly = true;
            this.gridCrushed.Size = new System.Drawing.Size(936, 264);
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
            // cmbOperator
            // 
            this.cmbOperator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOperator.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(148, 95);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(199, 30);
            this.cmbOperator.TabIndex = 35;
            // 
            // cmbShift
            // 
            this.cmbShift.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "",
            "X",
            "Y",
            "Z"});
            this.cmbShift.Location = new System.Drawing.Point(148, 10);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(199, 30);
            this.cmbShift.TabIndex = 36;
            // 
            // cmbLostType
            // 
            this.cmbLostType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLostType.FormattingEnabled = true;
            this.cmbLostType.Items.AddRange(new object[] {
            "",
            "Recycle",
            "Framapur",
            "Framaprene",
            "Mix Material/Contaminated"});
            this.cmbLostType.Location = new System.Drawing.Point(148, 53);
            this.cmbLostType.Name = "cmbLostType";
            this.cmbLostType.Size = new System.Drawing.Size(199, 30);
            this.cmbLostType.TabIndex = 37;
            // 
            // cmbStep
            // 
            this.cmbStep.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(148, 180);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(199, 30);
            this.cmbStep.TabIndex = 38;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownWidth = 400;
            this.cmbProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(148, 225);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(199, 30);
            this.cmbProduct.TabIndex = 39;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownWidth = 250;
            this.cmbColor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(148, 267);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(199, 30);
            this.cmbColor.TabIndex = 40;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbMixId
            // 
            this.cmbMixId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMixId.FormattingEnabled = true;
            this.cmbMixId.Location = new System.Drawing.Point(512, 12);
            this.cmbMixId.Name = "cmbMixId";
            this.cmbMixId.Size = new System.Drawing.Size(276, 30);
            this.cmbMixId.TabIndex = 41;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownWidth = 300;
            this.cmbMaterial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(512, 53);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(276, 30);
            this.cmbMaterial.TabIndex = 42;
            // 
            // txtWeightCrushed
            // 
            this.txtWeightCrushed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightCrushed.Location = new System.Drawing.Point(512, 97);
            this.txtWeightCrushed.Name = "txtWeightCrushed";
            this.txtWeightCrushed.Size = new System.Drawing.Size(276, 29);
            this.txtWeightCrushed.TabIndex = 44;
            // 
            // txtCrushID
            // 
            this.txtCrushID.Location = new System.Drawing.Point(795, 53);
            this.txtCrushID.Name = "txtCrushID";
            this.txtCrushID.ReadOnly = true;
            this.txtCrushID.Size = new System.Drawing.Size(173, 20);
            this.txtCrushID.TabIndex = 45;
            // 
            // qrCodeCrush
            // 
            this.qrCodeCrush.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrCodeCrush.Appearance.Options.UseFont = true;
            this.qrCodeCrush.AutoModule = true;
            this.qrCodeCrush.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrCodeCrush.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrCodeCrush.Location = new System.Drawing.Point(512, 139);
            this.qrCodeCrush.Name = "qrCodeCrush";
            this.qrCodeCrush.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.qrCodeCrush.Size = new System.Drawing.Size(276, 210);
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version3;
            this.qrCodeCrush.Symbology = qrCodeGenerator1;
            this.qrCodeCrush.TabIndex = 25;
            // 
            // txtPosted
            // 
            this.txtPosted.Location = new System.Drawing.Point(795, 80);
            this.txtPosted.Name = "txtPosted";
            this.txtPosted.Size = new System.Drawing.Size(173, 20);
            this.txtPosted.TabIndex = 46;
            // 
            // cmdPost
            // 
            this.cmdPost.Image = global::ScaleApp.Properties.Resources.Mark_32x32;
            this.cmdPost.Location = new System.Drawing.Point(819, 195);
            this.cmdPost.Name = "cmdPost";
            this.cmdPost.Size = new System.Drawing.Size(129, 60);
            this.cmdPost.TabIndex = 47;
            this.cmdPost.UseVisualStyleBackColor = true;
            this.cmdPost.Click += new System.EventHandler(this.cmdPost_Click);
            // 
            // frmCrushing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 686);
            this.Controls.Add(this.cmdPost);
            this.Controls.Add(this.txtPosted);
            this.Controls.Add(this.txtCrushID);
            this.Controls.Add(this.txtWeightCrushed);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbMixId);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbStep);
            this.Controls.Add(this.cmbLostType);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.gridCrushed);
            this.Controls.Add(this.txtCrushDate);
            this.Controls.Add(this.txtNow);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdGetWeight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.qrCodeCrush);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "frmCrushing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crushing Station";
            this.Load += new System.EventHandler(this.frmCrushing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrushed)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdGetWeight;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtNow;
        private System.Windows.Forms.TextBox txtCrushDate;
        private System.Windows.Forms.DataGridView gridCrushed;
        private System.Windows.Forms.ComboBox cmbOperator;
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
    }
}