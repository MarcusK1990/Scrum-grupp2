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
            this.tbPeriod1 = new System.Windows.Forms.TextBox();
            this.tbPeriod2 = new System.Windows.Forms.TextBox();
            this.tbAntalResor = new System.Windows.Forms.TextBox();
            this.tbSumErs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(29, 25);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 0;
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(29, 69);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cbPeriod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Välj år";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Välj period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vald period:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antal resor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sammanlagd ersättning utbetald";
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
            this.groupBox1.Location = new System.Drawing.Point(289, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 345);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sammanställning";
            // 
            // tbPeriod1
            // 
            this.tbPeriod1.Location = new System.Drawing.Point(201, 13);
            this.tbPeriod1.Name = "tbPeriod1";
            this.tbPeriod1.ReadOnly = true;
            this.tbPeriod1.Size = new System.Drawing.Size(63, 20);
            this.tbPeriod1.TabIndex = 9;
            // 
            // tbPeriod2
            // 
            this.tbPeriod2.Location = new System.Drawing.Point(287, 13);
            this.tbPeriod2.Name = "tbPeriod2";
            this.tbPeriod2.ReadOnly = true;
            this.tbPeriod2.Size = new System.Drawing.Size(57, 20);
            this.tbPeriod2.TabIndex = 10;
            // 
            // tbAntalResor
            // 
            this.tbAntalResor.Location = new System.Drawing.Point(201, 45);
            this.tbAntalResor.Name = "tbAntalResor";
            this.tbAntalResor.ReadOnly = true;
            this.tbAntalResor.Size = new System.Drawing.Size(100, 20);
            this.tbAntalResor.TabIndex = 11;
            // 
            // tbSumErs
            // 
            this.tbSumErs.Location = new System.Drawing.Point(201, 71);
            this.tbSumErs.Name = "tbSumErs";
            this.tbSumErs.ReadOnly = true;
            this.tbSumErs.Size = new System.Drawing.Size(100, 20);
            this.tbSumErs.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // frmFinancialStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.cbYear);
            this.Name = "frmFinancialStatement";
            this.Text = "Sammanställ kvartalsrapporter";
            this.Load += new System.EventHandler(this.frmFinancialStatement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}