namespace vIT_System.Förskott
{
    partial class frmMyPreShooting
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowFid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMotivation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUppdrag = new System.Windows.Forms.TextBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.tbChef = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hämta förskottsansökan";
            // 
            // cbShowFid
            // 
            this.cbShowFid.FormattingEnabled = true;
            this.cbShowFid.Location = new System.Drawing.Point(100, 35);
            this.cbShowFid.Name = "cbShowFid";
            this.cbShowFid.Size = new System.Drawing.Size(199, 21);
            this.cbShowFid.TabIndex = 3;
            this.cbShowFid.SelectedIndexChanged += new System.EventHandler(this.cbShowFid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motivering:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Summa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chef:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Uppdrag:";
            // 
            // tbMotivation
            // 
            this.tbMotivation.Location = new System.Drawing.Point(100, 71);
            this.tbMotivation.Multiline = true;
            this.tbMotivation.Name = "tbMotivation";
            this.tbMotivation.ReadOnly = true;
            this.tbMotivation.Size = new System.Drawing.Size(300, 57);
            this.tbMotivation.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Status:";
            // 
            // tbUppdrag
            // 
            this.tbUppdrag.Location = new System.Drawing.Point(100, 134);
            this.tbUppdrag.Multiline = true;
            this.tbUppdrag.Name = "tbUppdrag";
            this.tbUppdrag.ReadOnly = true;
            this.tbUppdrag.Size = new System.Drawing.Size(126, 20);
            this.tbUppdrag.TabIndex = 18;
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(100, 165);
            this.tbSumma.Multiline = true;
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.ReadOnly = true;
            this.tbSumma.Size = new System.Drawing.Size(126, 20);
            this.tbSumma.TabIndex = 19;
            // 
            // tbChef
            // 
            this.tbChef.Location = new System.Drawing.Point(100, 192);
            this.tbChef.Multiline = true;
            this.tbChef.Name = "tbChef";
            this.tbChef.ReadOnly = true;
            this.tbChef.Size = new System.Drawing.Size(126, 20);
            this.tbChef.TabIndex = 20;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(100, 220);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(126, 20);
            this.tbStatus.TabIndex = 21;
            // 
            // frmMyPreShooting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 278);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbChef);
            this.Controls.Add(this.tbSumma);
            this.Controls.Add(this.tbUppdrag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMotivation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShowFid);
            this.Controls.Add(this.label1);
            this.Name = "frmMyPreShooting";
            this.Text = "Se status på förskottsansökan";
            this.Load += new System.EventHandler(this.frmMyPreShooting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShowFid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMotivation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUppdrag;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.TextBox tbChef;
        private System.Windows.Forms.TextBox tbStatus;
    }
}