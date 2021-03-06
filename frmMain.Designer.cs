﻿namespace ScaleApp
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
            this.userLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixedOutStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLoginToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Login";
            // 
            // userLoginToolStripMenuItem
            // 
            this.userLoginToolStripMenuItem.Name = "userLoginToolStripMenuItem";
            this.userLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userLoginToolStripMenuItem.Text = "User";
            this.userLoginToolStripMenuItem.Click += new System.EventHandler(this.userLoginToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // mixingToolStripMenuItem
            // 
            this.mixingToolStripMenuItem.Name = "mixingToolStripMenuItem";
            this.mixingToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mixingToolStripMenuItem.Text = "Mixing Station";
            this.mixingToolStripMenuItem.Click += new System.EventHandler(this.mixingToolStripMenuItem_Click);
            // 
            // mixedOutStationToolStripMenuItem
            // 
            this.mixedOutStationToolStripMenuItem.Name = "mixedOutStationToolStripMenuItem";
            this.mixedOutStationToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.mixedOutStationToolStripMenuItem.Text = "Incoming Crush Station";
            this.mixedOutStationToolStripMenuItem.Click += new System.EventHandler(this.mixedOutStationToolStripMenuItem_Click);
            // 
            // recycledStationToolStripMenuItem
            // 
            this.recycledStationToolStripMenuItem.Name = "recycledStationToolStripMenuItem";
            this.recycledStationToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.recycledStationToolStripMenuItem.Text = "Crush Station";
            this.recycledStationToolStripMenuItem.Click += new System.EventHandler(this.recycledStationToolStripMenuItem_Click);
            // 
            // cookiesStationToolStripMenuItem
            // 
            this.cookiesStationToolStripMenuItem.Name = "cookiesStationToolStripMenuItem";
            this.cookiesStationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cookiesStationToolStripMenuItem.Text = "Cookies Station";
            this.cookiesStationToolStripMenuItem.Click += new System.EventHandler(this.cookiesStationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem recycledStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookiesStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

