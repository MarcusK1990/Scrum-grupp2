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
            this.gridPreshooting = new System.Windows.Forms.DataGridView();
            this.btnAnsokning = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblHomecoming = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gridResidence = new System.Windows.Forms.DataGridView();
            this.gridExpenses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreshooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPreshooting
            // 
            this.gridPreshooting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPreshooting.Location = new System.Drawing.Point(277, 59);
            this.gridPreshooting.Name = "gridPreshooting";
            this.gridPreshooting.Size = new System.Drawing.Size(388, 72);
            this.gridPreshooting.TabIndex = 0;
            // 
            // btnAnsokning
            // 
            this.btnAnsokning.Location = new System.Drawing.Point(287, 382);
            this.btnAnsokning.Name = "btnAnsokning";
            this.btnAnsokning.Size = new System.Drawing.Size(119, 23);
            this.btnAnsokning.TabIndex = 1;
            this.btnAnsokning.Text = "Se ansökningar";
            this.btnAnsokning.UseVisualStyleBackColor = true;
            this.btnAnsokning.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "2015-02-15 - 2015-02-19",
            "2015-02-20 - 2015-02-22"});
            this.listBox1.Location = new System.Drawing.Point(28, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 199);
            this.listBox1.TabIndex = 2;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(274, 9);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(43, 13);
            this.lblDeparture.TabIndex = 3;
            this.lblDeparture.Text = "Avresa:";
            // 
            // lblHomecoming
            // 
            this.lblHomecoming.AutoSize = true;
            this.lblHomecoming.Location = new System.Drawing.Point(274, 33);
            this.lblHomecoming.Name = "lblHomecoming";
            this.lblHomecoming.Size = new System.Drawing.Size(60, 13);
            this.lblHomecoming.TabIndex = 4;
            this.lblHomecoming.Text = "Hemkomst:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(274, 318);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Totalsumma:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(274, 344);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // gridResidence
            // 
            this.gridResidence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResidence.Location = new System.Drawing.Point(277, 137);
            this.gridResidence.Name = "gridResidence";
            this.gridResidence.Size = new System.Drawing.Size(388, 72);
            this.gridResidence.TabIndex = 7;
            // 
            // gridExpenses
            // 
            this.gridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExpenses.Location = new System.Drawing.Point(277, 215);
            this.gridExpenses.Name = "gridExpenses";
            this.gridExpenses.Size = new System.Drawing.Size(388, 71);
            this.gridExpenses.TabIndex = 8;
            // 
            // hamtaAnsokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.gridExpenses);
            this.Controls.Add(this.gridResidence);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHomecoming);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAnsokning);
            this.Controls.Add(this.gridPreshooting);
            this.Name = "hamtaAnsokning";
            this.Text = "hamtaAnsokning";
            ((System.ComponentModel.ISupportInitialize)(this.gridPreshooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPreshooting;
        private System.Windows.Forms.Button btnAnsokning;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblHomecoming;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView gridResidence;
        private System.Windows.Forms.DataGridView gridExpenses;

    }
}