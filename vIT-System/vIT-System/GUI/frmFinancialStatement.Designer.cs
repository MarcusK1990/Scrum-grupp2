namespace vIT_System.GUI
{
    partial class frmFinancialStatement
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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSumErs = new System.Windows.Forms.TextBox();
            this.tbAntalResor = new System.Windows.Forms.TextBox();
            this.tbPeriod2 = new System.Windows.Forms.TextBox();
            this.tbPeriod1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(76, 23);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(103, 21);
            this.cbYear.TabIndex = 0;
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(76, 68);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(103, 21);
            this.cbPeriod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Välj år";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Välj period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vald period:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Visa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antal resor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Summa Ersättning";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSumErs);
            this.groupBox1.Controls.Add(this.tbAntalResor);
            this.groupBox1.Controls.Add(this.tbPeriod2);
            this.groupBox1.Controls.Add(this.tbPeriod1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(282, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 197);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sammanställning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // tbSumErs
            // 
            this.tbSumErs.Location = new System.Drawing.Point(109, 77);
            this.tbSumErs.Name = "tbSumErs";
            this.tbSumErs.ReadOnly = true;
            this.tbSumErs.Size = new System.Drawing.Size(100, 20);
            this.tbSumErs.TabIndex = 12;
            // 
            // tbAntalResor
            // 
            this.tbAntalResor.Location = new System.Drawing.Point(109, 50);
            this.tbAntalResor.Name = "tbAntalResor";
            this.tbAntalResor.ReadOnly = true;
            this.tbAntalResor.Size = new System.Drawing.Size(100, 20);
            this.tbAntalResor.TabIndex = 11;
            // 
            // tbPeriod2
            // 
            this.tbPeriod2.Location = new System.Drawing.Point(194, 23);
            this.tbPeriod2.Name = "tbPeriod2";
            this.tbPeriod2.ReadOnly = true;
            this.tbPeriod2.Size = new System.Drawing.Size(65, 20);
            this.tbPeriod2.TabIndex = 10;
            // 
            // tbPeriod1
            // 
            this.tbPeriod1.Location = new System.Drawing.Point(109, 23);
            this.tbPeriod1.Name = "tbPeriod1";
            this.tbPeriod1.ReadOnly = true;
            this.tbPeriod1.Size = new System.Drawing.Size(63, 20);
            this.tbPeriod1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbYear);
            this.groupBox2.Controls.Add(this.cbPeriod);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 197);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // frmFinancialStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 252);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFinancialStatement";
            this.Text = "Sammanställ kvartalsrapporter";
            this.Load += new System.EventHandler(this.frmFinancialStatement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSumErs;
        private System.Windows.Forms.TextBox tbAntalResor;
        private System.Windows.Forms.TextBox tbPeriod2;
        private System.Windows.Forms.TextBox tbPeriod1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}