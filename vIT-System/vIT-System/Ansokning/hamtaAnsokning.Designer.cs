namespace vIT_System.Rapport
{
    partial class hamtaAnsokning
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
            this.gridAnsokning = new System.Windows.Forms.DataGridView();
            this.btnAnsokning = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnsokning)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAnsokning
            // 
            this.gridAnsokning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnsokning.Location = new System.Drawing.Point(12, 21);
            this.gridAnsokning.Name = "gridAnsokning";
            this.gridAnsokning.Size = new System.Drawing.Size(535, 219);
            this.gridAnsokning.TabIndex = 0;
            // 
            // btnAnsokning
            // 
            this.btnAnsokning.Location = new System.Drawing.Point(220, 312);
            this.btnAnsokning.Name = "btnAnsokning";
            this.btnAnsokning.Size = new System.Drawing.Size(119, 23);
            this.btnAnsokning.TabIndex = 1;
            this.btnAnsokning.Text = "Se ansökningar";
            this.btnAnsokning.UseVisualStyleBackColor = true;
            this.btnAnsokning.Click += new System.EventHandler(this.button1_Click);
            // 
            // hamtaAnsokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 388);
            this.Controls.Add(this.btnAnsokning);
            this.Controls.Add(this.gridAnsokning);
            this.Name = "hamtaAnsokning";
            this.Text = "hamtaAnsokning";
            ((System.ComponentModel.ISupportInitialize)(this.gridAnsokning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAnsokning;
        private System.Windows.Forms.Button btnAnsokning;

    }
}