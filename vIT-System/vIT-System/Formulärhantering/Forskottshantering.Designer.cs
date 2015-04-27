namespace vIT_System.Formulärhantering
{
    partial class Forskottshantering
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMotivering = new System.Windows.Forms.TextBox();
            this.tbUppdrag = new System.Windows.Forms.TextBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.cbVisaSokande = new System.Windows.Forms.ComboBox();
            this.btnGodkann = new System.Windows.Forms.Button();
            this.btnAvsla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Sokande = new System.Windows.Forms.Label();
            this.tbSokande = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Välj förskottansökning: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivering:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Uppdrag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Summa:";
            // 
            // tbMotivering
            // 
            this.tbMotivering.Location = new System.Drawing.Point(121, 107);
            this.tbMotivering.Multiline = true;
            this.tbMotivering.Name = "tbMotivering";
            this.tbMotivering.ReadOnly = true;
            this.tbMotivering.Size = new System.Drawing.Size(203, 70);
            this.tbMotivering.TabIndex = 23;
            // 
            // tbUppdrag
            // 
            this.tbUppdrag.Location = new System.Drawing.Point(121, 191);
            this.tbUppdrag.Name = "tbUppdrag";
            this.tbUppdrag.ReadOnly = true;
            this.tbUppdrag.Size = new System.Drawing.Size(203, 20);
            this.tbUppdrag.TabIndex = 24;
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(121, 217);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.ReadOnly = true;
            this.tbSumma.Size = new System.Drawing.Size(203, 20);
            this.tbSumma.TabIndex = 25;
            // 
            // cbVisaSokande
            // 
            this.cbVisaSokande.FormattingEnabled = true;
            this.cbVisaSokande.Location = new System.Drawing.Point(122, 38);
            this.cbVisaSokande.Name = "cbVisaSokande";
            this.cbVisaSokande.Size = new System.Drawing.Size(202, 21);
            this.cbVisaSokande.TabIndex = 0;
            this.cbVisaSokande.SelectedIndexChanged += new System.EventHandler(this.cbVisaSokande_SelectedIndexChanged);
            // 
            // btnGodkann
            // 
            this.btnGodkann.Location = new System.Drawing.Point(121, 262);
            this.btnGodkann.Name = "btnGodkann";
            this.btnGodkann.Size = new System.Drawing.Size(75, 23);
            this.btnGodkann.TabIndex = 1;
            this.btnGodkann.Text = "Godkänn";
            this.btnGodkann.UseVisualStyleBackColor = true;
            this.btnGodkann.Click += new System.EventHandler(this.btnGodkann_Click);
            // 
            // btnAvsla
            // 
            this.btnAvsla.Location = new System.Drawing.Point(249, 262);
            this.btnAvsla.Name = "btnAvsla";
            this.btnAvsla.Size = new System.Drawing.Size(75, 23);
            this.btnAvsla.TabIndex = 2;
            this.btnAvsla.Text = "Avslå";
            this.btnAvsla.UseVisualStyleBackColor = true;
            this.btnAvsla.Click += new System.EventHandler(this.btnAvsla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sökande:";
            // 
            // Sokande
            // 
            this.Sokande.AutoSize = true;
            this.Sokande.Location = new System.Drawing.Point(118, 80);
            this.Sokande.Name = "Sokande";
            this.Sokande.Size = new System.Drawing.Size(0, 13);
            this.Sokande.TabIndex = 31;
            // 
            // tbSokande
            // 
            this.tbSokande.Location = new System.Drawing.Point(121, 77);
            this.tbSokande.Name = "tbSokande";
            this.tbSokande.ReadOnly = true;
            this.tbSokande.Size = new System.Drawing.Size(199, 20);
            this.tbSokande.TabIndex = 32;
            // 
            // Forskottshantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 490);
            this.Controls.Add(this.tbSokande);
            this.Controls.Add(this.Sokande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAvsla);
            this.Controls.Add(this.btnGodkann);
            this.Controls.Add(this.cbVisaSokande);
            this.Controls.Add(this.tbSumma);
            this.Controls.Add(this.tbUppdrag);
            this.Controls.Add(this.tbMotivering);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forskottshantering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nya förskottsansökningar";
            this.Load += new System.EventHandler(this.Forskottshantering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMotivering;
        private System.Windows.Forms.TextBox tbUppdrag;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.ComboBox cbVisaSokande;
        private System.Windows.Forms.Button btnGodkann;
        private System.Windows.Forms.Button btnAvsla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Sokande;
        private System.Windows.Forms.TextBox tbSokande;
    }
}