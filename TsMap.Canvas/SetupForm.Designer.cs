﻿namespace TsMap.Canvas
{
    partial class SetupForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.NextBtn = new System.Windows.Forms.Button();
            this.loadMods = new System.Windows.Forms.CheckBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.modPanel = new System.Windows.Forms.Panel();
            this.PrioDown = new System.Windows.Forms.Button();
            this.PrioUp = new System.Windows.Forms.Button();
            this.modList = new System.Windows.Forms.CheckedListBox();
            this.BrowseModBtn = new System.Windows.Forms.Button();
            this.modFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ToTop = new System.Windows.Forms.Button();
            this.ToBottom = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.modPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(3, 447);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(333, 23);
            this.NextBtn.TabIndex = 0;
            this.NextBtn.Text = "Continue";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // loadMods
            // 
            this.loadMods.Location = new System.Drawing.Point(3, 45);
            this.loadMods.Name = "loadMods";
            this.loadMods.Size = new System.Drawing.Size(104, 24);
            this.loadMods.TabIndex = 2;
            this.loadMods.Text = "Load mods";
            this.loadMods.UseVisualStyleBackColor = true;
            this.loadMods.CheckedChanged += new System.EventHandler(this.loadMods_CheckedChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrowseBtn.Location = new System.Drawing.Point(3, 16);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(333, 23);
            this.BrowseBtn.TabIndex = 0;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the game dir.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.BrowseBtn);
            this.flowLayoutPanel1.Controls.Add(this.loadMods);
            this.flowLayoutPanel1.Controls.Add(this.modPanel);
            this.flowLayoutPanel1.Controls.Add(this.NextBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 494);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // modPanel
            // 
            this.modPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modPanel.Controls.Add(this.ToBottom);
            this.modPanel.Controls.Add(this.ToTop);
            this.modPanel.Controls.Add(this.PrioDown);
            this.modPanel.Controls.Add(this.PrioUp);
            this.modPanel.Controls.Add(this.modList);
            this.modPanel.Controls.Add(this.BrowseModBtn);
            this.modPanel.Location = new System.Drawing.Point(3, 75);
            this.modPanel.Name = "modPanel";
            this.modPanel.Size = new System.Drawing.Size(333, 366);
            this.modPanel.TabIndex = 3;
            this.modPanel.Visible = false;
            // 
            // PrioDown
            // 
            this.PrioDown.Location = new System.Drawing.Point(9, 340);
            this.PrioDown.Name = "PrioDown";
            this.PrioDown.Size = new System.Drawing.Size(255, 23);
            this.PrioDown.TabIndex = 2;
            this.PrioDown.Text = "Decrease Priority";
            this.PrioDown.UseVisualStyleBackColor = true;
            this.PrioDown.Click += new System.EventHandler(this.PrioDown_Click);
            // 
            // PrioUp
            // 
            this.PrioUp.Location = new System.Drawing.Point(9, 312);
            this.PrioUp.Name = "PrioUp";
            this.PrioUp.Size = new System.Drawing.Size(255, 23);
            this.PrioUp.TabIndex = 2;
            this.PrioUp.Text = "Increase Priority";
            this.PrioUp.UseVisualStyleBackColor = true;
            this.PrioUp.Click += new System.EventHandler(this.PrioUp_Click);
            // 
            // modList
            // 
            this.modList.FormattingEnabled = true;
            this.modList.Location = new System.Drawing.Point(9, 32);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(315, 274);
            this.modList.TabIndex = 1;
            this.modList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.modList_ItemCheck);
            // 
            // BrowseModBtn
            // 
            this.BrowseModBtn.Location = new System.Drawing.Point(9, 3);
            this.BrowseModBtn.Name = "BrowseModBtn";
            this.BrowseModBtn.Size = new System.Drawing.Size(315, 23);
            this.BrowseModBtn.TabIndex = 0;
            this.BrowseModBtn.Text = "Browse Mod Folder";
            this.BrowseModBtn.UseVisualStyleBackColor = true;
            this.BrowseModBtn.Click += new System.EventHandler(this.BrowseModBtn_Click);
            // 
            // ToTop
            // 
            this.ToTop.Location = new System.Drawing.Point(270, 312);
            this.ToTop.Name = "ToTop";
            this.ToTop.Size = new System.Drawing.Size(54, 23);
            this.ToTop.TabIndex = 3;
            this.ToTop.Text = "Top";
            this.ToTop.UseVisualStyleBackColor = true;
            this.ToTop.Click += new System.EventHandler(this.ToTop_Click);
            // 
            // ToBottom
            // 
            this.ToBottom.Location = new System.Drawing.Point(270, 340);
            this.ToBottom.Name = "ToBottom";
            this.ToBottom.Size = new System.Drawing.Size(54, 23);
            this.ToBottom.TabIndex = 3;
            this.ToBottom.Text = "Bottom";
            this.ToBottom.UseVisualStyleBackColor = true;
            this.ToBottom.Click += new System.EventHandler(this.ToBottom_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 494);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.Text = "Setup - TsMap";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.modPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.CheckBox loadMods;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel modPanel;
        private System.Windows.Forms.CheckedListBox modList;
        private System.Windows.Forms.Button BrowseModBtn;
        private System.Windows.Forms.Button PrioDown;
        private System.Windows.Forms.Button PrioUp;
        private System.Windows.Forms.FolderBrowserDialog modFolderBrowserDialog;
        private System.Windows.Forms.Button ToBottom;
        private System.Windows.Forms.Button ToTop;
    }
}