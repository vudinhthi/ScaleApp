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
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new System.Windows.Forms.DataGridView();
            this.MixID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MixDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MixLotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReLotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WRaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMixID = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.txtMixDate = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdPost = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPosted = new System.Windows.Forms.TextBox();
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
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
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
            this.btnSendToMaterial.Location = new System.Drawing.Point(379, 288);
            this.btnSendToMaterial.Name = "btnSendToMaterial";
            this.btnSendToMaterial.Size = new System.Drawing.Size(206, 40);
            this.btnSendToMaterial.TabIndex = 24;
            this.btnSendToMaterial.Text = "Get weight RM";
            this.btnSendToMaterial.UseVisualStyleBackColor = true;
            this.btnSendToMaterial.Click += new System.EventHandler(this.btnSendToMaterial_Click);
            // 
            // txtScaleWeight
            // 
            this.txtScaleWeight.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtScaleWeight.Location = new System.Drawing.Point(16, 288);
            this.txtScaleWeight.Name = "txtScaleWeight";
            this.txtScaleWeight.ReadOnly = true;
            this.txtScaleWeight.Size = new System.Drawing.Size(357, 81);
            this.txtScaleWeight.TabIndex = 25;
            this.txtScaleWeight.Text = "25";
            this.txtScaleWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendToRecycled
            // 
            this.btnSendToRecycled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToRecycled.Location = new System.Drawing.Point(379, 329);
            this.btnSendToRecycled.Name = "btnSendToRecycled";
            this.btnSendToRecycled.Size = new System.Drawing.Size(206, 40);
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
            this.label12.Location = new System.Drawing.Point(847, 9);
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
            this.qrMixLotID.Size = new System.Drawing.Size(296, 172);
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
            "BlackDot",
            "Contaminated"});
            this.cmbLabelType.Location = new System.Drawing.Point(851, 288);
            this.cmbLabelType.Name = "cmbLabelType";
            this.cmbLabelType.Size = new System.Drawing.Size(191, 37);
            this.cmbLabelType.TabIndex = 33;
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(112, 191);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(261, 28);
            this.cmbProduct.TabIndex = 34;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
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
            this.gridView1.AllowUserToAddRows = false;
            this.gridView1.AllowUserToDeleteRows = false;
            this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MixID,
            this.MixDate,
            this.MixLotID,
            this.ReLotID,
            this.Shift,
            this.Operator,
            this.Item,
            this.Material,
            this.Color,
            this.Step,
            this.WRaw,
            this.WRe,
            this.Total,
            this.Machine,
            this.Posted});
            this.gridView1.Location = new System.Drawing.Point(16, 385);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.Size = new System.Drawing.Size(1131, 414);
            this.gridView1.TabIndex = 35;
            this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
            // 
            // MixID
            // 
            this.MixID.HeaderText = "ID";
            this.MixID.Name = "MixID";
            this.MixID.ReadOnly = true;
            this.MixID.Width = 40;
            // 
            // MixDate
            // 
            this.MixDate.HeaderText = "Date";
            this.MixDate.Name = "MixDate";
            this.MixDate.ReadOnly = true;
            this.MixDate.Width = 80;
            // 
            // MixLotID
            // 
            this.MixLotID.HeaderText = "Mix Lot ID";
            this.MixLotID.Name = "MixLotID";
            this.MixLotID.ReadOnly = true;
            // 
            // ReLotID
            // 
            this.ReLotID.HeaderText = "Recycled Lot";
            this.ReLotID.Name = "ReLotID";
            this.ReLotID.ReadOnly = true;
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
            // WRaw
            // 
            this.WRaw.HeaderText = "Weight Raw";
            this.WRaw.Name = "WRaw";
            this.WRaw.ReadOnly = true;
            // 
            // WRe
            // 
            this.WRe.HeaderText = "Weight Recycled";
            this.WRe.Name = "WRe";
            this.WRe.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
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
            // txtMixID
            // 
            this.txtMixID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMixID.Location = new System.Drawing.Point(851, 334);
            this.txtMixID.Name = "txtMixID";
            this.txtMixID.ReadOnly = true;
            this.txtMixID.Size = new System.Drawing.Size(64, 29);
            this.txtMixID.TabIndex = 36;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateTime.Location = new System.Drawing.Point(943, 10);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(2, 24);
            this.lblDateTime.TabIndex = 37;
            // 
            // txtMixDate
            // 
            this.txtMixDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMixDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMixDate.Location = new System.Drawing.Point(851, 231);
            this.txtMixDate.Name = "txtMixDate";
            this.txtMixDate.Size = new System.Drawing.Size(296, 29);
            this.txtMixDate.TabIndex = 38;
            this.txtMixDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cmdPost
            // 
            this.cmdPost.Enabled = false;
            this.cmdPost.Image = global::ScaleApp.Properties.Resources.Mark_32x32;
            this.cmdPost.Location = new System.Drawing.Point(668, 288);
            this.cmdPost.Name = "cmdPost";
            this.cmdPost.Size = new System.Drawing.Size(74, 81);
            this.cmdPost.TabIndex = 39;
            this.cmdPost.UseVisualStyleBackColor = true;
            this.cmdPost.Click += new System.EventHandler(this.cmdPost_Click);
            // 
            // button5
            // 
            this.button5.Image = global::ScaleApp.Properties.Resources.Print_32x32;
            this.button5.Location = new System.Drawing.Point(1048, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 40);
            this.button5.TabIndex = 29;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::ScaleApp.Properties.Resources.Cancel_32x32;
            this.btnReset.Location = new System.Drawing.Point(748, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 80);
            this.btnReset.TabIndex = 28;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ScaleApp.Properties.Resources.Save_32x32;
            this.btnSave.Location = new System.Drawing.Point(591, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 80);
            this.btnSave.TabIndex = 27;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPosted
            // 
            this.txtPosted.Location = new System.Drawing.Point(921, 334);
            this.txtPosted.Name = "txtPosted";
            this.txtPosted.Size = new System.Drawing.Size(100, 20);
            this.txtPosted.TabIndex = 40;
            // 
            // frmMixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 822);
            this.Controls.Add(this.txtPosted);
            this.Controls.Add(this.cmdPost);
            this.Controls.Add(this.txtMixDate);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.txtMixID);
            this.Controls.Add(this.gridView1);
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
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.DataGridView gridView1;
        private System.Windows.Forms.TextBox txtMixID;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtMixDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cmdPost;
        private System.Windows.Forms.TextBox txtPosted;
        private System.Windows.Forms.DataGridViewTextBoxColumn MixID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MixDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MixLotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReLotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn WRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn WRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posted;
    }
}