namespace vIT_System.Formulärhantering
{
    partial class Ansökningshantering
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
            this.cbVisaAnsid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVisaRid = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGodkann = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Uppdrag = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSokande = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbErsattning = new System.Windows.Forms.TextBox();
            this.tbForskott = new System.Windows.Forms.TextBox();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.tbUppdrag = new System.Windows.Forms.TextBox();
            this.tbSem = new System.Windows.Forms.TextBox();
            this.tbAvresa = new System.Windows.Forms.TextBox();
            this.tbHemresa = new System.Windows.Forms.TextBox();
            this.tbLand = new System.Windows.Forms.TextBox();
            this.tbTrak = new System.Windows.Forms.TextBox();
            this.lwUtgifter = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotalsumma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välj ansökan";
            // 
            // cbVisaAnsid
            // 
            this.cbVisaAnsid.FormattingEnabled = true;
            this.cbVisaAnsid.Location = new System.Drawing.Point(16, 45);
            this.cbVisaAnsid.Name = "cbVisaAnsid";
            this.cbVisaAnsid.Size = new System.Drawing.Size(216, 21);
            this.cbVisaAnsid.TabIndex = 1;
            this.cbVisaAnsid.SelectedIndexChanged += new System.EventHandler(this.cbVisaAnsid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sökande:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id:";
            // 
            // cbVisaRid
            // 
            this.cbVisaRid.FormattingEnabled = true;
            this.cbVisaRid.Location = new System.Drawing.Point(341, 45);
            this.cbVisaRid.Name = "cbVisaRid";
            this.cbVisaRid.Size = new System.Drawing.Size(216, 21);
            this.cbVisaRid.TabIndex = 4;
            this.cbVisaRid.SelectedIndexChanged += new System.EventHandler(this.cbVisaRid_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Välj resa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reseinformation:";
            // 
            // btnGodkann
            // 
            this.btnGodkann.Location = new System.Drawing.Point(16, 192);
            this.btnGodkann.Name = "btnGodkann";
            this.btnGodkann.Size = new System.Drawing.Size(75, 23);
            this.btnGodkann.TabIndex = 28;
            this.btnGodkann.Text = "Godkänn";
            this.btnGodkann.UseVisualStyleBackColor = true;
            this.btnGodkann.Click += new System.EventHandler(this.btnGodkann_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ersättning:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Förskott:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Avresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Hemresa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Land:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Traktamente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(351, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Mat:";
            // 
            // Uppdrag
            // 
            this.Uppdrag.AutoSize = true;
            this.Uppdrag.Location = new System.Drawing.Point(490, 152);
            this.Uppdrag.Name = "Uppdrag";
            this.Uppdrag.Size = new System.Drawing.Size(51, 13);
            this.Uppdrag.TabIndex = 42;
            this.Uppdrag.Text = "Uppdrag:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Utgifter";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(617, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Semesterdagar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Avslå";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSokande
            // 
            this.tbSokande.Location = new System.Drawing.Point(90, 79);
            this.tbSokande.Name = "tbSokande";
            this.tbSokande.Size = new System.Drawing.Size(142, 20);
            this.tbSokande.TabIndex = 54;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(90, 104);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(142, 20);
            this.tbId.TabIndex = 55;
            // 
            // tbErsattning
            // 
            this.tbErsattning.Location = new System.Drawing.Point(90, 127);
            this.tbErsattning.Name = "tbErsattning";
            this.tbErsattning.Size = new System.Drawing.Size(142, 20);
            this.tbErsattning.TabIndex = 56;
            // 
            // tbForskott
            // 
            this.tbForskott.Location = new System.Drawing.Point(90, 152);
            this.tbForskott.Name = "tbForskott";
            this.tbForskott.Size = new System.Drawing.Size(142, 20);
            this.tbForskott.TabIndex = 57;
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(354, 167);
            this.tbMat.Multiline = true;
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(120, 128);
            this.tbMat.TabIndex = 58;
            // 
            // tbUppdrag
            // 
            this.tbUppdrag.Location = new System.Drawing.Point(493, 168);
            this.tbUppdrag.Multiline = true;
            this.tbUppdrag.Name = "tbUppdrag";
            this.tbUppdrag.Size = new System.Drawing.Size(120, 128);
            this.tbUppdrag.TabIndex = 59;
            // 
            // tbSem
            // 
            this.tbSem.Location = new System.Drawing.Point(620, 167);
            this.tbSem.Multiline = true;
            this.tbSem.Name = "tbSem";
            this.tbSem.Size = new System.Drawing.Size(120, 128);
            this.tbSem.TabIndex = 60;
            // 
            // tbAvresa
            // 
            this.tbAvresa.Location = new System.Drawing.Point(396, 66);
            this.tbAvresa.Name = "tbAvresa";
            this.tbAvresa.Size = new System.Drawing.Size(102, 20);
            this.tbAvresa.TabIndex = 61;
            // 
            // tbHemresa
            // 
            this.tbHemresa.Location = new System.Drawing.Point(396, 85);
            this.tbHemresa.Name = "tbHemresa";
            this.tbHemresa.Size = new System.Drawing.Size(102, 20);
            this.tbHemresa.TabIndex = 62;
            // 
            // tbLand
            // 
            this.tbLand.Location = new System.Drawing.Point(583, 62);
            this.tbLand.Name = "tbLand";
            this.tbLand.Size = new System.Drawing.Size(115, 20);
            this.tbLand.TabIndex = 63;
            // 
            // tbTrak
            // 
            this.tbTrak.Location = new System.Drawing.Point(583, 82);
            this.tbTrak.Name = "tbTrak";
            this.tbTrak.Size = new System.Drawing.Size(115, 20);
            this.tbTrak.TabIndex = 64;
            // 
            // lwUtgifter
            // 
            this.lwUtgifter.Location = new System.Drawing.Point(353, 348);
            this.lwUtgifter.Name = "lwUtgifter";
            this.lwUtgifter.Size = new System.Drawing.Size(478, 306);
            this.lwUtgifter.TabIndex = 65;
            this.lwUtgifter.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 704);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Totalsumma:";
            // 
            // tbTotalsumma
            // 
            this.tbTotalsumma.Location = new System.Drawing.Point(543, 701);
            this.tbTotalsumma.Name = "tbTotalsumma";
            this.tbTotalsumma.Size = new System.Drawing.Size(155, 20);
            this.tbTotalsumma.TabIndex = 67;
            // 
            // Ansökningshantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 774);
            this.Controls.Add(this.tbTotalsumma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lwUtgifter);
            this.Controls.Add(this.tbTrak);
            this.Controls.Add(this.tbLand);
            this.Controls.Add(this.tbHemresa);
            this.Controls.Add(this.tbAvresa);
            this.Controls.Add(this.tbSem);
            this.Controls.Add(this.tbUppdrag);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.tbForskott);
            this.Controls.Add(this.tbErsattning);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbSokande);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Uppdrag);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGodkann);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVisaRid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVisaAnsid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ansökningshantering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ansökningshantering";
            this.Load += new System.EventHandler(this.Ansökningshantering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVisaAnsid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVisaRid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGodkann;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Uppdrag;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSokande;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbErsattning;
        private System.Windows.Forms.TextBox tbForskott;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.TextBox tbUppdrag;
        private System.Windows.Forms.TextBox tbSem;
        private System.Windows.Forms.TextBox tbAvresa;
        private System.Windows.Forms.TextBox tbHemresa;
        private System.Windows.Forms.TextBox tbLand;
        private System.Windows.Forms.TextBox tbTrak;
        private System.Windows.Forms.ListView lwUtgifter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTotalsumma;
    }
}