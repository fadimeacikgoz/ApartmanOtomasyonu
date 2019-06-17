namespace APARTMAN_OTOMASYONU11
{
    partial class FrmBilgileriGoster
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
            this.BtnBilgileriGoster = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBilgileriGoster
            // 
            this.BtnBilgileriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnBilgileriGoster.Location = new System.Drawing.Point(3, 12);
            this.BtnBilgileriGoster.Name = "BtnBilgileriGoster";
            this.BtnBilgileriGoster.Size = new System.Drawing.Size(136, 31);
            this.BtnBilgileriGoster.TabIndex = 1;
            this.BtnBilgileriGoster.Text = "Bilgileri goster";
            this.BtnBilgileriGoster.UseVisualStyleBackColor = false;
            this.BtnBilgileriGoster.Click += new System.EventHandler(this.BtnBilgileriGoster_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(302, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(445, 219);
            this.dataGridView2.TabIndex = 23;
            // 
            // FrmBilgileriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(845, 343);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnBilgileriGoster);
            this.Name = "FrmBilgileriGoster";
            this.Text = "Daireler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBilgileriGoster;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}