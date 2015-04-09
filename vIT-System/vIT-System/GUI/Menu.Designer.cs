namespace vIT_System
{
    partial class Menu
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemPreShooting = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemCompensation = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMyApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemPreShooting,
            this.mItemCompensation,
            this.mItemMyApplications});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem1.Text = "Välj";
            // 
            // mItemPreShooting
            // 
            this.mItemPreShooting.Name = "mItemPreShooting";
            this.mItemPreShooting.Size = new System.Drawing.Size(169, 22);
            this.mItemPreShooting.Text = "Förskottsformulär";
            this.mItemPreShooting.Click += new System.EventHandler(this.mItemPreShooting_Click);
            // 
            // mItemCompensation
            // 
            this.mItemCompensation.Name = "mItemCompensation";
            this.mItemCompensation.Size = new System.Drawing.Size(169, 22);
            this.mItemCompensation.Text = "Reseersättning";
            this.mItemCompensation.Click += new System.EventHandler(this.mItemCompensation_Click);
            // 
            // mItemMyApplications
            // 
            this.mItemMyApplications.Name = "mItemMyApplications";
            this.mItemMyApplications.Size = new System.Drawing.Size(169, 22);
            this.mItemMyApplications.Text = "Mina ansökningar";
            this.mItemMyApplications.Click += new System.EventHandler(this.mItemMyApplications_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 429);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Meny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mItemPreShooting;
        private System.Windows.Forms.ToolStripMenuItem mItemCompensation;
        private System.Windows.Forms.ToolStripMenuItem mItemMyApplications;
    }
}

