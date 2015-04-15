﻿namespace vIT_System.GUI
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.väljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemPreShoot = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTravel = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMyAppli = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraKonsulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljToolStripMenuItem,
            this.chefToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // väljToolStripMenuItem
            // 
            this.väljToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemPreShoot,
            this.mItemTravel,
            this.mItemMyAppli});
            this.väljToolStripMenuItem.Name = "väljToolStripMenuItem";
            this.väljToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.väljToolStripMenuItem.Text = "Välj";
            // 
            // mItemPreShoot
            // 
            this.mItemPreShoot.Name = "mItemPreShoot";
            this.mItemPreShoot.Size = new System.Drawing.Size(231, 22);
            this.mItemPreShoot.Text = "Skapa förskottsansökan";
            this.mItemPreShoot.Click += new System.EventHandler(this.skapaFörskottsansökanToolStripMenuItem_Click);
            // 
            // mItemTravel
            // 
            this.mItemTravel.Name = "mItemTravel";
            this.mItemTravel.Size = new System.Drawing.Size(231, 22);
            this.mItemTravel.Text = "Skapa reseersättningsansökan";
            this.mItemTravel.Click += new System.EventHandler(this.mItemTravel_Click);
            // 
            // mItemMyAppli
            // 
            this.mItemMyAppli.Name = "mItemMyAppli";
            this.mItemMyAppli.Size = new System.Drawing.Size(231, 22);
            this.mItemMyAppli.Text = "Mina ansökningar";
            this.mItemMyAppli.Click += new System.EventHandler(this.mItemMyAppli_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(101, 92);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 39);
            this.lblStatus.TabIndex = 1;
            // 
            // chefToolStripMenuItem
            // 
            this.chefToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hanteraKonsulterToolStripMenuItem});
            this.chefToolStripMenuItem.Name = "chefToolStripMenuItem";
            this.chefToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chefToolStripMenuItem.Text = "Chef";
            this.chefToolStripMenuItem.Visible = false;
            // 
            // hanteraKonsulterToolStripMenuItem
            // 
            this.hanteraKonsulterToolStripMenuItem.Name = "hanteraKonsulterToolStripMenuItem";
            this.hanteraKonsulterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hanteraKonsulterToolStripMenuItem.Text = "Hantera konsulter";
            this.hanteraKonsulterToolStripMenuItem.Click += new System.EventHandler(this.hanteraKonsulterToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem väljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemPreShoot;
        private System.Windows.Forms.ToolStripMenuItem mItemTravel;
        private System.Windows.Forms.ToolStripMenuItem mItemMyAppli;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem chefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraKonsulterToolStripMenuItem;
    }
}