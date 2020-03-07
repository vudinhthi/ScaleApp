namespace ScaleApp
{
    partial class frmMixedOut
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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator5 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMixId = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbContaminated = new System.Windows.Forms.RadioButton();
            this.rdbBlackDot = new System.Windows.Forms.RadioButton();
            this.rdbDefect = new System.Windows.Forms.RadioButton();
            this.rdbRunner = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdPosted = new System.Windows.Forms.Button();
            this.qrCodeMixId = new DevExpress.XtraEditors.BarCodeControl();
            this.txtMixOutId = new System.Windows.Forms.TextBox();
            this.txtPosted = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightRunner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightDefect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightBlackDot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightContaminated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightRecycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightCookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mix Lot ID";
            // 
            // cmbMixId
            // 
            this.cmbMixId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMixId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMixId.FormattingEnabled = true;
            this.cmbMixId.Location = new System.Drawing.Point(124, 93);
            this.cmbMixId.Name = "cmbMixId";
            this.cmbMixId.Size = new System.Drawing.Size(293, 31);
            this.cmbMixId.TabIndex = 1;
            this.cmbMixId.SelectedIndexChanged += new System.EventHandler(this.cmbMixId_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbContaminated);
            this.groupBox1.Controls.Add(this.rdbBlackDot);
            this.groupBox1.Controls.Add(this.rdbDefect);
            this.groupBox1.Controls.Add(this.rdbRunner);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output type";
            // 
            // rdbContaminated
            // 
            this.rdbContaminated.AutoSize = true;
            this.rdbContaminated.Location = new System.Drawing.Point(268, 28);
            this.rdbContaminated.Name = "rdbContaminated";
            this.rdbContaminated.Size = new System.Drawing.Size(124, 27);
            this.rdbContaminated.TabIndex = 3;
            this.rdbContaminated.TabStop = true;
            this.rdbContaminated.Text = "Contaminated";
            this.rdbContaminated.UseVisualStyleBackColor = true;
            // 
            // rdbBlackDot
            // 
            this.rdbBlackDot.AutoSize = true;
            this.rdbBlackDot.Location = new System.Drawing.Point(169, 28);
            this.rdbBlackDot.Name = "rdbBlackDot";
            this.rdbBlackDot.Size = new System.Drawing.Size(93, 27);
            this.rdbBlackDot.TabIndex = 2;
            this.rdbBlackDot.TabStop = true;
            this.rdbBlackDot.Text = "Black Dot";
            this.rdbBlackDot.UseVisualStyleBackColor = true;
            // 
            // rdbDefect
            // 
            this.rdbDefect.AutoSize = true;
            this.rdbDefect.Location = new System.Drawing.Point(92, 28);
            this.rdbDefect.Name = "rdbDefect";
            this.rdbDefect.Size = new System.Drawing.Size(71, 27);
            this.rdbDefect.TabIndex = 1;
            this.rdbDefect.TabStop = true;
            this.rdbDefect.Text = "Defect";
            this.rdbDefect.UseVisualStyleBackColor = true;
            // 
            // rdbRunner
            // 
            this.rdbRunner.AutoSize = true;
            this.rdbRunner.Location = new System.Drawing.Point(6, 28);
            this.rdbRunner.Name = "rdbRunner";
            this.rdbRunner.Size = new System.Drawing.Size(80, 27);
            this.rdbRunner.TabIndex = 0;
            this.rdbRunner.TabStop = true;
            this.rdbRunner.Text = "Runner";
            this.rdbRunner.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(124, 135);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(293, 29);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::ScaleApp.Properties.Resources.Save_32x32;
            this.cmdSave.Location = new System.Drawing.Point(22, 190);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(109, 70);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Image = global::ScaleApp.Properties.Resources.Cancel_32x32;
            this.cmdReset.Location = new System.Drawing.Point(308, 190);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(109, 70);
            this.cmdReset.TabIndex = 6;
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdPosted
            // 
            this.cmdPosted.Image = global::ScaleApp.Properties.Resources.Mark_32x32;
            this.cmdPosted.Location = new System.Drawing.Point(169, 190);
            this.cmdPosted.Name = "cmdPosted";
            this.cmdPosted.Size = new System.Drawing.Size(109, 70);
            this.cmdPosted.TabIndex = 7;
            this.cmdPosted.UseVisualStyleBackColor = true;
            // 
            // qrCodeMixId
            // 
            this.qrCodeMixId.AutoModule = true;
            this.qrCodeMixId.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrCodeMixId.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qrCodeMixId.Location = new System.Drawing.Point(433, 56);
            this.qrCodeMixId.Name = "qrCodeMixId";
            this.qrCodeMixId.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.qrCodeMixId.Size = new System.Drawing.Size(309, 152);
            qrCodeGenerator5.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.qrCodeMixId.Symbology = qrCodeGenerator5;
            this.qrCodeMixId.TabIndex = 8;
            // 
            // txtMixOutId
            // 
            this.txtMixOutId.Location = new System.Drawing.Point(433, 214);
            this.txtMixOutId.Name = "txtMixOutId";
            this.txtMixOutId.Size = new System.Drawing.Size(100, 20);
            this.txtMixOutId.TabIndex = 9;
            // 
            // txtPosted
            // 
            this.txtPosted.Location = new System.Drawing.Point(433, 240);
            this.txtPosted.Name = "txtPosted";
            this.txtPosted.Size = new System.Drawing.Size(100, 20);
            this.txtPosted.TabIndex = 10;
            // 
            // txtDateTime
            // 
            this.txtDateTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDateTime.Location = new System.Drawing.Point(433, 24);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(309, 26);
            this.txtDateTime.TabIndex = 11;
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridView1
            // 
            this.gridView1.AllowUserToAddRows = false;
            this.gridView1.AllowUserToDeleteRows = false;
            this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.WeightDate,
            this.MixId,
            this.WeightRunner,
            this.WeightDefect,
            this.WeightBlackDot,
            this.WeightContaminated,
            this.WeightRecycle,
            this.WeightCookie,
            this.Posted});
            this.gridView1.Location = new System.Drawing.Point(16, 267);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.Size = new System.Drawing.Size(726, 344);
            this.gridView1.TabIndex = 12;
            this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // WeightDate
            // 
            this.WeightDate.HeaderText = "Date";
            this.WeightDate.Name = "WeightDate";
            this.WeightDate.ReadOnly = true;
            this.WeightDate.Width = 80;
            // 
            // MixId
            // 
            this.MixId.HeaderText = "Mix Lot";
            this.MixId.Name = "MixId";
            this.MixId.ReadOnly = true;
            this.MixId.Width = 150;
            // 
            // WeightRunner
            // 
            this.WeightRunner.HeaderText = "Runner";
            this.WeightRunner.Name = "WeightRunner";
            this.WeightRunner.ReadOnly = true;
            this.WeightRunner.Width = 80;
            // 
            // WeightDefect
            // 
            this.WeightDefect.HeaderText = "Defect";
            this.WeightDefect.Name = "WeightDefect";
            this.WeightDefect.ReadOnly = true;
            this.WeightDefect.Width = 80;
            // 
            // WeightBlackDot
            // 
            this.WeightBlackDot.HeaderText = "Black Dot";
            this.WeightBlackDot.Name = "WeightBlackDot";
            this.WeightBlackDot.ReadOnly = true;
            this.WeightBlackDot.Width = 80;
            // 
            // WeightContaminated
            // 
            this.WeightContaminated.HeaderText = "Contaminated";
            this.WeightContaminated.Name = "WeightContaminated";
            this.WeightContaminated.ReadOnly = true;
            this.WeightContaminated.Width = 80;
            // 
            // WeightRecycle
            // 
            this.WeightRecycle.HeaderText = "Recycled";
            this.WeightRecycle.Name = "WeightRecycle";
            this.WeightRecycle.ReadOnly = true;
            this.WeightRecycle.Width = 80;
            // 
            // WeightCookie
            // 
            this.WeightCookie.HeaderText = "Cookied";
            this.WeightCookie.Name = "WeightCookie";
            this.WeightCookie.ReadOnly = true;
            this.WeightCookie.Width = 80;
            // 
            // Posted
            // 
            this.Posted.HeaderText = "Posted";
            this.Posted.Name = "Posted";
            this.Posted.ReadOnly = true;
            this.Posted.Width = 40;
            // 
            // frmMixedOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 623);
            this.Controls.Add(this.gridView1);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtPosted);
            this.Controls.Add(this.txtMixOutId);
            this.Controls.Add(this.qrCodeMixId);
            this.Controls.Add(this.cmdPosted);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMixId);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "frmMixedOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FVN-Mixed out";
            this.Load += new System.EventHandler(this.frmMixedOut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMixId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbContaminated;
        private System.Windows.Forms.RadioButton rdbBlackDot;
        private System.Windows.Forms.RadioButton rdbDefect;
        private System.Windows.Forms.RadioButton rdbRunner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdPosted;
        private DevExpress.XtraEditors.BarCodeControl qrCodeMixId;
        private System.Windows.Forms.TextBox txtMixOutId;
        private System.Windows.Forms.TextBox txtPosted;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MixId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightRunner;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightDefect;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightBlackDot;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightContaminated;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightRecycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightCookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posted;
    }
}