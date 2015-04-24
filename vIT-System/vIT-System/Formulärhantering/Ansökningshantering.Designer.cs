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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lwUppdrag = new System.Windows.Forms.ListView();
            this.lwUtgifter = new System.Windows.Forms.ListView();
            this.Uppdrag = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lwSem = new System.Windows.Forms.ListView();
            this.label17 = new System.Windows.Forms.Label();
            this.lwSokande = new System.Windows.Forms.ListView();
            this.lwId = new System.Windows.Forms.ListView();
            this.lwErsattning = new System.Windows.Forms.ListView();
            this.lwForskott = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label10.Location = new System.Drawing.Point(487, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Land:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Traktamente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Totalsumma:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Mat:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Summa:";
            // 
            // lwUppdrag
            // 
            this.lwUppdrag.Location = new System.Drawing.Point(493, 167);
            this.lwUppdrag.Name = "lwUppdrag";
            this.lwUppdrag.Size = new System.Drawing.Size(121, 138);
            this.lwUppdrag.TabIndex = 40;
            this.lwUppdrag.UseCompatibleStateImageBehavior = false;
            // 
            // lwUtgifter
            // 
            this.lwUtgifter.Location = new System.Drawing.Point(341, 348);
            this.lwUtgifter.Name = "lwUtgifter";
            this.lwUtgifter.Size = new System.Drawing.Size(511, 112);
            this.lwUtgifter.TabIndex = 41;
            this.lwUtgifter.UseCompatibleStateImageBehavior = false;
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
            this.label15.Location = new System.Drawing.Point(339, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Utgifter:";
            // 
            // lwSem
            // 
            this.lwSem.Location = new System.Drawing.Point(620, 167);
            this.lwSem.Name = "lwSem";
            this.lwSem.Size = new System.Drawing.Size(121, 138);
            this.lwSem.TabIndex = 45;
            this.lwSem.UseCompatibleStateImageBehavior = false;
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
            // lwSokande
            // 
            this.lwSokande.Location = new System.Drawing.Point(72, 77);
            this.lwSokande.Name = "lwSokande";
            this.lwSokande.Size = new System.Drawing.Size(198, 18);
            this.lwSokande.TabIndex = 47;
            this.lwSokande.UseCompatibleStateImageBehavior = false;
            // 
            // lwId
            // 
            this.lwId.Location = new System.Drawing.Point(72, 101);
            this.lwId.Name = "lwId";
            this.lwId.Size = new System.Drawing.Size(198, 18);
            this.lwId.TabIndex = 48;
            this.lwId.UseCompatibleStateImageBehavior = false;
            // 
            // lwErsattning
            // 
            this.lwErsattning.Location = new System.Drawing.Point(72, 127);
            this.lwErsattning.Name = "lwErsattning";
            this.lwErsattning.Size = new System.Drawing.Size(198, 18);
            this.lwErsattning.TabIndex = 49;
            this.lwErsattning.UseCompatibleStateImageBehavior = false;
            // 
            // lwForskott
            // 
            this.lwForskott.Location = new System.Drawing.Point(72, 152);
            this.lwForskott.Name = "lwForskott";
            this.lwForskott.Size = new System.Drawing.Size(198, 18);
            this.lwForskott.TabIndex = 50;
            this.lwForskott.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(342, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(145, 137);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(735, 463);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Summa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Avslå";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ansökningshantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lwForskott);
            this.Controls.Add(this.lwErsattning);
            this.Controls.Add(this.lwId);
            this.Controls.Add(this.lwSokande);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lwSem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Uppdrag);
            this.Controls.Add(this.lwUtgifter);
            this.Controls.Add(this.lwUppdrag);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
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
            this.Name = "Ansökningshantering";
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lwUppdrag;
        private System.Windows.Forms.ListView lwUtgifter;
        private System.Windows.Forms.Label Uppdrag;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView lwSem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView lwSokande;
        private System.Windows.Forms.ListView lwId;
        private System.Windows.Forms.ListView lwErsattning;
        private System.Windows.Forms.ListView lwForskott;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}