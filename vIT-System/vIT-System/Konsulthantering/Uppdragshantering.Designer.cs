namespace vIT_System
{
    partial class Uppdragshantering
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
            this.cbShowFid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUppdrag = new System.Windows.Forms.TextBox();
            this.btnRedigera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbShowFid
            // 
            this.cbShowFid.FormattingEnabled = true;
            this.cbShowFid.Location = new System.Drawing.Point(79, 65);
            this.cbShowFid.Name = "cbShowFid";
            this.cbShowFid.Size = new System.Drawing.Size(156, 21);
            this.cbShowFid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aktuella uppdrag ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lägg till nytt uppdrag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Namn:";
            // 
            // tbUppdrag
            // 
            this.tbUppdrag.Location = new System.Drawing.Point(79, 130);
            this.tbUppdrag.Multiline = true;
            this.tbUppdrag.Name = "tbUppdrag";
            this.tbUppdrag.Size = new System.Drawing.Size(156, 22);
            this.tbUppdrag.TabIndex = 19;
            // 
            // btnRedigera
            // 
            this.btnRedigera.Location = new System.Drawing.Point(160, 170);
            this.btnRedigera.Name = "btnRedigera";
            this.btnRedigera.Size = new System.Drawing.Size(75, 23);
            this.btnRedigera.TabIndex = 20;
            this.btnRedigera.Text = "Lägg till";
            this.btnRedigera.UseVisualStyleBackColor = true;
            this.btnRedigera.Click += new System.EventHandler(this.btnRedigera_Click);
            // 
            // Uppdragshantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 224);
            this.Controls.Add(this.btnRedigera);
            this.Controls.Add(this.tbUppdrag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbShowFid);
            this.Name = "Uppdragshantering";
            this.Text = "Uppdragshantering";
            this.Load += new System.EventHandler(this.Uppdragshantering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShowFid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUppdrag;
        private System.Windows.Forms.Button btnRedigera;
    }
}