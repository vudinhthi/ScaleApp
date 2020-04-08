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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMixing));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeightRM = new System.Windows.Forms.TextBox();
            this.cmbRecycled = new System.Windows.Forms.ComboBox();
            this.txtWeightRecycled = new System.Windows.Forms.TextBox();
            this.txtScaleWeight = new System.Windows.Forms.TextBox();
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
            this.txtPosted = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lueMaterial = new DevExpress.XtraEditors.LookUpEdit();
            this.lueProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtWeightMaterial = new DevExpress.XtraEditors.TextEdit();
            this.txtWeightRe = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.spbExport = new DevExpress.XtraEditors.SimpleButton();
            this.spbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtMachine = new DevExpress.XtraEditors.TextEdit();
            this.lueOperator = new DevExpress.XtraEditors.LookUpEdit();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.tedColorCode = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.tedColor = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.spbReset = new DevExpress.XtraEditors.SimpleButton();
            this.spbPost = new DevExpress.XtraEditors.SimpleButton();
            this.spbSave = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.lueColor = new DevExpress.XtraEditors.LookUpEdit();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.spbScale = new DevExpress.XtraEditors.SimpleButton();
            this.lueRecycled = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bteWeightRe = new DevExpress.XtraEditors.ButtonEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bteWeightRM = new DevExpress.XtraEditors.ButtonEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialBom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtReRatio = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalMaterial = new DevExpress.XtraEditors.TextEdit();
            this.txtReason = new DevExpress.XtraEditors.ButtonEdit();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRecycled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReRatio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift";
            // 
            // cmbShift
            // 
            this.tablePanel1.SetColumn(this.cmbShift, 1);
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbShift.Location = new System.Drawing.Point(116, 3);
            this.cmbShift.Name = "cmbShift";
            this.tablePanel1.SetRow(this.cmbShift, 0);
            this.cmbShift.Size = new System.Drawing.Size(285, 28);
            this.cmbShift.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator";
            // 
            // cmbOperator
            // 
            this.tablePanel1.SetColumn(this.cmbOperator, 1);
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(116, 38);
            this.cmbOperator.Name = "cmbOperator";
            this.tablePanel1.SetRow(this.cmbOperator, 1);
            this.cmbOperator.Size = new System.Drawing.Size(285, 28);
            this.cmbOperator.TabIndex = 3;
            this.cmbOperator.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 0);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step";
            // 
            // cmbStep
            // 
            this.tablePanel1.SetColumn(this.cmbStep, 1);
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(116, 73);
            this.cmbStep.Name = "cmbStep";
            this.tablePanel1.SetRow(this.cmbStep, 2);
            this.cmbStep.Size = new System.Drawing.Size(285, 28);
            this.cmbStep.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tablePanel1.SetColumn(this.label4, 0);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 3);
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Machine";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(526, 15);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(40, 28);
            this.cmbMaterial.TabIndex = 13;
            this.cmbMaterial.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(15, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Material (*)";
            this.label6.Visible = false;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(91, 223);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(33, 28);
            this.cmbColor.TabIndex = 11;
            this.cmbColor.Visible = false;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tablePanel2.SetColumn(this.label7, 0);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(3, 123);
            this.label7.Name = "label7";
            this.tablePanel2.SetRow(this.label7, 2);
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Color code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tablePanel2.SetColumn(this.label8, 0);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.tablePanel2.SetRow(this.label8, 0);
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Product (*)";
            // 
            // txtWeightRM
            // 
            this.txtWeightRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRM.Location = new System.Drawing.Point(526, 55);
            this.txtWeightRM.Name = "txtWeightRM";
            this.txtWeightRM.Size = new System.Drawing.Size(40, 29);
            this.txtWeightRM.TabIndex = 15;
            this.txtWeightRM.Visible = false;
            this.txtWeightRM.TextChanged += new System.EventHandler(this.txtWeightRM_TextChanged);
            // 
            // cmbRecycled
            // 
            this.cmbRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecycled.FormattingEnabled = true;
            this.cmbRecycled.Location = new System.Drawing.Point(526, 108);
            this.cmbRecycled.Name = "cmbRecycled";
            this.cmbRecycled.Size = new System.Drawing.Size(40, 28);
            this.cmbRecycled.TabIndex = 17;
            this.cmbRecycled.Visible = false;
            // 
            // txtWeightRecycled
            // 
            this.txtWeightRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRecycled.Location = new System.Drawing.Point(526, 150);
            this.txtWeightRecycled.Name = "txtWeightRecycled";
            this.txtWeightRecycled.Size = new System.Drawing.Size(40, 29);
            this.txtWeightRecycled.TabIndex = 19;
            this.txtWeightRecycled.Visible = false;
            this.txtWeightRecycled.TextChanged += new System.EventHandler(this.txtWeightRecycled_TextChanged);
            // 
            // txtScaleWeight
            // 
            this.txtScaleWeight.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtScaleWeight.Location = new System.Drawing.Point(9, 349);
            this.txtScaleWeight.Name = "txtScaleWeight";
            this.txtScaleWeight.Size = new System.Drawing.Size(312, 81);
            this.txtScaleWeight.TabIndex = 25;
            this.txtScaleWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qrMixLotID
            // 
            this.qrMixLotID.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrMixLotID.Appearance.Options.UseFont = true;
            this.qrMixLotID.AutoModule = true;
            this.tablePanel5.SetColumn(this.qrMixLotID, 0);
            this.tablePanel5.SetColumnSpan(this.qrMixLotID, 2);
            this.qrMixLotID.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.Location = new System.Drawing.Point(3, 48);
            this.qrMixLotID.Name = "qrMixLotID";
            this.qrMixLotID.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.tablePanel5.SetRow(this.qrMixLotID, 1);
            this.qrMixLotID.Size = new System.Drawing.Size(398, 169);
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.qrMixLotID.Symbology = qrCodeGenerator1;
            this.qrMixLotID.TabIndex = 32;
            // 
            // cmbLabelType
            // 
            this.tablePanel6.SetColumn(this.cmbLabelType, 0);
            this.cmbLabelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabelType.FormattingEnabled = true;
            this.cmbLabelType.Items.AddRange(new object[] {
            "Mixed",
            "Runner",
            "Defect",
            "BlackDot",
            "Contaminated"});
            this.cmbLabelType.Location = new System.Drawing.Point(3, 11);
            this.cmbLabelType.Name = "cmbLabelType";
            this.tablePanel6.SetRow(this.cmbLabelType, 0);
            this.cmbLabelType.Size = new System.Drawing.Size(305, 31);
            this.cmbLabelType.TabIndex = 0;
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(112, 191);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(32, 28);
            this.cmbProduct.TabIndex = 34;
            this.cmbProduct.Visible = false;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ScaleApp.Properties.Settings.ColorMixConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sp_getMixRaws";
            storedProcQuery1.StoredProcName = "sp_getMixRaws";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
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
            this.gridView1.Location = new System.Drawing.Point(15, 520);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.Size = new System.Drawing.Size(1131, 102);
            this.gridView1.TabIndex = 35;
            this.gridView1.Visible = false;
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
            this.txtMixID.Location = new System.Drawing.Point(1059, 339);
            this.txtMixID.Name = "txtMixID";
            this.txtMixID.ReadOnly = true;
            this.txtMixID.Size = new System.Drawing.Size(64, 29);
            this.txtMixID.TabIndex = 36;
            this.txtMixID.Visible = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel5.SetColumn(this.lblDateTime, 0);
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateTime.Location = new System.Drawing.Point(3, 5);
            this.lblDateTime.Name = "lblDateTime";
            this.tablePanel5.SetRow(this.lblDateTime, 0);
            this.lblDateTime.Size = new System.Drawing.Size(130, 24);
            this.lblDateTime.TabIndex = 37;
            this.lblDateTime.Text = "Current Date";
            // 
            // txtMixDate
            // 
            this.tablePanel5.SetColumn(this.txtMixDate, 0);
            this.tablePanel5.SetColumnSpan(this.txtMixDate, 2);
            this.txtMixDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMixDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMixDate.Location = new System.Drawing.Point(3, 235);
            this.txtMixDate.Name = "txtMixDate";
            this.txtMixDate.ReadOnly = true;
            this.tablePanel5.SetRow(this.txtMixDate, 2);
            this.txtMixDate.Size = new System.Drawing.Size(398, 29);
            this.txtMixDate.TabIndex = 38;
            this.txtMixDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtPosted
            // 
            this.txtPosted.Location = new System.Drawing.Point(1129, 339);
            this.txtPosted.Name = "txtPosted";
            this.txtPosted.Size = new System.Drawing.Size(100, 20);
            this.txtPosted.TabIndex = 40;
            this.txtPosted.Visible = false;
            // 
            // button5
            // 
            this.tablePanel6.SetColumn(this.button5, 1);
            this.button5.Image = global::ScaleApp.Properties.Resources.Print_32x32;
            this.button5.Location = new System.Drawing.Point(314, 7);
            this.button5.Name = "button5";
            this.tablePanel6.SetRow(this.button5, 0);
            this.button5.Size = new System.Drawing.Size(87, 38);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lueMaterial
            // 
            this.lueMaterial.Location = new System.Drawing.Point(128, 241);
            this.lueMaterial.Name = "lueMaterial";
            this.lueMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMaterial.Properties.Appearance.Options.UseFont = true;
            this.lueMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaterial.Properties.NullText = "";
            this.lueMaterial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMaterial.Size = new System.Drawing.Size(285, 26);
            this.lueMaterial.TabIndex = 41;
            this.lueMaterial.Visible = false;
            // 
            // lueProduct
            // 
            this.tablePanel2.SetColumn(this.lueProduct, 1);
            this.lueProduct.Location = new System.Drawing.Point(117, 3);
            this.lueProduct.Name = "lueProduct";
            this.lueProduct.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueProduct.Properties.Appearance.Options.UseFont = true;
            this.lueProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProduct.Properties.NullText = "";
            this.lueProduct.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueProduct.Properties.PopupFormMinSize = new System.Drawing.Size(580, 0);
            this.lueProduct.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.tablePanel2.SetRow(this.lueProduct, 0);
            this.lueProduct.Size = new System.Drawing.Size(287, 25);
            this.lueProduct.TabIndex = 0;
            this.lueProduct.EditValueChanged += new System.EventHandler(this.lueProduct_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(9, 436);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1563, 374);
            this.gridControl1.TabIndex = 45;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // txtWeightMaterial
            // 
            this.txtWeightMaterial.Location = new System.Drawing.Point(526, 55);
            this.txtWeightMaterial.Name = "txtWeightMaterial";
            this.txtWeightMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightMaterial.Properties.Appearance.Options.UseFont = true;
            this.txtWeightMaterial.Properties.Mask.EditMask = "n";
            this.txtWeightMaterial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeightMaterial.Size = new System.Drawing.Size(40, 30);
            this.txtWeightMaterial.TabIndex = 46;
            // 
            // txtWeightRe
            // 
            this.txtWeightRe.Location = new System.Drawing.Point(526, 150);
            this.txtWeightRe.Name = "txtWeightRe";
            this.txtWeightRe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRe.Properties.Appearance.Options.UseFont = true;
            this.txtWeightRe.Properties.Mask.EditMask = "n";
            this.txtWeightRe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeightRe.Size = new System.Drawing.Size(40, 26);
            this.txtWeightRe.TabIndex = 47;
            this.txtWeightRe.Visible = false;
            // 
            // spbExport
            // 
            this.tablePanel4.SetColumn(this.spbExport, 3);
            this.spbExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbExport.ImageOptions.Image")));
            this.spbExport.Location = new System.Drawing.Point(232, 3);
            this.spbExport.Name = "spbExport";
            this.tablePanel4.SetRow(this.spbExport, 0);
            this.spbExport.Size = new System.Drawing.Size(81, 76);
            this.spbExport.TabIndex = 3;
            this.spbExport.Text = "Export";
            this.spbExport.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spbRefresh
            // 
            this.tablePanel4.SetColumn(this.spbRefresh, 4);
            this.spbRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbRefresh.ImageOptions.Image")));
            this.spbRefresh.Location = new System.Drawing.Point(320, 3);
            this.spbRefresh.Name = "spbRefresh";
            this.tablePanel4.SetRow(this.spbRefresh, 0);
            this.spbRefresh.Size = new System.Drawing.Size(81, 76);
            this.spbRefresh.TabIndex = 4;
            this.spbRefresh.Text = "Refresh";
            this.spbRefresh.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 16.75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.25F)});
            this.tablePanel1.Controls.Add(this.txtMachine);
            this.tablePanel1.Controls.Add(this.lueOperator);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.cmbShift);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.cmbOperator);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.cmbStep);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Location = new System.Drawing.Point(12, 15);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F)});
            this.tablePanel1.Size = new System.Drawing.Size(404, 135);
            this.tablePanel1.TabIndex = 55;
            // 
            // txtMachine
            // 
            this.tablePanel1.SetColumn(this.txtMachine, 1);
            this.txtMachine.Location = new System.Drawing.Point(116, 108);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Properties.Appearance.Options.UseFont = true;
            this.tablePanel1.SetRow(this.txtMachine, 3);
            this.txtMachine.Size = new System.Drawing.Size(285, 24);
            this.txtMachine.TabIndex = 6;
            // 
            // lueOperator
            // 
            this.lueOperator.Location = new System.Drawing.Point(116, 43);
            this.lueOperator.Name = "lueOperator";
            this.lueOperator.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueOperator.Properties.Appearance.Options.UseFont = true;
            this.lueOperator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOperator.Properties.NullText = "";
            this.lueOperator.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueOperator.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.lueOperator.Size = new System.Drawing.Size(285, 26);
            this.lueOperator.TabIndex = 4;
            // 
            // tablePanel2
            // 
            this.tablePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 16.74F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.26F)});
            this.tablePanel2.Controls.Add(this.txtProductName);
            this.tablePanel2.Controls.Add(this.tedColorCode);
            this.tablePanel2.Controls.Add(this.label12);
            this.tablePanel2.Controls.Add(this.tedColor);
            this.tablePanel2.Controls.Add(this.label8);
            this.tablePanel2.Controls.Add(this.label7);
            this.tablePanel2.Controls.Add(this.lueProduct);
            this.tablePanel2.Location = new System.Drawing.Point(9, 164);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 31F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 87F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(407, 179);
            this.tablePanel2.TabIndex = 56;
            // 
            // txtProductName
            // 
            this.tablePanel2.SetColumn(this.txtProductName, 1);
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(117, 35);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.tablePanel2.SetRow(this.txtProductName, 1);
            this.txtProductName.Size = new System.Drawing.Size(287, 79);
            this.txtProductName.TabIndex = 64;
            // 
            // tedColorCode
            // 
            this.tablePanel2.SetColumn(this.tedColorCode, 1);
            this.tedColorCode.Location = new System.Drawing.Point(117, 121);
            this.tedColorCode.Name = "tedColorCode";
            this.tedColorCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedColorCode.Properties.Appearance.Options.UseFont = true;
            this.tedColorCode.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.tedColorCode, 2);
            this.tedColorCode.Size = new System.Drawing.Size(287, 24);
            this.tedColorCode.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tablePanel2.SetColumn(this.label12, 0);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(3, 153);
            this.label12.Name = "label12";
            this.tablePanel2.SetRow(this.label12, 3);
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "Color name";
            // 
            // tedColor
            // 
            this.tablePanel2.SetColumn(this.tedColor, 1);
            this.tedColor.Location = new System.Drawing.Point(117, 151);
            this.tedColor.Name = "tedColor";
            this.tedColor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedColor.Properties.Appearance.Options.UseFont = true;
            this.tedColor.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.tedColor, 3);
            this.tedColor.Size = new System.Drawing.Size(287, 25);
            this.tedColor.TabIndex = 62;
            // 
            // tablePanel4
            // 
            this.tablePanel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 140F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 140F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 140F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 160F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 160F)});
            this.tablePanel4.Controls.Add(this.spbReset);
            this.tablePanel4.Controls.Add(this.spbPost);
            this.tablePanel4.Controls.Add(this.spbSave);
            this.tablePanel4.Controls.Add(this.spbExport);
            this.tablePanel4.Controls.Add(this.spbRefresh);
            this.tablePanel4.Location = new System.Drawing.Point(918, 287);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(404, 82);
            this.tablePanel4.TabIndex = 58;
            // 
            // spbReset
            // 
            this.tablePanel4.SetColumn(this.spbReset, 2);
            this.spbReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbReset.ImageOptions.Image")));
            this.spbReset.Location = new System.Drawing.Point(156, 3);
            this.spbReset.Name = "spbReset";
            this.tablePanel4.SetRow(this.spbReset, 0);
            this.spbReset.Size = new System.Drawing.Size(70, 76);
            this.spbReset.TabIndex = 2;
            this.spbReset.Text = "Reset";
            this.spbReset.Click += new System.EventHandler(this.spbReset_Click);
            // 
            // spbPost
            // 
            this.tablePanel4.SetColumn(this.spbPost, 1);
            this.spbPost.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbPost.ImageOptions.Image")));
            this.spbPost.Location = new System.Drawing.Point(79, 3);
            this.spbPost.Name = "spbPost";
            this.tablePanel4.SetRow(this.spbPost, 0);
            this.spbPost.Size = new System.Drawing.Size(70, 76);
            this.spbPost.TabIndex = 1;
            this.spbPost.Text = "Post";
            this.spbPost.Click += new System.EventHandler(this.spbPost_Click);
            // 
            // spbSave
            // 
            this.tablePanel4.SetColumn(this.spbSave, 0);
            this.spbSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbSave.ImageOptions.Image")));
            this.spbSave.Location = new System.Drawing.Point(3, 3);
            this.spbSave.Name = "spbSave";
            this.tablePanel4.SetRow(this.spbSave, 0);
            this.spbSave.Size = new System.Drawing.Size(70, 76);
            this.spbSave.TabIndex = 0;
            this.spbSave.Text = "Save";
            this.spbSave.Click += new System.EventHandler(this.spbSave_Click);
            // 
            // tablePanel5
            // 
            this.tablePanel5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27.54F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27.46F)});
            this.tablePanel5.Controls.Add(this.cboComPort);
            this.tablePanel5.Controls.Add(this.lblDateTime);
            this.tablePanel5.Controls.Add(this.qrMixLotID);
            this.tablePanel5.Controls.Add(this.txtMixDate);
            this.tablePanel5.Location = new System.Drawing.Point(918, 14);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 34F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 198F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 29F)});
            this.tablePanel5.Size = new System.Drawing.Size(404, 267);
            this.tablePanel5.TabIndex = 59;
            // 
            // cboComPort
            // 
            this.tablePanel5.SetColumn(this.cboComPort, 1);
            this.cboComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(205, 4);
            this.cboComPort.Name = "cboComPort";
            this.tablePanel5.SetRow(this.cboComPort, 0);
            this.cboComPort.Size = new System.Drawing.Size(196, 26);
            this.cboComPort.TabIndex = 39;
            // 
            // tablePanel6
            // 
            this.tablePanel6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.28F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.72F)});
            this.tablePanel6.Controls.Add(this.cmbLabelType);
            this.tablePanel6.Controls.Add(this.button5);
            this.tablePanel6.Location = new System.Drawing.Point(918, 377);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel6.Size = new System.Drawing.Size(404, 53);
            this.tablePanel6.TabIndex = 60;
            // 
            // lueColor
            // 
            this.lueColor.Location = new System.Drawing.Point(928, 404);
            this.lueColor.Name = "lueColor";
            this.lueColor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueColor.Properties.Appearance.Options.UseFont = true;
            this.lueColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lueColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueColor.Properties.NullText = "";
            this.lueColor.Size = new System.Drawing.Size(285, 26);
            this.lueColor.TabIndex = 43;
            this.lueColor.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            // 
            // spbScale
            // 
            this.spbScale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbScale.ImageOptions.Image")));
            this.spbScale.Location = new System.Drawing.Point(327, 349);
            this.spbScale.Name = "spbScale";
            this.spbScale.Size = new System.Drawing.Size(89, 81);
            this.spbScale.TabIndex = 63;
            this.spbScale.Text = "Scale";
            this.spbScale.Click += new System.EventHandler(this.spbScale_Click);
            // 
            // lueRecycled
            // 
            this.lueRecycled.Location = new System.Drawing.Point(93, 271);
            this.lueRecycled.Name = "lueRecycled";
            this.lueRecycled.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueRecycled.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRecycled.Properties.Appearance.Options.UseFont = true;
            this.lueRecycled.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRecycled.Properties.NullText = "";
            this.lueRecycled.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueRecycled.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lueRecycled.Size = new System.Drawing.Size(394, 26);
            this.lueRecycled.TabIndex = 1;
            this.lueRecycled.EditValueChanged += new System.EventHandler(this.lueRecycled_EditValueChanged);
            // 
            // txtTotal
            // 
            this.tablePanel3.SetColumn(this.txtTotal, 1);
            this.tablePanel3.SetColumnSpan(this.txtTotal, 2);
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(93, 374);
            this.txtTotal.Name = "txtTotal";
            this.tablePanel3.SetRow(this.txtTotal, 5);
            this.txtTotal.Size = new System.Drawing.Size(394, 38);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.tablePanel3.SetColumn(this.label11, 0);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(3, 383);
            this.label11.Name = "label11";
            this.tablePanel3.SetRow(this.label11, 5);
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tablePanel3.SetColumn(this.label10, 0);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(3, 309);
            this.label10.Name = "label10";
            this.tablePanel3.SetRow(this.label10, 3);
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Weight";
            // 
            // bteWeightRe
            // 
            this.tablePanel3.SetColumn(this.bteWeightRe, 1);
            this.bteWeightRe.Location = new System.Drawing.Point(93, 304);
            this.bteWeightRe.Name = "bteWeightRe";
            this.bteWeightRe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteWeightRe.Properties.Appearance.Options.UseFont = true;
            this.bteWeightRe.Properties.Appearance.Options.UseTextOptions = true;
            this.bteWeightRe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bteWeightRe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.bteWeightRe.Properties.Mask.EditMask = "f";
            this.bteWeightRe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bteWeightRe.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.bteWeightRe, 3);
            this.bteWeightRe.Size = new System.Drawing.Size(246, 30);
            this.bteWeightRe.TabIndex = 2;
            this.bteWeightRe.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteWeightRe_ButtonClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tablePanel3.SetColumn(this.label9, 0);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 274);
            this.label9.Name = "label9";
            this.tablePanel3.SetRow(this.label9, 2);
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Recycled ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tablePanel3.SetColumn(this.label5, 0);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.tablePanel3.SetRow(this.label5, 0);
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Weight (*)";
            // 
            // bteWeightRM
            // 
            this.tablePanel3.SetColumn(this.bteWeightRM, 1);
            this.bteWeightRM.Location = new System.Drawing.Point(93, 3);
            this.bteWeightRM.Name = "bteWeightRM";
            this.bteWeightRM.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteWeightRM.Properties.Appearance.Options.UseFont = true;
            this.bteWeightRM.Properties.Appearance.Options.UseTextOptions = true;
            this.bteWeightRM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.bteWeightRM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Ok", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Delete", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.bteWeightRM.Properties.Mask.EditMask = "f";
            this.bteWeightRM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bteWeightRM.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.bteWeightRM, 0);
            this.bteWeightRM.Size = new System.Drawing.Size(246, 32);
            this.bteWeightRM.TabIndex = 0;
            this.bteWeightRM.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteWeightRM_ButtonClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.tablePanel3.SetColumn(this.label13, 0);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(3, 344);
            this.label13.Name = "label13";
            this.tablePanel3.SetRow(this.label13, 4);
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "Resason";
            // 
            // gridControl2
            // 
            this.tablePanel3.SetColumn(this.gridControl2, 1);
            this.tablePanel3.SetColumnSpan(this.gridControl2, 2);
            this.gridControl2.Location = new System.Drawing.Point(93, 41);
            this.gridControl2.MainView = this.gridViewMaterialBom;
            this.gridControl2.Name = "gridControl2";
            this.tablePanel3.SetRow(this.gridControl2, 1);
            this.gridControl2.Size = new System.Drawing.Size(394, 224);
            this.gridControl2.TabIndex = 58;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialBom,
            this.gridView3});
            // 
            // gridViewMaterialBom
            // 
            this.gridViewMaterialBom.GridControl = this.gridControl2;
            this.gridViewMaterialBom.Name = "gridViewMaterialBom";
            this.gridViewMaterialBom.OptionsView.ShowFooter = true;
            this.gridViewMaterialBom.OptionsView.ShowGroupPanel = false;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            // 
            // txtReRatio
            // 
            this.tablePanel3.SetColumn(this.txtReRatio, 2);
            this.txtReRatio.Location = new System.Drawing.Point(345, 304);
            this.txtReRatio.Name = "txtReRatio";
            this.txtReRatio.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReRatio.Properties.Appearance.Options.UseFont = true;
            this.txtReRatio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtReRatio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtReRatio.Properties.DisplayFormat.FormatString = "f";
            this.txtReRatio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtReRatio.Properties.EditFormat.FormatString = "f";
            this.txtReRatio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtReRatio.Properties.Mask.EditMask = "p";
            this.txtReRatio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReRatio.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.txtReRatio, 3);
            this.txtReRatio.Size = new System.Drawing.Size(142, 30);
            this.txtReRatio.TabIndex = 59;
            // 
            // txtTotalMaterial
            // 
            this.tablePanel3.SetColumn(this.txtTotalMaterial, 2);
            this.txtTotalMaterial.Location = new System.Drawing.Point(345, 4);
            this.txtTotalMaterial.Name = "txtTotalMaterial";
            this.txtTotalMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMaterial.Properties.Appearance.Options.UseFont = true;
            this.txtTotalMaterial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalMaterial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalMaterial.Properties.DisplayFormat.FormatString = "{0:P1}";
            this.txtTotalMaterial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalMaterial.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.txtTotalMaterial, 0);
            this.txtTotalMaterial.Size = new System.Drawing.Size(142, 30);
            this.txtTotalMaterial.TabIndex = 60;
            // 
            // txtReason
            // 
            this.tablePanel3.SetColumn(this.txtReason, 1);
            this.tablePanel3.SetColumnSpan(this.txtReason, 2);
            this.txtReason.Location = new System.Drawing.Point(93, 342);
            this.txtReason.Name = "txtReason";
            this.txtReason.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Properties.Appearance.Options.UseFont = true;
            this.txtReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.tablePanel3.SetRow(this.txtReason, 4);
            this.txtReason.Size = new System.Drawing.Size(394, 24);
            this.txtReason.TabIndex = 3;
            this.txtReason.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtReason_ButtonClick);
            // 
            // tablePanel3
            // 
            this.tablePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.26F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 56.54F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.2F)});
            this.tablePanel3.Controls.Add(this.txtReason);
            this.tablePanel3.Controls.Add(this.txtTotalMaterial);
            this.tablePanel3.Controls.Add(this.txtReRatio);
            this.tablePanel3.Controls.Add(this.gridControl2);
            this.tablePanel3.Controls.Add(this.label13);
            this.tablePanel3.Controls.Add(this.bteWeightRM);
            this.tablePanel3.Controls.Add(this.label5);
            this.tablePanel3.Controls.Add(this.label9);
            this.tablePanel3.Controls.Add(this.bteWeightRe);
            this.tablePanel3.Controls.Add(this.label10);
            this.tablePanel3.Controls.Add(this.label11);
            this.tablePanel3.Controls.Add(this.txtTotal);
            this.tablePanel3.Controls.Add(this.lueRecycled);
            this.tablePanel3.Location = new System.Drawing.Point(422, 14);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 230F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 32F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 32F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(490, 416);
            this.tablePanel3.TabIndex = 57;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // frmMixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 822);
            this.Controls.Add(this.spbScale);
            this.Controls.Add(this.tablePanel6);
            this.Controls.Add(this.lueColor);
            this.Controls.Add(this.txtScaleWeight);
            this.Controls.Add(this.tablePanel5);
            this.Controls.Add(this.tablePanel4);
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.txtWeightRe);
            this.Controls.Add(this.txtWeightMaterial);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lueMaterial);
            this.Controls.Add(this.txtPosted);
            this.Controls.Add(this.txtMixID);
            this.Controls.Add(this.gridView1);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.txtWeightRecycled);
            this.Controls.Add(this.cmbRecycled);
            this.Controls.Add(this.txtWeightRM);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMixing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mixing Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMixing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            this.tablePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRecycled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReRatio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWeightRM;
        private System.Windows.Forms.ComboBox cmbRecycled;
        private System.Windows.Forms.TextBox txtWeightRecycled;
        private System.Windows.Forms.TextBox txtScaleWeight;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.BarCodeControl qrMixLotID;
        private System.Windows.Forms.ComboBox cmbLabelType;
        private System.Windows.Forms.ComboBox cmbProduct;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.DataGridView gridView1;
        private System.Windows.Forms.TextBox txtMixID;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtMixDate;
        private System.Windows.Forms.Timer timer1;
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
        private DevExpress.XtraEditors.LookUpEdit lueMaterial;
        private DevExpress.XtraEditors.LookUpEdit lueProduct;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtWeightMaterial;
        private DevExpress.XtraEditors.TextEdit txtWeightRe;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton spbExport;
        private DevExpress.XtraEditors.SimpleButton spbRefresh;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton spbSave;
        private DevExpress.XtraEditors.SimpleButton spbPost;
        private DevExpress.XtraEditors.SimpleButton spbReset;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private DevExpress.XtraEditors.TextEdit tedColor;
        private DevExpress.XtraEditors.LookUpEdit lueColor;
        private DevExpress.XtraEditors.TextEdit tedColorCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.SimpleButton spbScale;
        private DevExpress.XtraEditors.LookUpEdit lueOperator;
        private DevExpress.XtraEditors.TextEdit txtMachine;
        private DevExpress.XtraEditors.LookUpEdit lueRecycled;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.ButtonEdit txtReason;
        private DevExpress.XtraEditors.TextEdit txtTotalMaterial;
        private DevExpress.XtraEditors.TextEdit txtReRatio;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialBom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.ButtonEdit bteWeightRM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.ButtonEdit bteWeightRe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}