namespace vIT_System.GUI
{
    partial class FrmTravelorderr
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
            this.tbTravelNamn = new System.Windows.Forms.TextBox();
            this.tbTravelEnamn = new System.Windows.Forms.TextBox();
            this.tbTravelEmal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSkickaReseOrder = new System.Windows.Forms.Button();
            this.cmbTravelUppdrag = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLand = new System.Windows.Forms.ComboBox();
            this.LbxLand = new System.Windows.Forms.ListBox();
            this.btnLaggTillLand = new System.Windows.Forms.Button();
            this.btnTaBortLand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTravelNamn
            // 
            this.tbTravelNamn.Location = new System.Drawing.Point(80, 29);
            this.tbTravelNamn.Name = "tbTravelNamn";
            this.tbTravelNamn.Size = new System.Drawing.Size(100, 20);
            this.tbTravelNamn.TabIndex = 1;
            // 
            // tbTravelEnamn
            // 
            this.tbTravelEnamn.Location = new System.Drawing.Point(80, 63);
            this.tbTravelEnamn.Name = "tbTravelEnamn";
            this.tbTravelEnamn.Size = new System.Drawing.Size(100, 20);
            this.tbTravelEnamn.TabIndex = 2;
            // 
            // tbTravelEmal
            // 
            this.tbTravelEmal.Location = new System.Drawing.Point(80, 95);
            this.tbTravelEmal.Name = "tbTravelEmal";
            this.tbTravelEmal.Size = new System.Drawing.Size(100, 20);
            this.tbTravelEmal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Förnamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // btnSkickaReseOrder
            // 
            this.btnSkickaReseOrder.Location = new System.Drawing.Point(450, 206);
            this.btnSkickaReseOrder.Name = "btnSkickaReseOrder";
            this.btnSkickaReseOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSkickaReseOrder.TabIndex = 10;
            this.btnSkickaReseOrder.Text = "Skicka order";
            this.btnSkickaReseOrder.UseVisualStyleBackColor = true;
            this.btnSkickaReseOrder.Click += new System.EventHandler(this.btnSkickaReseOrder_Click);
            // 
            // cmbTravelUppdrag
            // 
            this.cmbTravelUppdrag.FormattingEnabled = true;
            this.cmbTravelUppdrag.Location = new System.Drawing.Point(80, 136);
            this.cmbTravelUppdrag.Name = "cmbTravelUppdrag";
            this.cmbTravelUppdrag.Size = new System.Drawing.Size(121, 21);
            this.cmbTravelUppdrag.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uppdrag:";
            // 
            // cmbLand
            // 
            this.cmbLand.FormattingEnabled = true;
            this.cmbLand.Location = new System.Drawing.Point(26, 26);
            this.cmbLand.Name = "cmbLand";
            this.cmbLand.Size = new System.Drawing.Size(121, 21);
            this.cmbLand.TabIndex = 6;
            // 
            // LbxLand
            // 
            this.LbxLand.FormattingEnabled = true;
            this.LbxLand.Location = new System.Drawing.Point(27, 53);
            this.LbxLand.Name = "LbxLand";
            this.LbxLand.Size = new System.Drawing.Size(120, 95);
            this.LbxLand.TabIndex = 8;
            // 
            // btnLaggTillLand
            // 
            this.btnLaggTillLand.Location = new System.Drawing.Point(161, 24);
            this.btnLaggTillLand.Name = "btnLaggTillLand";
            this.btnLaggTillLand.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillLand.TabIndex = 7;
            this.btnLaggTillLand.Text = "Lägg till land";
            this.btnLaggTillLand.UseVisualStyleBackColor = true;
            this.btnLaggTillLand.Click += new System.EventHandler(this.btnLaggTillLand_Click);
            // 
            // btnTaBortLand
            // 
            this.btnTaBortLand.Location = new System.Drawing.Point(161, 53);
            this.btnTaBortLand.Name = "btnTaBortLand";
            this.btnTaBortLand.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortLand.TabIndex = 9;
            this.btnTaBortLand.Text = "Ta bort valt land";
            this.btnTaBortLand.UseVisualStyleBackColor = true;
            this.btnTaBortLand.Click += new System.EventHandler(this.btnTaBortLand_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSkickaReseOrder);
            this.groupBox1.Controls.Add(this.tbTravelNamn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTravelEnamn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTravelUppdrag);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTravelEmal);
            this.groupBox1.Location = new System.Drawing.Point(39, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLand);
            this.groupBox2.Controls.Add(this.LbxLand);
            this.groupBox2.Controls.Add(this.btnLaggTillLand);
            this.groupBox2.Controls.Add(this.btnTaBortLand);
            this.groupBox2.Location = new System.Drawing.Point(263, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // FrmTravelorderr
            // 
            this.ClientSize = new System.Drawing.Size(860, 490);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTravelorderr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reseorder";
            this.Load += new System.EventHandler(this.FrmTravelorder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbTravelName;
        private System.Windows.Forms.TextBox tbTravelEmail;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTravelNamn;
        private System.Windows.Forms.TextBox tbTravelEnamn;
        private System.Windows.Forms.TextBox tbTravelEmal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSkickaReseOrder;
        private System.Windows.Forms.ComboBox cmbTravelUppdrag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLand;
        private System.Windows.Forms.ListBox LbxLand;
        private System.Windows.Forms.Button btnLaggTillLand;
        private System.Windows.Forms.Button btnTaBortLand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}