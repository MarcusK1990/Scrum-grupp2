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
            this.SuspendLayout();
            // 
            // tbTravelNamn
            // 
            this.tbTravelNamn.Location = new System.Drawing.Point(90, 25);
            this.tbTravelNamn.Name = "tbTravelNamn";
            this.tbTravelNamn.Size = new System.Drawing.Size(100, 20);
            this.tbTravelNamn.TabIndex = 0;
            // 
            // tbTravelEnamn
            // 
            this.tbTravelEnamn.Location = new System.Drawing.Point(90, 64);
            this.tbTravelEnamn.Name = "tbTravelEnamn";
            this.tbTravelEnamn.Size = new System.Drawing.Size(100, 20);
            this.tbTravelEnamn.TabIndex = 1;
            // 
            // tbTravelEmal
            // 
            this.tbTravelEmal.Location = new System.Drawing.Point(90, 101);
            this.tbTravelEmal.Name = "tbTravelEmal";
            this.tbTravelEmal.Size = new System.Drawing.Size(100, 20);
            this.tbTravelEmal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Förnamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // btnSkickaReseOrder
            // 
            this.btnSkickaReseOrder.Location = new System.Drawing.Point(235, 198);
            this.btnSkickaReseOrder.Name = "btnSkickaReseOrder";
            this.btnSkickaReseOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSkickaReseOrder.TabIndex = 6;
            this.btnSkickaReseOrder.Text = "Skicka order";
            this.btnSkickaReseOrder.UseVisualStyleBackColor = true;
            this.btnSkickaReseOrder.Click += new System.EventHandler(this.btnSkickaReseOrder_Click);
            // 
            // cmbTravelUppdrag
            // 
            this.cmbTravelUppdrag.FormattingEnabled = true;
            this.cmbTravelUppdrag.Location = new System.Drawing.Point(90, 195);
            this.cmbTravelUppdrag.Name = "cmbTravelUppdrag";
            this.cmbTravelUppdrag.Size = new System.Drawing.Size(121, 21);
            this.cmbTravelUppdrag.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uppdrag:";
            // 
            // cmbLand
            // 
            this.cmbLand.FormattingEnabled = true;
            this.cmbLand.Location = new System.Drawing.Point(216, 24);
            this.cmbLand.Name = "cmbLand";
            this.cmbLand.Size = new System.Drawing.Size(121, 21);
            this.cmbLand.TabIndex = 9;
            // 
            // LbxLand
            // 
            this.LbxLand.FormattingEnabled = true;
            this.LbxLand.Location = new System.Drawing.Point(216, 64);
            this.LbxLand.Name = "LbxLand";
            this.LbxLand.Size = new System.Drawing.Size(120, 95);
            this.LbxLand.TabIndex = 10;
            // 
            // btnLaggTillLand
            // 
            this.btnLaggTillLand.Location = new System.Drawing.Point(358, 24);
            this.btnLaggTillLand.Name = "btnLaggTillLand";
            this.btnLaggTillLand.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillLand.TabIndex = 11;
            this.btnLaggTillLand.Text = "Lägg till land";
            this.btnLaggTillLand.UseVisualStyleBackColor = true;
            this.btnLaggTillLand.Click += new System.EventHandler(this.btnLaggTillLand_Click);
            // 
            // btnTaBortLand
            // 
            this.btnTaBortLand.Location = new System.Drawing.Point(358, 67);
            this.btnTaBortLand.Name = "btnTaBortLand";
            this.btnTaBortLand.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortLand.TabIndex = 12;
            this.btnTaBortLand.Text = "Ta bort valt land";
            this.btnTaBortLand.UseVisualStyleBackColor = true;
            this.btnTaBortLand.Click += new System.EventHandler(this.btnTaBortLand_Click);
            // 
            // FrmTravelorderr
            // 
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.btnTaBortLand);
            this.Controls.Add(this.btnLaggTillLand);
            this.Controls.Add(this.LbxLand);
            this.Controls.Add(this.cmbLand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTravelUppdrag);
            this.Controls.Add(this.btnSkickaReseOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTravelEmal);
            this.Controls.Add(this.tbTravelEnamn);
            this.Controls.Add(this.tbTravelNamn);
            this.Name = "FrmTravelorderr";
            this.Text = "Rese Order";
            this.Load += new System.EventHandler(this.FrmTravelorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}