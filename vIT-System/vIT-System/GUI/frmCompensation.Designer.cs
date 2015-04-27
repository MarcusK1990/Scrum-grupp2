namespace vIT_System.GUI
{
    partial class FrmCompensation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbForNamn = new System.Windows.Forms.TextBox();
            this.tbEfterNamn = new System.Windows.Forms.TextBox();
            this.dtpUtResa = new System.Windows.Forms.DateTimePicker();
            this.dtpHemResa = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBelopp = new System.Windows.Forms.TextBox();
            this.btnKvitto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValutaKurs = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbKvitto = new System.Windows.Forms.TextBox();
            this.lbUtgifter = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUtgiter = new System.Windows.Forms.Button();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAndaMal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSemesterdagar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbUppdrag = new System.Windows.Forms.ComboBox();
            this.lbResa = new System.Windows.Forms.ListBox();
            this.btnLaggTillResa = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cbLand = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbMiddag = new System.Windows.Forms.TextBox();
            this.tbLunch = new System.Windows.Forms.TextBox();
            this.tbFrukost = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groaupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTotalaUtgifter = new System.Windows.Forms.TextBox();
            this.tbTotalaAvdrag = new System.Windows.Forms.TextBox();
            this.tbTotalMilErsättning = new System.Windows.Forms.TextBox();
            this.tbTotalTraktamentesUtbetalning = new System.Windows.Forms.TextBox();
            this.tbTotalTraktamenteDagar = new System.Windows.Forms.TextBox();
            this.tbDagarBortRest = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnUppdateraSammanstallning = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAnsID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMilErsattning = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSparaUtkast = new System.Windows.Forms.Button();
            this.btnSkickaAnsokan = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.btnLaddaUtkast = new System.Windows.Forms.Button();
            this.btnMilErsättningPlus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groaupBox3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hemresa";
            // 
            // tbForNamn
            // 
            this.tbForNamn.Enabled = false;
            this.tbForNamn.Location = new System.Drawing.Point(389, 6);
            this.tbForNamn.Name = "tbForNamn";
            this.tbForNamn.Size = new System.Drawing.Size(155, 20);
            this.tbForNamn.TabIndex = 4;
            // 
            // tbEfterNamn
            // 
            this.tbEfterNamn.Enabled = false;
            this.tbEfterNamn.Location = new System.Drawing.Point(639, 6);
            this.tbEfterNamn.Name = "tbEfterNamn";
            this.tbEfterNamn.Size = new System.Drawing.Size(155, 20);
            this.tbEfterNamn.TabIndex = 5;
            // 
            // dtpUtResa
            // 
            this.dtpUtResa.Location = new System.Drawing.Point(67, 33);
            this.dtpUtResa.Name = "dtpUtResa";
            this.dtpUtResa.Size = new System.Drawing.Size(145, 20);
            this.dtpUtResa.TabIndex = 6;
            // 
            // dtpHemResa
            // 
            this.dtpHemResa.Location = new System.Drawing.Point(67, 64);
            this.dtpHemResa.Name = "dtpHemResa";
            this.dtpHemResa.Size = new System.Drawing.Size(145, 20);
            this.dtpHemResa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-Mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(156, 6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(155, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbBelopp
            // 
            this.tbBelopp.Location = new System.Drawing.Point(74, 36);
            this.tbBelopp.Name = "tbBelopp";
            this.tbBelopp.Size = new System.Drawing.Size(81, 20);
            this.tbBelopp.TabIndex = 11;
            // 
            // btnKvitto
            // 
            this.btnKvitto.Location = new System.Drawing.Point(6, 169);
            this.btnKvitto.Name = "btnKvitto";
            this.btnKvitto.Size = new System.Drawing.Size(75, 23);
            this.btnKvitto.TabIndex = 12;
            this.btnKvitto.Text = "Bifoga kvitto";
            this.btnKvitto.UseVisualStyleBackColor = true;
            this.btnKvitto.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValutaKurs);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbKvitto);
            this.groupBox1.Controls.Add(this.lbUtgifter);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnUtgiter);
            this.groupBox1.Controls.Add(this.cbValuta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbAndaMal);
            this.groupBox1.Controls.Add(this.btnKvitto);
            this.groupBox1.Controls.Add(this.tbBelopp);
            this.groupBox1.Location = new System.Drawing.Point(23, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 227);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utgifter";
            // 
            // lblValutaKurs
            // 
            this.lblValutaKurs.AutoSize = true;
            this.lblValutaKurs.Location = new System.Drawing.Point(213, 135);
            this.lblValutaKurs.Name = "lblValutaKurs";
            this.lblValutaKurs.Size = new System.Drawing.Size(98, 13);
            this.lblValutaKurs.TabIndex = 33;
            this.lblValutaKurs.Text = "Senaste valutakurs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Kvitto";
            // 
            // tbKvitto
            // 
            this.tbKvitto.Location = new System.Drawing.Point(74, 132);
            this.tbKvitto.Name = "tbKvitto";
            this.tbKvitto.Size = new System.Drawing.Size(81, 20);
            this.tbKvitto.TabIndex = 33;
            // 
            // lbUtgifter
            // 
            this.lbUtgifter.FormattingEnabled = true;
            this.lbUtgifter.Location = new System.Drawing.Point(222, 23);
            this.lbUtgifter.Name = "lbUtgifter";
            this.lbUtgifter.Size = new System.Drawing.Size(216, 95);
            this.lbUtgifter.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "SEK";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(291, 152);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(25, 13);
            this.labelTotal.TabIndex = 21;
            this.labelTotal.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Totala utgifter:";
            // 
            // btnUtgiter
            // 
            this.btnUtgiter.Location = new System.Drawing.Point(94, 169);
            this.btnUtgiter.Name = "btnUtgiter";
            this.btnUtgiter.Size = new System.Drawing.Size(75, 23);
            this.btnUtgiter.TabIndex = 18;
            this.btnUtgiter.Text = "Lägg till";
            this.btnUtgiter.UseVisualStyleBackColor = true;
            this.btnUtgiter.Click += new System.EventHandler(this.btnUtgiter_Click);
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(74, 102);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(81, 21);
            this.cbValuta.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valuta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ändamål";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Belopp";
            // 
            // tbAndaMal
            // 
            this.tbAndaMal.Location = new System.Drawing.Point(74, 67);
            this.tbAndaMal.Name = "tbAndaMal";
            this.tbAndaMal.Size = new System.Drawing.Size(81, 20);
            this.tbAndaMal.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Semesterdagar:";
            // 
            // tbSemesterdagar
            // 
            this.tbSemesterdagar.Location = new System.Drawing.Point(322, 38);
            this.tbSemesterdagar.Name = "tbSemesterdagar";
            this.tbSemesterdagar.Size = new System.Drawing.Size(60, 20);
            this.tbSemesterdagar.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbUppdrag);
            this.groupBox2.Controls.Add(this.lbResa);
            this.groupBox2.Controls.Add(this.btnLaggTillResa);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.cbLand);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.tbMiddag);
            this.groupBox2.Controls.Add(this.tbSemesterdagar);
            this.groupBox2.Controls.Add(this.dtpUtResa);
            this.groupBox2.Controls.Add(this.tbLunch);
            this.groupBox2.Controls.Add(this.tbFrukost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpHemResa);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(13, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 434);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resa";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(247, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "Uppdrag:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(137, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 26;
            this.button2.Text = "Ändra resa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbUppdrag
            // 
            this.cbUppdrag.FormattingEnabled = true;
            this.cbUppdrag.Location = new System.Drawing.Point(304, 9);
            this.cbUppdrag.MaxDropDownItems = 50;
            this.cbUppdrag.Name = "cbUppdrag";
            this.cbUppdrag.Size = new System.Drawing.Size(121, 21);
            this.cbUppdrag.TabIndex = 26;
            // 
            // lbResa
            // 
            this.lbResa.FormattingEnabled = true;
            this.lbResa.Location = new System.Drawing.Point(232, 90);
            this.lbResa.Name = "lbResa";
            this.lbResa.Size = new System.Drawing.Size(216, 95);
            this.lbResa.TabIndex = 24;
            this.lbResa.SelectedIndexChanged += new System.EventHandler(this.lbResa_SelectedIndexChanged);
            // 
            // btnLaggTillResa
            // 
            this.btnLaggTillResa.Location = new System.Drawing.Point(48, 160);
            this.btnLaggTillResa.Name = "btnLaggTillResa";
            this.btnLaggTillResa.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillResa.TabIndex = 23;
            this.btnLaggTillResa.Text = "Lägg till";
            this.btnLaggTillResa.UseVisualStyleBackColor = true;
            this.btnLaggTillResa.Click += new System.EventHandler(this.btnLaggTillResa_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(236, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Land:";
            // 
            // cbLand
            // 
            this.cbLand.FormattingEnabled = true;
            this.cbLand.Location = new System.Drawing.Point(293, 64);
            this.cbLand.MaxDropDownItems = 50;
            this.cbLand.Name = "cbLand";
            this.cbLand.Size = new System.Drawing.Size(121, 21);
            this.cbLand.TabIndex = 24;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 132);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 17;
            this.label25.Text = "Antal";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(156, 107);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Middag";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(106, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "Lunch";
            // 
            // tbMiddag
            // 
            this.tbMiddag.Location = new System.Drawing.Point(159, 129);
            this.tbMiddag.Name = "tbMiddag";
            this.tbMiddag.Size = new System.Drawing.Size(32, 20);
            this.tbMiddag.TabIndex = 12;
            // 
            // tbLunch
            // 
            this.tbLunch.Location = new System.Drawing.Point(113, 129);
            this.tbLunch.Name = "tbLunch";
            this.tbLunch.Size = new System.Drawing.Size(30, 20);
            this.tbLunch.TabIndex = 13;
            // 
            // tbFrukost
            // 
            this.tbFrukost.Location = new System.Drawing.Point(67, 129);
            this.tbFrukost.Name = "tbFrukost";
            this.tbFrukost.Size = new System.Drawing.Size(34, 20);
            this.tbFrukost.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Frukost";
            // 
            // groaupBox3
            // 
            this.groaupBox3.Controls.Add(this.tbTotalaUtgifter);
            this.groaupBox3.Controls.Add(this.tbTotalaAvdrag);
            this.groaupBox3.Controls.Add(this.tbTotalMilErsättning);
            this.groaupBox3.Controls.Add(this.tbTotalTraktamentesUtbetalning);
            this.groaupBox3.Controls.Add(this.tbTotalTraktamenteDagar);
            this.groaupBox3.Controls.Add(this.tbDagarBortRest);
            this.groaupBox3.Controls.Add(this.label26);
            this.groaupBox3.Controls.Add(this.label18);
            this.groaupBox3.Controls.Add(this.btnUppdateraSammanstallning);
            this.groaupBox3.Controls.Add(this.label21);
            this.groaupBox3.Controls.Add(this.label20);
            this.groaupBox3.Controls.Add(this.label19);
            this.groaupBox3.Controls.Add(this.label17);
            this.groaupBox3.Controls.Add(this.label15);
            this.groaupBox3.Location = new System.Drawing.Point(492, 38);
            this.groaupBox3.Name = "groaupBox3";
            this.groaupBox3.Size = new System.Drawing.Size(314, 269);
            this.groaupBox3.TabIndex = 17;
            this.groaupBox3.TabStop = false;
            this.groaupBox3.Text = "Traktamente";
            // 
            // tbTotalaUtgifter
            // 
            this.tbTotalaUtgifter.Enabled = false;
            this.tbTotalaUtgifter.Location = new System.Drawing.Point(215, 137);
            this.tbTotalaUtgifter.Name = "tbTotalaUtgifter";
            this.tbTotalaUtgifter.Size = new System.Drawing.Size(86, 20);
            this.tbTotalaUtgifter.TabIndex = 38;
            // 
            // tbTotalaAvdrag
            // 
            this.tbTotalaAvdrag.Enabled = false;
            this.tbTotalaAvdrag.Location = new System.Drawing.Point(215, 115);
            this.tbTotalaAvdrag.Name = "tbTotalaAvdrag";
            this.tbTotalaAvdrag.Size = new System.Drawing.Size(86, 20);
            this.tbTotalaAvdrag.TabIndex = 37;
            // 
            // tbTotalMilErsättning
            // 
            this.tbTotalMilErsättning.Enabled = false;
            this.tbTotalMilErsättning.Location = new System.Drawing.Point(215, 92);
            this.tbTotalMilErsättning.Name = "tbTotalMilErsättning";
            this.tbTotalMilErsättning.Size = new System.Drawing.Size(86, 20);
            this.tbTotalMilErsättning.TabIndex = 36;
            // 
            // tbTotalTraktamentesUtbetalning
            // 
            this.tbTotalTraktamentesUtbetalning.Enabled = false;
            this.tbTotalTraktamentesUtbetalning.Location = new System.Drawing.Point(215, 69);
            this.tbTotalTraktamentesUtbetalning.Name = "tbTotalTraktamentesUtbetalning";
            this.tbTotalTraktamentesUtbetalning.Size = new System.Drawing.Size(86, 20);
            this.tbTotalTraktamentesUtbetalning.TabIndex = 35;
            // 
            // tbTotalTraktamenteDagar
            // 
            this.tbTotalTraktamenteDagar.Enabled = false;
            this.tbTotalTraktamenteDagar.Location = new System.Drawing.Point(215, 47);
            this.tbTotalTraktamenteDagar.Name = "tbTotalTraktamenteDagar";
            this.tbTotalTraktamenteDagar.Size = new System.Drawing.Size(86, 20);
            this.tbTotalTraktamenteDagar.TabIndex = 34;
            // 
            // tbDagarBortRest
            // 
            this.tbDagarBortRest.Enabled = false;
            this.tbDagarBortRest.Location = new System.Drawing.Point(215, 25);
            this.tbDagarBortRest.Name = "tbDagarBortRest";
            this.tbDagarBortRest.Size = new System.Drawing.Size(86, 20);
            this.tbDagarBortRest.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Summa milersättning:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Totala avdrag:";
            // 
            // btnUppdateraSammanstallning
            // 
            this.btnUppdateraSammanstallning.Location = new System.Drawing.Point(9, 240);
            this.btnUppdateraSammanstallning.Name = "btnUppdateraSammanstallning";
            this.btnUppdateraSammanstallning.Size = new System.Drawing.Size(151, 23);
            this.btnUppdateraSammanstallning.TabIndex = 26;
            this.btnUppdateraSammanstallning.Text = "Uppdatera sammanställning";
            this.btnUppdateraSammanstallning.UseVisualStyleBackColor = true;
            this.btnUppdateraSammanstallning.Click += new System.EventHandler(this.btnUppdateraSammanstallning_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 201);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Total ersättning:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Totalt traktamente efter avdrag:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Antal traktamentesberättigade dagar:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Summa utgifter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Dagar bortrest:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Räkna ut Belopp * Land";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblAnsID
            // 
            this.lblAnsID.AutoSize = true;
            this.lblAnsID.Location = new System.Drawing.Point(91, 9);
            this.lblAnsID.Name = "lblAnsID";
            this.lblAnsID.Size = new System.Drawing.Size(0, 13);
            this.lblAnsID.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMilErsattning);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(501, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 56);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Milersättning";
            // 
            // tbMilErsattning
            // 
            this.tbMilErsattning.Location = new System.Drawing.Point(61, 27);
            this.tbMilErsattning.Name = "tbMilErsattning";
            this.tbMilErsattning.Size = new System.Drawing.Size(68, 20);
            this.tbMilErsattning.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Antal mil:";
            // 
            // btnSparaUtkast
            // 
            this.btnSparaUtkast.Location = new System.Drawing.Point(501, 443);
            this.btnSparaUtkast.Name = "btnSparaUtkast";
            this.btnSparaUtkast.Size = new System.Drawing.Size(75, 23);
            this.btnSparaUtkast.TabIndex = 28;
            this.btnSparaUtkast.Text = "Spara utkast";
            this.btnSparaUtkast.UseVisualStyleBackColor = true;
            this.btnSparaUtkast.Click += new System.EventHandler(this.btnSparaUtkast_Click);
            // 
            // btnSkickaAnsokan
            // 
            this.btnSkickaAnsokan.Location = new System.Drawing.Point(716, 431);
            this.btnSkickaAnsokan.Name = "btnSkickaAnsokan";
            this.btnSkickaAnsokan.Size = new System.Drawing.Size(109, 47);
            this.btnSkickaAnsokan.TabIndex = 29;
            this.btnSkickaAnsokan.Text = "Skicka ansökan";
            this.btnSkickaAnsokan.UseVisualStyleBackColor = true;
            this.btnSkickaAnsokan.Click += new System.EventHandler(this.btnSkickaAnsokan_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 13);
            this.label27.TabIndex = 23;
            this.label27.Text = "AnsökningsID";
            // 
            // btnLaddaUtkast
            // 
            this.btnLaddaUtkast.Location = new System.Drawing.Point(591, 443);
            this.btnLaddaUtkast.Name = "btnLaddaUtkast";
            this.btnLaddaUtkast.Size = new System.Drawing.Size(97, 23);
            this.btnLaddaUtkast.TabIndex = 31;
            this.btnLaddaUtkast.Text = "Hämta sparad";
            this.btnLaddaUtkast.UseVisualStyleBackColor = true;
            this.btnLaddaUtkast.Click += new System.EventHandler(this.btnLaddaUtkast_Click);
            // 
            // btnMilErsättningPlus
            // 
            this.btnMilErsättningPlus.Location = new System.Drawing.Point(636, 384);
            this.btnMilErsättningPlus.Name = "btnMilErsättningPlus";
            this.btnMilErsättningPlus.Size = new System.Drawing.Size(31, 23);
            this.btnMilErsättningPlus.TabIndex = 39;
            this.btnMilErsättningPlus.Text = "+";
            this.btnMilErsättningPlus.UseVisualStyleBackColor = true;
            this.btnMilErsättningPlus.Click += new System.EventHandler(this.btnMilErsättningPlus_Click);
            // 
            // FrmCompensation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 504);
            this.Controls.Add(this.btnMilErsättningPlus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAnsID);
            this.Controls.Add(this.btnLaddaUtkast);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnSkickaAnsokan);
            this.Controls.Add(this.btnSparaUtkast);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groaupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEfterNamn);
            this.Controls.Add(this.tbForNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCompensation";
            this.Text = "Ansökan om reseersättning";
            this.Load += new System.EventHandler(this.frmCompensation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groaupBox3.ResumeLayout(false);
            this.groaupBox3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbForNamn;
        private System.Windows.Forms.TextBox tbEfterNamn;
        private System.Windows.Forms.DateTimePicker dtpUtResa;
        private System.Windows.Forms.DateTimePicker dtpHemResa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBelopp;
        private System.Windows.Forms.Button btnKvitto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAndaMal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSemesterdagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUtgiter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groaupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbLand;
        private System.Windows.Forms.Button btnLaggTillResa;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMilErsattning;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUppdateraSammanstallning;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbFrukost;
        private System.Windows.Forms.TextBox tbLunch;
        private System.Windows.Forms.TextBox tbMiddag;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnSparaUtkast;
        private System.Windows.Forms.Button btnSkickaAnsokan;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnLaddaUtkast;
        private System.Windows.Forms.ListBox lbUtgifter;
        private System.Windows.Forms.ListBox lbResa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTotalTraktamenteDagar;
        private System.Windows.Forms.TextBox tbDagarBortRest;
        private System.Windows.Forms.TextBox tbTotalMilErsättning;
        private System.Windows.Forms.TextBox tbTotalTraktamentesUtbetalning;
        private System.Windows.Forms.TextBox tbTotalaUtgifter;
        private System.Windows.Forms.TextBox tbTotalaAvdrag;
        private System.Windows.Forms.TextBox tbKvitto;
        private System.Windows.Forms.Label lblAnsID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblValutaKurs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbUppdrag;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnMilErsättningPlus;
   
    }
}