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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.mixRawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorMixDataSet = new ScaleApp.ColorMixDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.operatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.stepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeightRM = new System.Windows.Forms.TextBox();
            this.cmbRecycled = new System.Windows.Forms.ComboBox();
            this.recycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.operatorTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.OperatorTableAdapter();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stepTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.StepTableAdapter();
            this.mixRawTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.MixRawTableAdapter();
            this.productTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.ProductTableAdapter();
            this.colorTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.ColorTableAdapter();
            this.materialsTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.MaterialsTableAdapter();
            this.recycleTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.RecycleTableAdapter();
            this.productColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productColorTableAdapter = new ScaleApp.ColorMixDataSetTableAdapters.ProductColorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mixRawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorBindingSource)).BeginInit();
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
            this.cmbShift.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mixRawBindingSource, "ShiftName", true));
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // mixRawBindingSource
            // 
            this.mixRawBindingSource.DataMember = "MixRaw";
            this.mixRawBindingSource.DataSource = this.colorMixDataSet;
            // 
            // colorMixDataSet
            // 
            this.colorMixDataSet.DataSetName = "ColorMixDataSet";
            this.colorMixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmbOperator.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operatorBindingSource, "OperatorCode", true));
            this.cmbOperator.DataSource = this.operatorBindingSource;
            this.cmbOperator.DisplayMember = "OperatorName";
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(111, 55);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(262, 28);
            this.cmbOperator.TabIndex = 3;
            this.cmbOperator.ValueMember = "OperatorCode";
            // 
            // operatorBindingSource
            // 
            this.operatorBindingSource.DataMember = "Operator";
            this.operatorBindingSource.DataSource = this.colorMixDataSet;
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
            this.cmbStep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mixRawBindingSource, "StepName", true));
            this.cmbStep.DataSource = this.stepBindingSource;
            this.cmbStep.DisplayMember = "StepName";
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(111, 106);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(262, 28);
            this.cmbStep.TabIndex = 5;
            this.cmbStep.ValueMember = "StepCode";
            // 
            // stepBindingSource
            // 
            this.stepBindingSource.DataMember = "Step";
            this.stepBindingSource.DataSource = this.colorMixDataSet;
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
            this.cmbMaterial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mixRawBindingSource, "MaterialName", true));
            this.cmbMaterial.DataSource = this.materialsBindingSource;
            this.cmbMaterial.DisplayMember = "MaterialName";
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(526, 12);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(296, 28);
            this.cmbMaterial.TabIndex = 13;
            this.cmbMaterial.ValueMember = "MaterialCode";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.colorMixDataSet;
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
            this.cmbColor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mixRawBindingSource, "ColorName", true));
            this.cmbColor.DataSource = this.colorBindingSource;
            this.cmbColor.DisplayMember = "ColorName";
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(111, 231);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(262, 28);
            this.cmbColor.TabIndex = 11;
            this.cmbColor.ValueMember = "ColorName";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.colorMixDataSet;
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
            this.txtWeightRM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mixRawBindingSource, "WeightMaterial", true));
            this.txtWeightRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRM.Location = new System.Drawing.Point(526, 55);
            this.txtWeightRM.Name = "txtWeightRM";
            this.txtWeightRM.Size = new System.Drawing.Size(296, 38);
            this.txtWeightRM.TabIndex = 15;
            // 
            // cmbRecycled
            // 
            this.cmbRecycled.DataSource = this.recycleBindingSource;
            this.cmbRecycled.DisplayMember = "RecycleCode";
            this.cmbRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecycled.FormattingEnabled = true;
            this.cmbRecycled.Location = new System.Drawing.Point(526, 108);
            this.cmbRecycled.Name = "cmbRecycled";
            this.cmbRecycled.Size = new System.Drawing.Size(296, 28);
            this.cmbRecycled.TabIndex = 17;
            this.cmbRecycled.ValueMember = "RecycleCode";
            // 
            // recycleBindingSource
            // 
            this.recycleBindingSource.DataMember = "Recycle";
            this.recycleBindingSource.DataSource = this.colorMixDataSet;
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
            this.txtWeightRecycled.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mixRawBindingSource, "WeightRecycle", true));
            this.txtWeightRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRecycled.Location = new System.Drawing.Point(526, 150);
            this.txtWeightRecycled.Name = "txtWeightRecycled";
            this.txtWeightRecycled.Size = new System.Drawing.Size(296, 38);
            this.txtWeightRecycled.TabIndex = 19;
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
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mixRawBindingSource, "TotalMaterial", true));
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
            this.txtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mixRawBindingSource, "MachineName", true));
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
            this.qrMixLotID.DataBindings.Add(new System.Windows.Forms.Binding("BinaryData", this.mixRawBindingSource, "MixBacode", true));
            this.qrMixLotID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mixRawBindingSource, "MixBacode", true));
            this.qrMixLotID.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.Location = new System.Drawing.Point(851, 53);
            this.qrMixLotID.Name = "qrMixLotID";
            this.qrMixLotID.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.qrMixLotID.Size = new System.Drawing.Size(296, 206);
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version3;
            this.qrMixLotID.Symbology = qrCodeGenerator2;
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
            // 
            // operatorTableAdapter
            // 
            this.operatorTableAdapter.ClearBeforeFill = true;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mixRawBindingSource, "ProductName", true));
            this.cmbProduct.DataSource = this.productBindingSource;
            this.cmbProduct.DisplayMember = "ProductName";
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(112, 191);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(261, 28);
            this.cmbProduct.TabIndex = 34;
            this.cmbProduct.ValueMember = "ProductCode";
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.colorMixDataSet;
            // 
            // stepTableAdapter
            // 
            this.stepTableAdapter.ClearBeforeFill = true;
            // 
            // mixRawTableAdapter
            // 
            this.mixRawTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // recycleTableAdapter
            // 
            this.recycleTableAdapter.ClearBeforeFill = true;
            // 
            // productColorBindingSource
            // 
            this.productColorBindingSource.DataMember = "ProductColor";
            this.productColorBindingSource.DataSource = this.colorMixDataSet;
            // 
            // productColorTableAdapter
            // 
            this.productColorTableAdapter.ClearBeforeFill = true;
            // 
            // frmMixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 749);
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
            ((System.ComponentModel.ISupportInitialize)(this.mixRawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorBindingSource)).EndInit();
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
        private ColorMixDataSet colorMixDataSet;
        private System.Windows.Forms.BindingSource operatorBindingSource;
        private ColorMixDataSetTableAdapters.OperatorTableAdapter operatorTableAdapter;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.BindingSource stepBindingSource;
        private ColorMixDataSetTableAdapters.StepTableAdapter stepTableAdapter;
        private System.Windows.Forms.BindingSource mixRawBindingSource;
        private ColorMixDataSetTableAdapters.MixRawTableAdapter mixRawTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ColorMixDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private ColorMixDataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private ColorMixDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource recycleBindingSource;
        private ColorMixDataSetTableAdapters.RecycleTableAdapter recycleTableAdapter;
        private System.Windows.Forms.BindingSource productColorBindingSource;
        private ColorMixDataSetTableAdapters.ProductColorTableAdapter productColorTableAdapter;
    }
}