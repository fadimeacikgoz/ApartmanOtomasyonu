namespace APARTMAN_OTOMASYONU11
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.BtnDaireler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBorclar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKişiBilgileri = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFotolar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHakında = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCıkıs = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnDaireler
            // 
            this.BtnDaireler.Image = ((System.Drawing.Image)(resources.GetObject("BtnDaireler.Image")));
            this.BtnDaireler.Location = new System.Drawing.Point(12, 42);
            this.BtnDaireler.Name = "BtnDaireler";
            this.BtnDaireler.Size = new System.Drawing.Size(125, 42);
            this.BtnDaireler.TabIndex = 0;
            this.BtnDaireler.Text = "Daireler";
            this.BtnDaireler.Click += new System.EventHandler(this.BtnDaireler_Click);
            // 
            // BtnBorclar
            // 
            this.BtnBorclar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorclar.Image")));
            this.BtnBorclar.Location = new System.Drawing.Point(188, 42);
            this.BtnBorclar.Name = "BtnBorclar";
            this.BtnBorclar.Size = new System.Drawing.Size(125, 42);
            this.BtnBorclar.TabIndex = 1;
            this.BtnBorclar.Text = "Borclar";
            this.BtnBorclar.Click += new System.EventHandler(this.BtnBorclar_Click);
            // 
            // BtnKişiBilgileri
            // 
            this.BtnKişiBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("BtnKişiBilgileri.Image")));
            this.BtnKişiBilgileri.Location = new System.Drawing.Point(12, 96);
            this.BtnKişiBilgileri.Name = "BtnKişiBilgileri";
            this.BtnKişiBilgileri.Size = new System.Drawing.Size(125, 34);
            this.BtnKişiBilgileri.TabIndex = 2;
            this.BtnKişiBilgileri.Text = "KişiBilgileri";
            this.BtnKişiBilgileri.Click += new System.EventHandler(this.BtnKisiBilgileri);
            // 
            // BtnFotolar
            // 
            this.BtnFotolar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFotolar.Image")));
            this.BtnFotolar.Location = new System.Drawing.Point(188, 96);
            this.BtnFotolar.Name = "BtnFotolar";
            this.BtnFotolar.Size = new System.Drawing.Size(125, 34);
            this.BtnFotolar.TabIndex = 3;
            this.BtnFotolar.Text = "Fotolar";
            // 
            // BtnHakında
            // 
            this.BtnHakında.Image = ((System.Drawing.Image)(resources.GetObject("BtnHakında.Image")));
            this.BtnHakında.Location = new System.Drawing.Point(12, 155);
            this.BtnHakında.Name = "BtnHakında";
            this.BtnHakında.Size = new System.Drawing.Size(125, 33);
            this.BtnHakında.TabIndex = 4;
            this.BtnHakında.Text = "Hakkımızda";
            this.BtnHakında.Click += new System.EventHandler(this.BtnHakında_Click);
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.Image = ((System.Drawing.Image)(resources.GetObject("BtnCıkıs.Image")));
            this.BtnCıkıs.Location = new System.Drawing.Point(188, 155);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(125, 33);
            this.BtnCıkıs.TabIndex = 5;
            this.BtnCıkıs.Text = "Çıkış";
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1217, 261);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.BtnHakında);
            this.Controls.Add(this.BtnFotolar);
            this.Controls.Add(this.BtnKişiBilgileri);
            this.Controls.Add(this.BtnBorclar);
            this.Controls.Add(this.BtnDaireler);
            this.Name = "FrmAnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnDaireler;
        private DevExpress.XtraEditors.SimpleButton BtnBorclar;
        private DevExpress.XtraEditors.SimpleButton BtnKişiBilgileri;
        private DevExpress.XtraEditors.SimpleButton BtnFotolar;
        private DevExpress.XtraEditors.SimpleButton BtnHakında;
        private DevExpress.XtraEditors.SimpleButton BtnCıkıs;
    }
}