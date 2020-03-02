namespace ScaleApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mixingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixedOutStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaminatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recycledStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookiesStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mixingToolStripMenuItem,
            this.mixedOutStationToolStripMenuItem,
            this.recycledStationToolStripMenuItem,
            this.cookiesStationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Login";
            // 
            // mixingToolStripMenuItem
            // 
            this.mixingToolStripMenuItem.Name = "mixingToolStripMenuItem";
            this.mixingToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.mixingToolStripMenuItem.Text = "Mixing Station";
            this.mixingToolStripMenuItem.Click += new System.EventHandler(this.mixingToolStripMenuItem_Click);
            // 
            // mixedOutStationToolStripMenuItem
            // 
            this.mixedOutStationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runnerToolStripMenuItem,
            this.defectToolStripMenuItem,
            this.blackDotToolStripMenuItem,
            this.contaminatedToolStripMenuItem});
            this.mixedOutStationToolStripMenuItem.Name = "mixedOutStationToolStripMenuItem";
            this.mixedOutStationToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.mixedOutStationToolStripMenuItem.Text = "Mixed Out Station";
            // 
            // runnerToolStripMenuItem
            // 
            this.runnerToolStripMenuItem.Name = "runnerToolStripMenuItem";
            this.runnerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.runnerToolStripMenuItem.Text = "Runner";
            // 
            // defectToolStripMenuItem
            // 
            this.defectToolStripMenuItem.Name = "defectToolStripMenuItem";
            this.defectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.defectToolStripMenuItem.Text = "Defect";
            // 
            // blackDotToolStripMenuItem
            // 
            this.blackDotToolStripMenuItem.Name = "blackDotToolStripMenuItem";
            this.blackDotToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.blackDotToolStripMenuItem.Text = "Black Dot";
            // 
            // contaminatedToolStripMenuItem
            // 
            this.contaminatedToolStripMenuItem.Name = "contaminatedToolStripMenuItem";
            this.contaminatedToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.contaminatedToolStripMenuItem.Text = "Contaminated";
            // 
            // recycledStationToolStripMenuItem
            // 
            this.recycledStationToolStripMenuItem.Name = "recycledStationToolStripMenuItem";
            this.recycledStationToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.recycledStationToolStripMenuItem.Text = "Recycled Station";
            this.recycledStationToolStripMenuItem.Click += new System.EventHandler(this.recycledStationToolStripMenuItem_Click);
            // 
            // cookiesStationToolStripMenuItem
            // 
            this.cookiesStationToolStripMenuItem.Name = "cookiesStationToolStripMenuItem";
            this.cookiesStationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cookiesStationToolStripMenuItem.Text = "Cookies Station";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScaleApp.Properties.Resources._36327663_1527068020730825_495444513616035840_o;
            this.ClientSize = new System.Drawing.Size(944, 749);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Recycled Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mixingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mixedOutStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaminatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recycledStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookiesStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

