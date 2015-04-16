namespace vIT_System
{
    partial class Konsulthantering
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
            this.listvKonsulter = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbFörnamn = new System.Windows.Forms.TextBox();
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.tbEfternamn = new System.Windows.Forms.TextBox();
            this.tbPersonnummer = new System.Windows.Forms.TextBox();
            this.tbMailadress = new System.Windows.Forms.TextBox();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblPersonnummer = new System.Windows.Forms.Label();
            this.lblMailadress = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbLösenord = new System.Windows.Forms.TextBox();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.cbÄrChef = new System.Windows.Forms.CheckBox();
            this.btnRedigera = new System.Windows.Forms.Button();
            this.btnRadera = new System.Windows.Forms.Button();
            this.btnNyAnställd = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listvKonsulter
            // 
            this.listvKonsulter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listvKonsulter.FullRowSelect = true;
            this.listvKonsulter.Location = new System.Drawing.Point(12, 12);
            this.listvKonsulter.MultiSelect = false;
            this.listvKonsulter.Name = "listvKonsulter";
            this.listvKonsulter.Size = new System.Drawing.Size(268, 331);
            this.listvKonsulter.TabIndex = 0;
            this.listvKonsulter.UseCompatibleStateImageBehavior = false;
            this.listvKonsulter.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Förnamn";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Efternamn";
            this.columnHeader3.Width = 120;
            // 
            // tbFörnamn
            // 
            this.tbFörnamn.Location = new System.Drawing.Point(372, 38);
            this.tbFörnamn.Name = "tbFörnamn";
            this.tbFörnamn.Size = new System.Drawing.Size(240, 20);
            this.tbFörnamn.TabIndex = 1;
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(315, 41);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(51, 13);
            this.lblFörnamn.TabIndex = 2;
            this.lblFörnamn.Text = "Förnamn:";
            // 
            // tbEfternamn
            // 
            this.tbEfternamn.Location = new System.Drawing.Point(372, 64);
            this.tbEfternamn.Name = "tbEfternamn";
            this.tbEfternamn.Size = new System.Drawing.Size(240, 20);
            this.tbEfternamn.TabIndex = 1;
            // 
            // tbPersonnummer
            // 
            this.tbPersonnummer.Location = new System.Drawing.Point(372, 90);
            this.tbPersonnummer.Name = "tbPersonnummer";
            this.tbPersonnummer.Size = new System.Drawing.Size(240, 20);
            this.tbPersonnummer.TabIndex = 1;
            // 
            // tbMailadress
            // 
            this.tbMailadress.Location = new System.Drawing.Point(372, 116);
            this.tbMailadress.Name = "tbMailadress";
            this.tbMailadress.Size = new System.Drawing.Size(240, 20);
            this.tbMailadress.TabIndex = 1;
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(308, 67);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(58, 13);
            this.lblEfternamn.TabIndex = 2;
            this.lblEfternamn.Text = "Efternamn:";
            // 
            // lblPersonnummer
            // 
            this.lblPersonnummer.AutoSize = true;
            this.lblPersonnummer.Location = new System.Drawing.Point(286, 93);
            this.lblPersonnummer.Name = "lblPersonnummer";
            this.lblPersonnummer.Size = new System.Drawing.Size(80, 13);
            this.lblPersonnummer.TabIndex = 2;
            this.lblPersonnummer.Text = "Personnummer:";
            // 
            // lblMailadress
            // 
            this.lblMailadress.AutoSize = true;
            this.lblMailadress.Location = new System.Drawing.Point(306, 119);
            this.lblMailadress.Name = "lblMailadress";
            this.lblMailadress.Size = new System.Drawing.Size(60, 13);
            this.lblMailadress.TabIndex = 2;
            this.lblMailadress.Text = "Mailadress:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(372, 12);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(240, 20);
            this.tbId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(345, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            // 
            // tbLösenord
            // 
            this.tbLösenord.Location = new System.Drawing.Point(372, 142);
            this.tbLösenord.Name = "tbLösenord";
            this.tbLösenord.Size = new System.Drawing.Size(240, 20);
            this.tbLösenord.TabIndex = 1;
            this.tbLösenord.UseSystemPasswordChar = true;
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.Location = new System.Drawing.Point(312, 145);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(54, 13);
            this.lblLösenord.TabIndex = 2;
            this.lblLösenord.Text = "Lösenord:";
            // 
            // cbÄrChef
            // 
            this.cbÄrChef.AutoSize = true;
            this.cbÄrChef.Location = new System.Drawing.Point(372, 168);
            this.cbÄrChef.Name = "cbÄrChef";
            this.cbÄrChef.Size = new System.Drawing.Size(60, 17);
            this.cbÄrChef.TabIndex = 3;
            this.cbÄrChef.Text = "är Chef";
            this.cbÄrChef.UseVisualStyleBackColor = true;
            // 
            // btnRedigera
            // 
            this.btnRedigera.Location = new System.Drawing.Point(12, 349);
            this.btnRedigera.Name = "btnRedigera";
            this.btnRedigera.Size = new System.Drawing.Size(75, 23);
            this.btnRedigera.TabIndex = 4;
            this.btnRedigera.Text = "Redigera";
            this.btnRedigera.UseVisualStyleBackColor = true;
            this.btnRedigera.Click += new System.EventHandler(this.btnRedigera_Click);
            // 
            // btnRadera
            // 
            this.btnRadera.Location = new System.Drawing.Point(12, 407);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(75, 23);
            this.btnRadera.TabIndex = 5;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // btnNyAnställd
            // 
            this.btnNyAnställd.Location = new System.Drawing.Point(12, 378);
            this.btnNyAnställd.Name = "btnNyAnställd";
            this.btnNyAnställd.Size = new System.Drawing.Size(75, 23);
            this.btnNyAnställd.TabIndex = 5;
            this.btnNyAnställd.Text = "Ny anställd";
            this.btnNyAnställd.UseVisualStyleBackColor = true;
            this.btnNyAnställd.Click += new System.EventHandler(this.btnNyAnställd_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(512, 407);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(100, 23);
            this.btnSpara.TabIndex = 5;
            this.btnSpara.Text = "Spara ändringar";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // Konsulthantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnNyAnställd);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.btnRedigera);
            this.Controls.Add(this.cbÄrChef);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.lblMailadress);
            this.Controls.Add(this.lblPersonnummer);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblFörnamn);
            this.Controls.Add(this.tbLösenord);
            this.Controls.Add(this.tbMailadress);
            this.Controls.Add(this.tbPersonnummer);
            this.Controls.Add(this.tbEfternamn);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbFörnamn);
            this.Controls.Add(this.listvKonsulter);
            this.Name = "Konsulthantering";
            this.Text = "Konsulthantering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listvKonsulter;
        private System.Windows.Forms.TextBox tbFörnamn;
        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.TextBox tbEfternamn;
        private System.Windows.Forms.TextBox tbPersonnummer;
        private System.Windows.Forms.TextBox tbMailadress;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Label lblPersonnummer;
        private System.Windows.Forms.Label lblMailadress;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbLösenord;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.CheckBox cbÄrChef;
        private System.Windows.Forms.Button btnRedigera;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Button btnNyAnställd;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}