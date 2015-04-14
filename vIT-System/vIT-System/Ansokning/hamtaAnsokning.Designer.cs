namespace vIT_System.Rapport
{
    partial class hamtaAnsokning
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
            this.listAnsökningar = new System.Windows.Forms.ListBox();
            this.lblBorder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAnsökningar
            // 
            this.listAnsökningar.FormattingEnabled = true;
            this.listAnsökningar.Items.AddRange(new object[] {
            "2015-02-15 - 2015-02-19",
            "2015-02-20 - 2015-02-22"});
            this.listAnsökningar.Location = new System.Drawing.Point(12, 9);
            this.listAnsökningar.Name = "listAnsökningar";
            this.listAnsökningar.Size = new System.Drawing.Size(160, 420);
            this.listAnsökningar.TabIndex = 2;
            // 
            // lblBorder
            // 
            this.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorder.Location = new System.Drawing.Point(178, 9);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(2, 420);
            this.lblBorder.TabIndex = 9;
            // 
            // hamtaAnsokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.listAnsökningar);
            this.Name = "hamtaAnsokning";
            this.Text = "hamtaAnsokning";
            this.Load += new System.EventHandler(this.hamtaAnsokning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAnsökningar;
        private System.Windows.Forms.Label lblBorder;

    }
}