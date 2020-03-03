namespace ScaleApp
{
    partial class frmMixing
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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator3 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMixing));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeightRM = new System.Windows.Forms.TextBox();
            this.cmbRecycled = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWeightRecycled = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.btnSendToMaterial = new System.Windows.Forms.Button();
            this.txtScaleWeight = new System.Windows.Forms.TextBox();
            this.btnSendToRecycled = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.qrMixLotID = new DevExpress.XtraEditors.BarCodeControl();
            this.cmbLabelType = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMixRawId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperatorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMixBacode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightRecycle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrushRawID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift";
            // 
            // cmbShift
            // 
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbShift.Location = new System.Drawing.Point(111, 12);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(262, 28);
            this.cmbShift.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator";
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(111, 55);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(262, 28);
            this.cmbOperator.TabIndex = 3;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.cmbOperator_SelectedIndexChanged);
            this.cmbOperator.Click += new System.EventHandler(this.cmbOperator_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step";
            // 
            // cmbStep
            // 
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(111, 106);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(262, 28);
            this.cmbStep.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Machine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(414, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Weight";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(526, 12);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(296, 28);
            this.cmbMaterial.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(414, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Material";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(111, 231);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(262, 28);
            this.cmbColor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Product";
            // 
            // txtWeightRM
            // 
            this.txtWeightRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRM.Location = new System.Drawing.Point(526, 55);
            this.txtWeightRM.Name = "txtWeightRM";
            this.txtWeightRM.Size = new System.Drawing.Size(296, 38);
            this.txtWeightRM.TabIndex = 15;
            this.txtWeightRM.TextChanged += new System.EventHandler(this.txtWeightRM_TextChanged);
            // 
            // cmbRecycled
            // 
            this.cmbRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecycled.FormattingEnabled = true;
            this.cmbRecycled.Location = new System.Drawing.Point(526, 108);
            this.cmbRecycled.Name = "cmbRecycled";
            this.cmbRecycled.Size = new System.Drawing.Size(296, 28);
            this.cmbRecycled.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(414, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Recycled ID";
            // 
            // txtWeightRecycled
            // 
            this.txtWeightRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRecycled.Location = new System.Drawing.Point(526, 150);
            this.txtWeightRecycled.Name = "txtWeightRecycled";
            this.txtWeightRecycled.Size = new System.Drawing.Size(296, 38);
            this.txtWeightRecycled.TabIndex = 19;
            this.txtWeightRecycled.TextChanged += new System.EventHandler(this.txtWeightRecycled_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(414, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Weight";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(526, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(296, 38);
            this.txtTotal.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(414, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total";
            // 
            // txtMachine
            // 
            this.txtMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Location = new System.Drawing.Point(112, 150);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(261, 26);
            this.txtMachine.TabIndex = 22;
            // 
            // btnSendToMaterial
            // 
            this.btnSendToMaterial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToMaterial.Location = new System.Drawing.Point(395, 288);
            this.btnSendToMaterial.Name = "btnSendToMaterial";
            this.btnSendToMaterial.Size = new System.Drawing.Size(208, 40);
            this.btnSendToMaterial.TabIndex = 24;
            this.btnSendToMaterial.Text = "Get weight RM";
            this.btnSendToMaterial.UseVisualStyleBackColor = true;
            this.btnSendToMaterial.Click += new System.EventHandler(this.btnSendToMaterial_Click);
            // 
            // txtScaleWeight
            // 
            this.txtScaleWeight.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleWeight.Location = new System.Drawing.Point(16, 288);
            this.txtScaleWeight.Name = "txtScaleWeight";
            this.txtScaleWeight.ReadOnly = true;
            this.txtScaleWeight.Size = new System.Drawing.Size(357, 81);
            this.txtScaleWeight.TabIndex = 25;
            // 
            // btnSendToRecycled
            // 
            this.btnSendToRecycled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToRecycled.Location = new System.Drawing.Point(395, 334);
            this.btnSendToRecycled.Name = "btnSendToRecycled";
            this.btnSendToRecycled.Size = new System.Drawing.Size(208, 40);
            this.btnSendToRecycled.TabIndex = 26;
            this.btnSendToRecycled.Text = "Get weight Recycled";
            this.btnSendToRecycled.UseVisualStyleBackColor = true;
            this.btnSendToRecycled.Click += new System.EventHandler(this.btnSendToRecycled_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(847, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mix Lot ID";
            // 
            // qrMixLotID
            // 
            this.qrMixLotID.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrMixLotID.Appearance.Options.UseFont = true;
            this.qrMixLotID.AutoModule = true;
            this.qrMixLotID.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.Location = new System.Drawing.Point(851, 53);
            this.qrMixLotID.Name = "qrMixLotID";
            this.qrMixLotID.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.qrMixLotID.Size = new System.Drawing.Size(296, 206);
            qrCodeGenerator3.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.qrMixLotID.Symbology = qrCodeGenerator3;
            this.qrMixLotID.TabIndex = 32;
            // 
            // cmbLabelType
            // 
            this.cmbLabelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelType.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabelType.FormattingEnabled = true;
            this.cmbLabelType.Items.AddRange(new object[] {
            "Mixed",
            "Runner",
            "Defect",
            "Black Dot",
            "Contaminated"});
            this.cmbLabelType.Location = new System.Drawing.Point(851, 288);
            this.cmbLabelType.Name = "cmbLabelType";
            this.cmbLabelType.Size = new System.Drawing.Size(191, 37);
            this.cmbLabelType.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.Image = global::ScaleApp.Properties.Resources.Print_32x32;
            this.button5.Location = new System.Drawing.Point(1048, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 40);
            this.button5.TabIndex = 29;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Image = global::ScaleApp.Properties.Resources.Cancel_32x32;
            this.btnReset.Location = new System.Drawing.Point(655, 334);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 40);
            this.btnReset.TabIndex = 28;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ScaleApp.Properties.Resources.Save_32x32;
            this.btnSave.Location = new System.Drawing.Point(655, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 40);
            this.btnSave.TabIndex = 27;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(112, 191);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(261, 28);
            this.cmbProduct.TabIndex = 34;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "sp_getMixRaws";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 389);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1135, 421);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ScaleApp.Properties.Settings.ColorMixConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery3.Name = "sp_getMixRaws";
            storedProcQuery3.StoredProcName = "sp_getMixRaws";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMixRawId,
            this.colShiftName,
            this.colOperatorName,
            this.colStepName,
            this.colProductName,
            this.colColorName,
            this.colMixBacode,
            this.colMaterialName,
            this.colWeightMaterial,
            this.colWeightRecycle,
            this.colTotalMaterial,
            this.colCrushRawID,
            this.colMachineName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMixRawId
            // 
            this.colMixRawId.Caption = "ID";
            this.colMixRawId.FieldName = "MixRawId";
            this.colMixRawId.Name = "colMixRawId";
            this.colMixRawId.Visible = true;
            this.colMixRawId.VisibleIndex = 0;
            this.colMixRawId.Width = 43;
            // 
            // colShiftName
            // 
            this.colShiftName.Caption = "Shift";
            this.colShiftName.FieldName = "ShiftName";
            this.colShiftName.Name = "colShiftName";
            this.colShiftName.Visible = true;
            this.colShiftName.VisibleIndex = 1;
            this.colShiftName.Width = 43;
            // 
            // colOperatorName
            // 
            this.colOperatorName.Caption = "Operator";
            this.colOperatorName.FieldName = "OperatorName";
            this.colOperatorName.Name = "colOperatorName";
            this.colOperatorName.Visible = true;
            this.colOperatorName.VisibleIndex = 3;
            this.colOperatorName.Width = 76;
            // 
            // colStepName
            // 
            this.colStepName.Caption = "Step";
            this.colStepName.FieldName = "StepName";
            this.colStepName.Name = "colStepName";
            this.colStepName.Visible = true;
            this.colStepName.VisibleIndex = 4;
            this.colStepName.Width = 71;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Item";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 5;
            this.colProductName.Width = 166;
            // 
            // colColorName
            // 
            this.colColorName.Caption = "Color";
            this.colColorName.FieldName = "ColorName";
            this.colColorName.Name = "colColorName";
            this.colColorName.Visible = true;
            this.colColorName.VisibleIndex = 6;
            this.colColorName.Width = 138;
            // 
            // colMixBacode
            // 
            this.colMixBacode.Caption = "Mix ID";
            this.colMixBacode.FieldName = "MixBacode";
            this.colMixBacode.Name = "colMixBacode";
            this.colMixBacode.Visible = true;
            this.colMixBacode.VisibleIndex = 2;
            this.colMixBacode.Width = 97;
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "Material";
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 7;
            this.colMaterialName.Width = 177;
            // 
            // colWeightMaterial
            // 
            this.colWeightMaterial.Caption = "Weight";
            this.colWeightMaterial.FieldName = "WeightMaterial";
            this.colWeightMaterial.Name = "colWeightMaterial";
            this.colWeightMaterial.Visible = true;
            this.colWeightMaterial.VisibleIndex = 8;
            this.colWeightMaterial.Width = 67;
            // 
            // colWeightRecycle
            // 
            this.colWeightRecycle.Caption = "Recycled Amount";
            this.colWeightRecycle.FieldName = "WeightRecycle";
            this.colWeightRecycle.Name = "colWeightRecycle";
            this.colWeightRecycle.Visible = true;
            this.colWeightRecycle.VisibleIndex = 9;
            this.colWeightRecycle.Width = 66;
            // 
            // colTotalMaterial
            // 
            this.colTotalMaterial.Caption = "Total";
            this.colTotalMaterial.FieldName = "TotalMaterial";
            this.colTotalMaterial.Name = "colTotalMaterial";
            this.colTotalMaterial.Visible = true;
            this.colTotalMaterial.VisibleIndex = 10;
            this.colTotalMaterial.Width = 54;
            // 
            // colCrushRawID
            // 
            this.colCrushRawID.Caption = "Recyled ID";
            this.colCrushRawID.FieldName = "CrushRawID";
            this.colCrushRawID.Name = "colCrushRawID";
            this.colCrushRawID.Visible = true;
            this.colCrushRawID.VisibleIndex = 12;
            this.colCrushRawID.Width = 52;
            // 
            // colMachineName
            // 
            this.colMachineName.Caption = "Machine";
            this.colMachineName.FieldName = "MachineName";
            this.colMachineName.Name = "colMachineName";
            this.colMachineName.Visible = true;
            this.colMachineName.VisibleIndex = 11;
            this.colMachineName.Width = 60;
            // 
            // frmMixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 822);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbLabelType);
            this.Controls.Add(this.qrMixLotID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSendToRecycled);
            this.Controls.Add(this.txtScaleWeight);
            this.Controls.Add(this.btnSendToMaterial);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtWeightRecycled);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRecycled);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWeightRM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(40, 40);
            this.Name = "frmMixing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mixing Station";
            this.Load += new System.EventHandler(this.frmMixing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWeightRM;
        private System.Windows.Forms.ComboBox cmbRecycled;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWeightRecycled;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Button btnSendToMaterial;
        private System.Windows.Forms.TextBox txtScaleWeight;
        private System.Windows.Forms.Button btnSendToRecycled;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.BarCodeControl qrMixLotID;
        private System.Windows.Forms.ComboBox cmbLabelType;
        private System.Windows.Forms.ComboBox cmbProduct;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMixRawId;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftName;
        private DevExpress.XtraGrid.Columns.GridColumn colOperatorName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colColorName;
        private DevExpress.XtraGrid.Columns.GridColumn colStepName;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightRecycle;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colMachineName;
        private DevExpress.XtraGrid.Columns.GridColumn colMixBacode;
        private DevExpress.XtraGrid.Columns.GridColumn colCrushRawID;
    }
}