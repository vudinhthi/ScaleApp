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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMixing));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeightRM = new System.Windows.Forms.TextBox();
            this.cmbRecycled = new System.Windows.Forms.ComboBox();
            this.txtWeightRecycled = new System.Windows.Forms.TextBox();
            this.txtScaleWeight = new System.Windows.Forms.TextBox();
            this.qrMixLotID = new DevExpress.XtraEditors.BarCodeControl();
            this.frmMixinglayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.txtReRatio = new DevExpress.XtraEditors.TextEdit();
            this.txtReason = new DevExpress.XtraEditors.ButtonEdit();
            this.bteWeightRe = new DevExpress.XtraEditors.ButtonEdit();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.txtMixDate = new System.Windows.Forms.TextBox();
            this.lueRecycled = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTotalMaterial = new DevExpress.XtraEditors.TextEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialBom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbLabelType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tedColorCode = new DevExpress.XtraEditors.TextEdit();
            this.tedColor = new DevExpress.XtraEditors.TextEdit();
            this.bteWeightRM = new DevExpress.XtraEditors.ButtonEdit();
            this.txtMachine = new DevExpress.XtraEditors.TextEdit();
            this.spbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lueOperator = new DevExpress.XtraEditors.LookUpEdit();
            this.spbExport = new DevExpress.XtraEditors.SimpleButton();
            this.lueProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.spbReset = new DevExpress.XtraEditors.SimpleButton();
            this.spbPost = new DevExpress.XtraEditors.SimpleButton();
            this.spbSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueMaterial = new DevExpress.XtraEditors.LookUpEdit();
            this.spbScale = new DevExpress.XtraEditors.SimpleButton();
            this.lueColor = new DevExpress.XtraEditors.LookUpEdit();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtWeightRe = new DevExpress.XtraEditors.TextEdit();
            this.txtWeightMaterial = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPosted = new System.Windows.Forms.TextBox();
            this.txtMixID = new System.Windows.Forms.TextBox();
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
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblDateTime = new DevExpress.XtraEditors.TextEdit();
            this.spbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.gridView1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtMixIDitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPosteditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tablePanel1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.tablePanel2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbColoritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbProductitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbRecycleditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueColoritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueMaterialitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtWeightRecycleditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbMaterialitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtWeightRMitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtWeightReitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtWeightMaterialitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtScaleWeightitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.spbScaleitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmMixinglayoutControl1ConvertedLayout)).BeginInit();
            this.frmMixinglayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReRatio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRecycled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLabelType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMixIDitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosteditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColoritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRecycleditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColoritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterialitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRecycleditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterialitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRMitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightReitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightMaterialitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScaleWeightitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbScaleitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cmbShift.Location = new System.Drawing.Point(129, 45);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(117, 24);
            this.cmbShift.TabIndex = 0;
            // 
            // cmbOperator
            // 
            this.tablePanel1.SetColumn(this.cmbOperator, 1);
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(138, 38);
            this.cmbOperator.Name = "cmbOperator";
            this.tablePanel1.SetRow(this.cmbOperator, 1);
            this.cmbOperator.Size = new System.Drawing.Size(341, 28);
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
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(129, 71);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(117, 24);
            this.cmbStep.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tablePanel1.SetColumn(this.label4, 0);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 117);
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
            this.cmbMaterial.Location = new System.Drawing.Point(476, 515);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(1036, 28);
            this.cmbMaterial.TabIndex = 13;
            this.cmbMaterial.Visible = false;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(255, 199);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(603, 28);
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
            this.label7.Location = new System.Drawing.Point(3, 118);
            this.label7.Name = "label7";
            this.tablePanel2.SetRow(this.label7, 2);
            this.label7.Size = new System.Drawing.Size(95, 8);
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
            this.txtWeightRM.Location = new System.Drawing.Point(476, 515);
            this.txtWeightRM.Name = "txtWeightRM";
            this.txtWeightRM.Size = new System.Drawing.Size(1036, 20);
            this.txtWeightRM.TabIndex = 15;
            this.txtWeightRM.Visible = false;
            this.txtWeightRM.TextChanged += new System.EventHandler(this.txtWeightRM_TextChanged);
            // 
            // cmbRecycled
            // 
            this.cmbRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecycled.FormattingEnabled = true;
            this.cmbRecycled.Location = new System.Drawing.Point(255, 95);
            this.cmbRecycled.Name = "cmbRecycled";
            this.cmbRecycled.Size = new System.Drawing.Size(966, 28);
            this.cmbRecycled.TabIndex = 17;
            this.cmbRecycled.Visible = false;
            // 
            // txtWeightRecycled
            // 
            this.txtWeightRecycled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRecycled.Location = new System.Drawing.Point(476, 200);
            this.txtWeightRecycled.Name = "txtWeightRecycled";
            this.txtWeightRecycled.Size = new System.Drawing.Size(1041, 20);
            this.txtWeightRecycled.TabIndex = 19;
            this.txtWeightRecycled.Visible = false;
            this.txtWeightRecycled.TextChanged += new System.EventHandler(this.txtWeightRecycled_TextChanged);
            // 
            // txtScaleWeight
            // 
            this.txtScaleWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtScaleWeight.Location = new System.Drawing.Point(24, 286);
            this.txtScaleWeight.Name = "txtScaleWeight";
            this.txtScaleWeight.ReadOnly = true;
            this.txtScaleWeight.Size = new System.Drawing.Size(147, 36);
            this.txtScaleWeight.TabIndex = 25;
            this.txtScaleWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qrMixLotID
            // 
            this.qrMixLotID.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrMixLotID.Appearance.Options.UseFont = true;
            this.qrMixLotID.AutoModule = true;
            this.qrMixLotID.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrMixLotID.Location = new System.Drawing.Point(1018, 48);
            this.qrMixLotID.Name = "qrMixLotID";
            this.qrMixLotID.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.qrMixLotID.Size = new System.Drawing.Size(356, 158);
            this.qrMixLotID.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.qrMixLotID.Symbology = qrCodeGenerator1;
            this.qrMixLotID.TabIndex = 32;
            // 
            // frmMixinglayoutControl1ConvertedLayout
            // 
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtReRatio);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtReason);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.bteWeightRe);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cboComPort);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.qrMixLotID);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtMixDate);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.lueRecycled);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtTotalMaterial);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.gridControl2);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbLabelType);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.tedColorCode);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.tedColor);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.bteWeightRM);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtMachine);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbRefresh);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.lueOperator);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbShift);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbStep);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbExport);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.lueProduct);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbReset);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbPost);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbSave);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.lueMaterial);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbScale);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.lueColor);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtScaleWeight);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.tablePanel2);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.tablePanel1);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtWeightRe);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtWeightMaterial);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.gridControl1);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtPosted);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtMixID);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.gridView1);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbProduct);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtWeightRecycled);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbRecycled);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtWeightRM);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbMaterial);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.cmbColor);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtTotal);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.lblDateTime);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.spbPrint);
            this.frmMixinglayoutControl1ConvertedLayout.Controls.Add(this.txtProductName);
            this.frmMixinglayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMixinglayoutControl1ConvertedLayout.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.gridView1item,
            this.txtMixIDitem,
            this.txtPosteditem,
            this.tablePanel1item,
            this.tablePanel2item,
            this.cmbColoritem,
            this.cmbProductitem,
            this.cmbRecycleditem,
            this.lueColoritem,
            this.lueMaterialitem,
            this.txtWeightRecycleditem,
            this.cmbMaterialitem,
            this.txtWeightRMitem,
            this.layoutControlItem20,
            this.txtWeightReitem,
            this.txtWeightMaterialitem,
            this.layoutControlItem19,
            this.layoutControlGroup10});
            this.frmMixinglayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmMixinglayoutControl1ConvertedLayout.Name = "frmMixinglayoutControl1ConvertedLayout";
            this.frmMixinglayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 561, 650, 400);
            this.frmMixinglayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmMixinglayoutControl1ConvertedLayout.Size = new System.Drawing.Size(1496, 937);
            this.frmMixinglayoutControl1ConvertedLayout.TabIndex = 61;
            // 
            // txtReRatio
            // 
            this.txtReRatio.Location = new System.Drawing.Point(877, 156);
            this.txtReRatio.Name = "txtReRatio";
            this.txtReRatio.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtReRatio.Size = new System.Drawing.Size(147, 36);
            this.txtReRatio.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtReRatio.TabIndex = 59;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(712, 196);
            this.txtReason.Name = "txtReason";
            this.txtReason.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Properties.Appearance.Options.UseFont = true;
            this.txtReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtReason.Size = new System.Drawing.Size(312, 22);
            this.txtReason.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtReason.TabIndex = 2;
            this.txtReason.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtReason_ButtonClick);
            // 
            // bteWeightRe
            // 
            this.bteWeightRe.Location = new System.Drawing.Point(712, 156);
            this.bteWeightRe.Name = "bteWeightRe";
            this.bteWeightRe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteWeightRe.Properties.Appearance.Options.UseFont = true;
            this.bteWeightRe.Properties.Appearance.Options.UseTextOptions = true;
            this.bteWeightRe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bteWeightRe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.bteWeightRe.Properties.Mask.EditMask = "f";
            this.bteWeightRe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bteWeightRe.Properties.ReadOnly = true;
            this.bteWeightRe.Size = new System.Drawing.Size(161, 36);
            this.bteWeightRe.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.bteWeightRe.TabIndex = 1;
            this.bteWeightRe.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteWeightRe_ButtonClick);
            // 
            // cboComPort
            // 
            this.cboComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(1254, 69);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(251, 26);
            this.cboComPort.TabIndex = 39;
            // 
            // txtMixDate
            // 
            this.txtMixDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMixDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMixDate.Location = new System.Drawing.Point(126, 374);
            this.txtMixDate.Name = "txtMixDate";
            this.txtMixDate.ReadOnly = true;
            this.txtMixDate.Size = new System.Drawing.Size(1379, 20);
            this.txtMixDate.TabIndex = 38;
            this.txtMixDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lueRecycled
            // 
            this.lueRecycled.Location = new System.Drawing.Point(712, 130);
            this.lueRecycled.Name = "lueRecycled";
            this.lueRecycled.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueRecycled.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRecycled.Properties.Appearance.Options.UseFont = true;
            this.lueRecycled.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRecycled.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueRecycled.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRecycled.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueRecycled.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRecycled.Properties.NullText = "";
            this.lueRecycled.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueRecycled.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueRecycled.Size = new System.Drawing.Size(312, 22);
            this.lueRecycled.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.lueRecycled.TabIndex = 1;
            this.lueRecycled.EditValueChanged += new System.EventHandler(this.lueRecycled_EditValueChanged);
            // 
            // txtTotalMaterial
            // 
            this.txtTotalMaterial.Location = new System.Drawing.Point(877, 45);
            this.txtTotalMaterial.Name = "txtTotalMaterial";
            this.txtTotalMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMaterial.Properties.Appearance.Options.UseFont = true;
            this.txtTotalMaterial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalMaterial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalMaterial.Properties.DisplayFormat.FormatString = "{0:P1}";
            this.txtTotalMaterial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalMaterial.Properties.ReadOnly = true;
            this.txtTotalMaterial.Size = new System.Drawing.Size(147, 36);
            this.txtTotalMaterial.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtTotalMaterial.TabIndex = 60;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(1052, 45);
            this.gridControl2.MainView = this.gridViewMaterialBom;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(420, 213);
            this.gridControl2.TabIndex = 58;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialBom,
            this.gridView3});
            // 
            // gridViewMaterialBom
            // 
            this.gridViewMaterialBom.Appearance.FooterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMaterialBom.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewMaterialBom.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMaterialBom.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMaterialBom.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewMaterialBom.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewMaterialBom.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMaterialBom.Appearance.Row.Options.UseFont = true;
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
            // cmbLabelType
            // 
            this.cmbLabelType.EditValue = "Mixed";
            this.cmbLabelType.Location = new System.Drawing.Point(1173, 286);
            this.cmbLabelType.Name = "cmbLabelType";
            this.cmbLabelType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabelType.Properties.Appearance.Options.UseFont = true;
            this.cmbLabelType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabelType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbLabelType.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabelType.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cmbLabelType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLabelType.Properties.Items.AddRange(new object[] {
            "Mixed",
            "Runner",
            "Defect",
            "BlackDot",
            "Contaminated",
            "Production Set"});
            this.cmbLabelType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbLabelType.Size = new System.Drawing.Size(147, 22);
            this.cmbLabelType.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.cmbLabelType.TabIndex = 0;
            // 
            // tedColorCode
            // 
            this.tedColorCode.Location = new System.Drawing.Point(129, 194);
            this.tedColorCode.Name = "tedColorCode";
            this.tedColorCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedColorCode.Properties.Appearance.Options.UseFont = true;
            this.tedColorCode.Properties.ReadOnly = true;
            this.tedColorCode.Size = new System.Drawing.Size(450, 22);
            this.tedColorCode.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.tedColorCode.TabIndex = 63;
            // 
            // tedColor
            // 
            this.tedColor.Location = new System.Drawing.Point(129, 220);
            this.tedColor.Name = "tedColor";
            this.tedColor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedColor.Properties.Appearance.Options.UseFont = true;
            this.tedColor.Properties.Appearance.Options.UseTextOptions = true;
            this.tedColor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tedColor.Properties.ReadOnly = true;
            this.tedColor.Size = new System.Drawing.Size(450, 22);
            this.tedColor.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.tedColor.TabIndex = 62;
            // 
            // bteWeightRM
            // 
            this.bteWeightRM.Location = new System.Drawing.Point(712, 45);
            this.bteWeightRM.Name = "bteWeightRM";
            this.bteWeightRM.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bteWeightRM.Size = new System.Drawing.Size(161, 36);
            this.bteWeightRM.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.bteWeightRM.TabIndex = 0;
            this.bteWeightRM.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteWeightRM_ButtonClick);
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(355, 71);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Properties.Appearance.Options.UseFont = true;
            this.txtMachine.Size = new System.Drawing.Size(224, 22);
            this.txtMachine.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtMachine.TabIndex = 3;
            // 
            // spbRefresh
            // 
            this.spbRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbRefresh.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbRefresh.Appearance.Options.UseFont = true;
            this.spbRefresh.Appearance.Options.UseForeColor = true;
            this.spbRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbRefresh.ImageOptions.Image")));
            this.spbRefresh.Location = new System.Drawing.Point(988, 286);
            this.spbRefresh.Name = "spbRefresh";
            this.spbRefresh.Size = new System.Drawing.Size(157, 36);
            this.spbRefresh.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbRefresh.TabIndex = 4;
            this.spbRefresh.Text = "Refresh";
            this.spbRefresh.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lueOperator
            // 
            this.lueOperator.Location = new System.Drawing.Point(355, 45);
            this.lueOperator.Name = "lueOperator";
            this.lueOperator.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueOperator.Properties.Appearance.Options.UseFont = true;
            this.lueOperator.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueOperator.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueOperator.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueOperator.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueOperator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOperator.Properties.NullText = "";
            this.lueOperator.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueOperator.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.lueOperator.Size = new System.Drawing.Size(224, 22);
            this.lueOperator.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.lueOperator.TabIndex = 1;
            // 
            // spbExport
            // 
            this.spbExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbExport.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbExport.Appearance.Options.UseFont = true;
            this.spbExport.Appearance.Options.UseForeColor = true;
            this.spbExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbExport.ImageOptions.Image")));
            this.spbExport.Location = new System.Drawing.Point(829, 286);
            this.spbExport.Name = "spbExport";
            this.spbExport.Size = new System.Drawing.Size(155, 36);
            this.spbExport.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbExport.TabIndex = 3;
            this.spbExport.Text = "Export";
            this.spbExport.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lueProduct
            // 
            this.lueProduct.Location = new System.Drawing.Point(129, 142);
            this.lueProduct.Name = "lueProduct";
            this.lueProduct.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueProduct.Properties.Appearance.Options.UseFont = true;
            this.lueProduct.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueProduct.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueProduct.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueProduct.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProduct.Properties.NullText = "";
            this.lueProduct.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueProduct.Properties.PopupFormMinSize = new System.Drawing.Size(580, 0);
            this.lueProduct.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.lueProduct.Size = new System.Drawing.Size(450, 22);
            this.lueProduct.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.lueProduct.TabIndex = 0;
            this.lueProduct.EditValueChanged += new System.EventHandler(this.lueProduct_EditValueChanged);
            // 
            // spbReset
            // 
            this.spbReset.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbReset.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbReset.Appearance.Options.UseFont = true;
            this.spbReset.Appearance.Options.UseForeColor = true;
            this.spbReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbReset.ImageOptions.Image")));
            this.spbReset.Location = new System.Drawing.Point(669, 286);
            this.spbReset.Name = "spbReset";
            this.spbReset.Size = new System.Drawing.Size(156, 36);
            this.spbReset.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbReset.TabIndex = 2;
            this.spbReset.Text = "Reset";
            this.spbReset.Click += new System.EventHandler(this.spbReset_Click);
            // 
            // spbPost
            // 
            this.spbPost.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbPost.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbPost.Appearance.Options.UseFont = true;
            this.spbPost.Appearance.Options.UseForeColor = true;
            this.spbPost.Enabled = false;
            this.spbPost.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbPost.ImageOptions.Image")));
            this.spbPost.Location = new System.Drawing.Point(510, 286);
            this.spbPost.Name = "spbPost";
            this.spbPost.Size = new System.Drawing.Size(155, 36);
            this.spbPost.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbPost.TabIndex = 1;
            this.spbPost.Text = "Post";
            this.spbPost.Click += new System.EventHandler(this.spbPost_Click);
            // 
            // spbSave
            // 
            this.spbSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbSave.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbSave.Appearance.Options.UseFont = true;
            this.spbSave.Appearance.Options.UseForeColor = true;
            this.spbSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbSave.ImageOptions.Image")));
            this.spbSave.Location = new System.Drawing.Point(351, 286);
            this.spbSave.Name = "spbSave";
            this.spbSave.Size = new System.Drawing.Size(155, 36);
            this.spbSave.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbSave.TabIndex = 0;
            this.spbSave.Text = "Save";
            this.spbSave.Click += new System.EventHandler(this.spbSave_Click);
            // 
            // lueMaterial
            // 
            this.lueMaterial.Location = new System.Drawing.Point(529, 149);
            this.lueMaterial.Name = "lueMaterial";
            this.lueMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMaterial.Properties.Appearance.Options.UseFont = true;
            this.lueMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaterial.Properties.NullText = "";
            this.lueMaterial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMaterial.Size = new System.Drawing.Size(935, 26);
            this.lueMaterial.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.lueMaterial.TabIndex = 41;
            this.lueMaterial.Visible = false;
            // 
            // spbScale
            // 
            this.spbScale.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbScale.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spbScale.Appearance.Options.UseFont = true;
            this.spbScale.Appearance.Options.UseForeColor = true;
            this.spbScale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbScale.ImageOptions.Image")));
            this.spbScale.Location = new System.Drawing.Point(175, 286);
            this.spbScale.Name = "spbScale";
            this.spbScale.Size = new System.Drawing.Size(148, 36);
            this.spbScale.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbScale.TabIndex = 0;
            this.spbScale.Text = "Scale";
            this.spbScale.Click += new System.EventHandler(this.spbScale_Click);
            // 
            // lueColor
            // 
            this.lueColor.Location = new System.Drawing.Point(12, 184);
            this.lueColor.Name = "lueColor";
            this.lueColor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueColor.Properties.Appearance.Options.UseFont = true;
            this.lueColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lueColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueColor.Properties.NullText = "";
            this.lueColor.Size = new System.Drawing.Size(1452, 26);
            this.lueColor.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.lueColor.TabIndex = 43;
            this.lueColor.Visible = false;
            // 
            // tablePanel2
            // 
            this.tablePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 16.74F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.26F)});
            this.tablePanel2.Controls.Add(this.label12);
            this.tablePanel2.Controls.Add(this.label8);
            this.tablePanel2.Controls.Add(this.label7);
            this.tablePanel2.Location = new System.Drawing.Point(255, 12);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 31F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 87F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 8F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(482, 158);
            this.tablePanel2.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tablePanel2.SetColumn(this.label12, 0);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(3, 132);
            this.label12.Name = "label12";
            this.tablePanel2.SetRow(this.label12, 3);
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "Color name";
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 16.75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.25F)});
            this.tablePanel1.Controls.Add(this.cmbOperator);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Location = new System.Drawing.Point(255, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F)});
            this.tablePanel1.Size = new System.Drawing.Size(482, 150);
            this.tablePanel1.TabIndex = 55;
            // 
            // txtWeightRe
            // 
            this.txtWeightRe.Location = new System.Drawing.Point(476, 515);
            this.txtWeightRe.Name = "txtWeightRe";
            this.txtWeightRe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightRe.Properties.Appearance.Options.UseFont = true;
            this.txtWeightRe.Properties.Mask.EditMask = "n";
            this.txtWeightRe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeightRe.Size = new System.Drawing.Size(1041, 26);
            this.txtWeightRe.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtWeightRe.TabIndex = 47;
            this.txtWeightRe.Visible = false;
            // 
            // txtWeightMaterial
            // 
            this.txtWeightMaterial.Location = new System.Drawing.Point(24, 274);
            this.txtWeightMaterial.Name = "txtWeightMaterial";
            this.txtWeightMaterial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightMaterial.Properties.Appearance.Options.UseFont = true;
            this.txtWeightMaterial.Properties.Mask.EditMask = "n";
            this.txtWeightMaterial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeightMaterial.Size = new System.Drawing.Size(323, 30);
            this.txtWeightMaterial.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtWeightMaterial.TabIndex = 46;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(24, 350);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1448, 563);
            this.gridControl1.TabIndex = 45;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // txtPosted
            // 
            this.txtPosted.Location = new System.Drawing.Point(498, 229);
            this.txtPosted.Name = "txtPosted";
            this.txtPosted.Size = new System.Drawing.Size(966, 20);
            this.txtPosted.TabIndex = 40;
            this.txtPosted.Visible = false;
            // 
            // txtMixID
            // 
            this.txtMixID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMixID.Location = new System.Drawing.Point(498, 229);
            this.txtMixID.Name = "txtMixID";
            this.txtMixID.ReadOnly = true;
            this.txtMixID.Size = new System.Drawing.Size(480, 20);
            this.txtMixID.TabIndex = 36;
            this.txtMixID.Visible = false;
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
            this.gridView1.Location = new System.Drawing.Point(12, 757);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.Size = new System.Drawing.Size(1452, 53);
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
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(255, 174);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(1209, 28);
            this.cmbProduct.TabIndex = 34;
            this.cmbProduct.Visible = false;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(712, 222);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(312, 36);
            this.txtTotal.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtTotal.TabIndex = 65;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(1018, 24);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(356, 20);
            this.lblDateTime.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.lblDateTime.TabIndex = 66;
            // 
            // spbPrint
            // 
            this.spbPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbPrint.Appearance.ForeColor = System.Drawing.Color.Green;
            this.spbPrint.Appearance.Options.UseFont = true;
            this.spbPrint.Appearance.Options.UseForeColor = true;
            this.spbPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbPrint.ImageOptions.Image")));
            this.spbPrint.Location = new System.Drawing.Point(1324, 286);
            this.spbPrint.Name = "spbPrint";
            this.spbPrint.Size = new System.Drawing.Size(148, 36);
            this.spbPrint.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.spbPrint.TabIndex = 67;
            this.spbPrint.Text = "Print labels";
            this.spbPrint.Click += new System.EventHandler(this.spbPrint_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(129, 168);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProductName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txtProductName.Size = new System.Drawing.Size(450, 22);
            this.txtProductName.StyleController = this.frmMixinglayoutControl1ConvertedLayout;
            this.txtProductName.TabIndex = 68;
            // 
            // gridView1item
            // 
            this.gridView1item.Control = this.gridView1;
            this.gridView1item.Location = new System.Drawing.Point(0, 745);
            this.gridView1item.Name = "gridView1item";
            this.gridView1item.Size = new System.Drawing.Size(1456, 57);
            this.gridView1item.TextSize = new System.Drawing.Size(0, 0);
            this.gridView1item.TextVisible = false;
            // 
            // txtMixIDitem
            // 
            this.txtMixIDitem.Control = this.txtMixID;
            this.txtMixIDitem.Location = new System.Drawing.Point(486, 217);
            this.txtMixIDitem.Name = "txtMixIDitem";
            this.txtMixIDitem.Size = new System.Drawing.Size(484, 24);
            this.txtMixIDitem.TextSize = new System.Drawing.Size(0, 0);
            this.txtMixIDitem.TextVisible = false;
            // 
            // txtPosteditem
            // 
            this.txtPosteditem.Control = this.txtPosted;
            this.txtPosteditem.Location = new System.Drawing.Point(486, 217);
            this.txtPosteditem.Name = "txtPosteditem";
            this.txtPosteditem.Size = new System.Drawing.Size(970, 24);
            this.txtPosteditem.TextSize = new System.Drawing.Size(0, 0);
            this.txtPosteditem.TextVisible = false;
            // 
            // tablePanel1item
            // 
            this.tablePanel1item.Control = this.tablePanel1;
            this.tablePanel1item.Location = new System.Drawing.Point(243, 0);
            this.tablePanel1item.Name = "tablePanel1item";
            this.tablePanel1item.Size = new System.Drawing.Size(486, 154);
            this.tablePanel1item.TextSize = new System.Drawing.Size(0, 0);
            this.tablePanel1item.TextVisible = false;
            // 
            // tablePanel2item
            // 
            this.tablePanel2item.Control = this.tablePanel2;
            this.tablePanel2item.Location = new System.Drawing.Point(243, 0);
            this.tablePanel2item.Name = "tablePanel2item";
            this.tablePanel2item.Size = new System.Drawing.Size(486, 162);
            this.tablePanel2item.TextSize = new System.Drawing.Size(0, 0);
            this.tablePanel2item.TextVisible = false;
            // 
            // cmbColoritem
            // 
            this.cmbColoritem.Control = this.cmbColor;
            this.cmbColoritem.Location = new System.Drawing.Point(243, 187);
            this.cmbColoritem.Name = "cmbColoritem";
            this.cmbColoritem.Size = new System.Drawing.Size(607, 30);
            this.cmbColoritem.TextSize = new System.Drawing.Size(0, 0);
            this.cmbColoritem.TextVisible = false;
            // 
            // cmbProductitem
            // 
            this.cmbProductitem.Control = this.cmbProduct;
            this.cmbProductitem.Location = new System.Drawing.Point(243, 162);
            this.cmbProductitem.Name = "cmbProductitem";
            this.cmbProductitem.Size = new System.Drawing.Size(1213, 25);
            this.cmbProductitem.TextSize = new System.Drawing.Size(0, 0);
            this.cmbProductitem.TextVisible = false;
            // 
            // cmbRecycleditem
            // 
            this.cmbRecycleditem.Control = this.cmbRecycled;
            this.cmbRecycleditem.Location = new System.Drawing.Point(243, 83);
            this.cmbRecycleditem.Name = "cmbRecycleditem";
            this.cmbRecycleditem.Size = new System.Drawing.Size(970, 25);
            this.cmbRecycleditem.TextSize = new System.Drawing.Size(0, 0);
            this.cmbRecycleditem.TextVisible = false;
            // 
            // lueColoritem
            // 
            this.lueColoritem.Control = this.lueColor;
            this.lueColoritem.Location = new System.Drawing.Point(0, 172);
            this.lueColoritem.Name = "lueColoritem";
            this.lueColoritem.Size = new System.Drawing.Size(1456, 30);
            this.lueColoritem.TextSize = new System.Drawing.Size(0, 0);
            this.lueColoritem.TextVisible = false;
            // 
            // lueMaterialitem
            // 
            this.lueMaterialitem.Control = this.lueMaterial;
            this.lueMaterialitem.Location = new System.Drawing.Point(448, 137);
            this.lueMaterialitem.Name = "lueMaterialitem";
            this.lueMaterialitem.Size = new System.Drawing.Size(1008, 30);
            this.lueMaterialitem.Text = "Material (*)";
            this.lueMaterialitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.lueMaterialitem.TextSize = new System.Drawing.Size(55, 13);
            // 
            // txtWeightRecycleditem
            // 
            this.txtWeightRecycleditem.Control = this.txtWeightRecycled;
            this.txtWeightRecycleditem.Location = new System.Drawing.Point(464, 188);
            this.txtWeightRecycleditem.Name = "txtWeightRecycleditem";
            this.txtWeightRecycleditem.Size = new System.Drawing.Size(1045, 24);
            this.txtWeightRecycleditem.TextSize = new System.Drawing.Size(0, 0);
            this.txtWeightRecycleditem.TextVisible = false;
            // 
            // cmbMaterialitem
            // 
            this.cmbMaterialitem.Control = this.cmbMaterial;
            this.cmbMaterialitem.Location = new System.Drawing.Point(464, 503);
            this.cmbMaterialitem.Name = "cmbMaterialitem";
            this.cmbMaterialitem.Size = new System.Drawing.Size(1040, 25);
            this.cmbMaterialitem.TextSize = new System.Drawing.Size(0, 0);
            this.cmbMaterialitem.TextVisible = false;
            // 
            // txtWeightRMitem
            // 
            this.txtWeightRMitem.Control = this.txtWeightRM;
            this.txtWeightRMitem.Location = new System.Drawing.Point(464, 503);
            this.txtWeightRMitem.Name = "txtWeightRMitem";
            this.txtWeightRMitem.Size = new System.Drawing.Size(1040, 24);
            this.txtWeightRMitem.TextSize = new System.Drawing.Size(0, 0);
            this.txtWeightRMitem.TextVisible = false;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.txtMixDate;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(1485, 24);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(50, 20);
            // 
            // txtWeightReitem
            // 
            this.txtWeightReitem.Control = this.txtWeightRe;
            this.txtWeightReitem.Location = new System.Drawing.Point(464, 503);
            this.txtWeightReitem.Name = "txtWeightReitem";
            this.txtWeightReitem.Size = new System.Drawing.Size(1045, 414);
            this.txtWeightReitem.TextSize = new System.Drawing.Size(0, 0);
            this.txtWeightReitem.TextVisible = false;
            // 
            // txtWeightMaterialitem
            // 
            this.txtWeightMaterialitem.Control = this.txtWeightMaterial;
            this.txtWeightMaterialitem.Location = new System.Drawing.Point(0, 55);
            this.txtWeightMaterialitem.Name = "txtWeightMaterialitem";
            this.txtWeightMaterialitem.Size = new System.Drawing.Size(327, 34);
            this.txtWeightMaterialitem.TextSize = new System.Drawing.Size(0, 0);
            this.txtWeightMaterialitem.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.cboComPort;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(255, 25);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem21,
            this.layoutControlItem27});
            this.layoutControlGroup10.Location = new System.Drawing.Point(994, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Size = new System.Drawing.Size(384, 210);
            this.layoutControlGroup10.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.qrMixLotID;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem21.MinSize = new System.Drawing.Size(54, 20);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(360, 162);
            this.layoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.lblDateTime;
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6,
            this.layoutControlGroup7,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlGroup3,
            this.layoutControlGroup2,
            this.layoutControlGroup8,
            this.layoutControlGroup9,
            this.layoutControlGroup11});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1496, 937);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.gridControl1item});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 326);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1476, 591);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // gridControl1item
            // 
            this.gridControl1item.Control = this.gridControl1;
            this.gridControl1item.Location = new System.Drawing.Point(0, 0);
            this.gridControl1item.MinSize = new System.Drawing.Size(104, 24);
            this.gridControl1item.Name = "gridControl1item";
            this.gridControl1item.Size = new System.Drawing.Size(1452, 567);
            this.gridControl1item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.gridControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.gridControl1item.TextVisible = false;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem14,
            this.layoutControlItem28});
            this.layoutControlGroup7.Location = new System.Drawing.Point(1149, 262);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(327, 64);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.cmbLabelType;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(54, 26);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(151, 40);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.spbPrint;
            this.layoutControlItem28.Location = new System.Drawing.Point(151, 0);
            this.layoutControlItem28.MinSize = new System.Drawing.Size(98, 40);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(152, 40);
            this.layoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem28.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem28.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup4.AppearanceGroup.ForeColor = System.Drawing.Color.Green;
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup4.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(583, 97);
            this.layoutControlGroup4.Text = "Mixing Information";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.cmbShift;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(226, 26);
            this.layoutControlItem7.Text = "Shift";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.lueOperator;
            this.layoutControlItem6.Location = new System.Drawing.Point(226, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(333, 26);
            this.layoutControlItem6.Text = "Operator";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.cmbStep;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(226, 26);
            this.layoutControlItem8.Text = "Step";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Green;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.txtMachine;
            this.layoutControlItem9.Location = new System.Drawing.Point(226, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(333, 26);
            this.layoutControlItem9.Text = "Machine";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AppearanceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup5.AppearanceGroup.ForeColor = System.Drawing.Color.Olive;
            this.layoutControlGroup5.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup5.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem15,
            this.layoutControlItem12,
            this.layoutControlItem13});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 97);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(583, 165);
            this.layoutControlGroup5.Text = "Product Information";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.Olive;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem10.Control = this.lueProduct;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(559, 26);
            this.layoutControlItem10.Text = "Product";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem15.AppearanceItemCaption.ForeColor = System.Drawing.Color.Olive;
            this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem15.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem15.Control = this.txtProductName;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(559, 26);
            this.layoutControlItem15.Text = "Product name";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Olive;
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem12.Control = this.tedColorCode;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(559, 26);
            this.layoutControlItem12.Text = "Color code";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem13.AppearanceItemCaption.ForeColor = System.Drawing.Color.Olive;
            this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem13.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem13.Control = this.tedColor;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(559, 42);
            this.layoutControlItem13.Text = "Color name";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txtScaleWeightitem,
            this.spbScaleitem});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 262);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(327, 64);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // txtScaleWeightitem
            // 
            this.txtScaleWeightitem.Control = this.txtScaleWeight;
            this.txtScaleWeightitem.Location = new System.Drawing.Point(0, 0);
            this.txtScaleWeightitem.MinSize = new System.Drawing.Size(24, 24);
            this.txtScaleWeightitem.Name = "txtScaleWeightitem";
            this.txtScaleWeightitem.Size = new System.Drawing.Size(151, 40);
            this.txtScaleWeightitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.txtScaleWeightitem.TextSize = new System.Drawing.Size(0, 0);
            this.txtScaleWeightitem.TextVisible = false;
            // 
            // spbScaleitem
            // 
            this.spbScaleitem.Control = this.spbScale;
            this.spbScaleitem.Location = new System.Drawing.Point(151, 0);
            this.spbScaleitem.MinSize = new System.Drawing.Size(71, 40);
            this.spbScaleitem.Name = "spbScaleitem";
            this.spbScaleitem.Size = new System.Drawing.Size(152, 40);
            this.spbScaleitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.spbScaleitem.TextSize = new System.Drawing.Size(0, 0);
            this.spbScaleitem.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(327, 262);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(822, 64);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.spbSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(159, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spbPost;
            this.layoutControlItem2.Location = new System.Drawing.Point(159, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(159, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spbReset;
            this.layoutControlItem3.Location = new System.Drawing.Point(318, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spbExport;
            this.layoutControlItem4.Location = new System.Drawing.Point(478, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(159, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spbRefresh;
            this.layoutControlItem5.Location = new System.Drawing.Point(637, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(161, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.AppearanceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup8.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layoutControlGroup8.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup8.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem16,
            this.layoutControlItem17});
            this.layoutControlGroup8.Location = new System.Drawing.Point(583, 0);
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(445, 85);
            this.layoutControlGroup8.Text = "Weight Material";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem16.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem16.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem16.Control = this.bteWeightRM;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(270, 40);
            this.layoutControlItem16.Text = "Weight RM";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtTotalMaterial;
            this.layoutControlItem17.Location = new System.Drawing.Point(270, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(151, 40);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.AppearanceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup9.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem18});
            this.layoutControlGroup9.Location = new System.Drawing.Point(1028, 0);
            this.layoutControlGroup9.Name = "layoutControlGroup9";
            this.layoutControlGroup9.Size = new System.Drawing.Size(448, 262);
            this.layoutControlGroup9.Text = "Material Consumption";
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.gridControl2;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(424, 217);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.AppearanceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup11.AppearanceGroup.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlGroup11.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup11.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup11.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup11.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlGroup11.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup11.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem22,
            this.layoutControlItem23,
            this.layoutControlItem24,
            this.layoutControlItem25,
            this.layoutControlItem26});
            this.layoutControlGroup11.Location = new System.Drawing.Point(583, 85);
            this.layoutControlGroup11.Name = "layoutControlGroup11";
            this.layoutControlGroup11.Size = new System.Drawing.Size(445, 177);
            this.layoutControlGroup11.Text = "Recyled Lot Information";
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.lueRecycled;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem22.MinSize = new System.Drawing.Size(159, 26);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(421, 26);
            this.layoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem22.Text = "Recyled Lot ID";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.txtReason;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(421, 26);
            this.layoutControlItem23.Text = "Reason";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.bteWeightRe;
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(270, 40);
            this.layoutControlItem24.Text = "Weight Re";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.txtReRatio;
            this.layoutControlItem25.Location = new System.Drawing.Point(270, 26);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(151, 40);
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.txtTotal;
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(421, 40);
            this.layoutControlItem26.Text = "Total";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(102, 16);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // frmMixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 937);
            this.Controls.Add(this.frmMixinglayoutControl1ConvertedLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMixing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mixing Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMixing_FormClosing);
            this.Load += new System.EventHandler(this.frmMixing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmMixinglayoutControl1ConvertedLayout)).EndInit();
            this.frmMixinglayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReRatio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRecycled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLabelType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteWeightRM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMixIDitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosteditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColoritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRecycleditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColoritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaterialitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRecycleditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterialitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightRMitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightReitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeightMaterialitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScaleWeightitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbScaleitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWeightRM;
        private System.Windows.Forms.ComboBox cmbRecycled;
        private System.Windows.Forms.TextBox txtWeightRecycled;
        private System.Windows.Forms.TextBox txtScaleWeight;
        private DevExpress.XtraEditors.BarCodeControl qrMixLotID;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLabelType;
        private System.Windows.Forms.ComboBox cmbProduct;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.DataGridView gridView1;
        private System.Windows.Forms.TextBox txtMixID;
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
        private DevExpress.XtraEditors.SimpleButton spbSave;
        private DevExpress.XtraEditors.SimpleButton spbPost;
        private DevExpress.XtraEditors.SimpleButton spbReset;
        private DevExpress.XtraEditors.TextEdit tedColor;
        private DevExpress.XtraEditors.LookUpEdit lueColor;
        private DevExpress.XtraEditors.TextEdit tedColorCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.SimpleButton spbScale;
        private DevExpress.XtraEditors.LookUpEdit lueOperator;
        private DevExpress.XtraEditors.TextEdit txtMachine;
        private DevExpress.XtraEditors.LookUpEdit lueRecycled;
        private DevExpress.XtraEditors.ButtonEdit txtReason;
        private DevExpress.XtraEditors.TextEdit txtTotalMaterial;
        private DevExpress.XtraEditors.TextEdit txtReRatio;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialBom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.ButtonEdit bteWeightRM;
        private DevExpress.XtraEditors.ButtonEdit bteWeightRe;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.LayoutControl frmMixinglayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lueMaterialitem;
        private DevExpress.XtraLayout.LayoutControlItem spbScaleitem;
        private DevExpress.XtraLayout.LayoutControlItem lueColoritem;
        private DevExpress.XtraLayout.LayoutControlItem txtScaleWeightitem;
        private DevExpress.XtraLayout.LayoutControlItem tablePanel2item;
        private DevExpress.XtraLayout.LayoutControlItem tablePanel1item;
        private DevExpress.XtraLayout.LayoutControlItem txtWeightReitem;
        private DevExpress.XtraLayout.LayoutControlItem txtWeightMaterialitem;
        private DevExpress.XtraLayout.LayoutControlItem gridControl1item;
        private DevExpress.XtraLayout.LayoutControlItem txtPosteditem;
        private DevExpress.XtraLayout.LayoutControlItem txtMixIDitem;
        private DevExpress.XtraLayout.LayoutControlItem gridView1item;
        private DevExpress.XtraLayout.LayoutControlItem cmbProductitem;
        private DevExpress.XtraLayout.LayoutControlItem txtWeightRecycleditem;
        private DevExpress.XtraLayout.LayoutControlItem cmbRecycleditem;
        private DevExpress.XtraLayout.LayoutControlItem txtWeightRMitem;
        private DevExpress.XtraLayout.LayoutControlItem cmbMaterialitem;
        private DevExpress.XtraLayout.LayoutControlItem cmbColoritem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraEditors.TextEdit lblDateTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraEditors.SimpleButton spbPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
    }
}