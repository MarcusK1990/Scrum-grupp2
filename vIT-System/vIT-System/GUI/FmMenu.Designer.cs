namespace vIT_System.GUI
{
    partial class FrmMenu
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
            this.reseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraKonsulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sammanställKvartalsrapporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraReseersättningsansökanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraFörskottsansökanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // väljToolStripMenuItem
            // 
            this.väljToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemPreShoot,
            this.mItemTravel,
            this.mItemMyAppli,
            this.reseOrderToolStripMenuItem});
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
            // reseOrderToolStripMenuItem
            // 
            this.reseOrderToolStripMenuItem.Name = "reseOrderToolStripMenuItem";
            this.reseOrderToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.reseOrderToolStripMenuItem.Text = "Reseorder";
            this.reseOrderToolStripMenuItem.Click += new System.EventHandler(this.reseOrderToolStripMenuItem_Click);
            // 
            // chefToolStripMenuItem
            // 
            this.chefToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hanteraKonsulterToolStripMenuItem,
            this.sammanställKvartalsrapporterToolStripMenuItem,
            this.hanteraReseersättningsansökanToolStripMenuItem,
            this.hanteraFörskottsansökanToolStripMenuItem});
            this.chefToolStripMenuItem.Name = "chefToolStripMenuItem";
            this.chefToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chefToolStripMenuItem.Text = "Chef";
            this.chefToolStripMenuItem.Visible = false;
            // 
            // hanteraKonsulterToolStripMenuItem
            // 
            this.hanteraKonsulterToolStripMenuItem.Name = "hanteraKonsulterToolStripMenuItem";
            this.hanteraKonsulterToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.hanteraKonsulterToolStripMenuItem.Text = "Hantera konsulter";
            this.hanteraKonsulterToolStripMenuItem.Click += new System.EventHandler(this.hanteraKonsulterToolStripMenuItem_Click);
            // 
            // sammanställKvartalsrapporterToolStripMenuItem
            // 
            this.sammanställKvartalsrapporterToolStripMenuItem.Name = "sammanställKvartalsrapporterToolStripMenuItem";
            this.sammanställKvartalsrapporterToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.sammanställKvartalsrapporterToolStripMenuItem.Text = "Sammanställ kvartalsrapporter";
            this.sammanställKvartalsrapporterToolStripMenuItem.Click += new System.EventHandler(this.sammanställKvartalsrapporterToolStripMenuItem_Click);
            // 
            // hanteraReseersättningsansökanToolStripMenuItem
            // 
            this.hanteraReseersättningsansökanToolStripMenuItem.Name = "hanteraReseersättningsansökanToolStripMenuItem";
            this.hanteraReseersättningsansökanToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.hanteraReseersättningsansökanToolStripMenuItem.Text = "Hantera reseersättningsansökan";
            this.hanteraReseersättningsansökanToolStripMenuItem.Click += new System.EventHandler(this.hanteraReseersättningsansökanToolStripMenuItem_Click);
            // 
            // hanteraFörskottsansökanToolStripMenuItem
            // 
            this.hanteraFörskottsansökanToolStripMenuItem.Name = "hanteraFörskottsansökanToolStripMenuItem";
            this.hanteraFörskottsansökanToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.hanteraFörskottsansökanToolStripMenuItem.Text = "Hantera förskottsansökan";
            this.hanteraFörskottsansökanToolStripMenuItem.Click += new System.EventHandler(this.hanteraFörskottsansökanToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 518);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem chefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraKonsulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sammanställKvartalsrapporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraReseersättningsansökanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraFörskottsansökanToolStripMenuItem;
    }
}