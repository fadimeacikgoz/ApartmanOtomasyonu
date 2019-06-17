namespace APARTMAN_OTOMASYONU11
{
    partial class FrmAdmin
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.FrnAdmin = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(185, 218);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 31);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Giriş Yap ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 97);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Adı :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(101, 167);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şifre:";
            // 
            // TxtKullanıcıAdı
            // 
            this.TxtKullanıcıAdı.Location = new System.Drawing.Point(160, 94);
            this.TxtKullanıcıAdı.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtKullanıcıAdı.Name = "TxtKullanıcıAdı";
            this.TxtKullanıcıAdı.Size = new System.Drawing.Size(159, 20);
            this.TxtKullanıcıAdı.TabIndex = 2;
            this.TxtKullanıcıAdı.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(160, 160);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(159, 20);
            this.TxtSifre.TabIndex = 2;
            // 
            // FrnAdmin
            // 
            this.FrnAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FrnAdmin.Appearance.Options.UseFont = true;
            this.FrnAdmin.Location = new System.Drawing.Point(129, 44);
            this.FrnAdmin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FrnAdmin.Name = "FrnAdmin";
            this.FrnAdmin.Size = new System.Drawing.Size(235, 23);
            this.FrnAdmin.TabIndex = 1;
            this.FrnAdmin.Text = "APARTMAN  OTOMASYONU ";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 362);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanıcıAdı);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.FrnAdmin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtKullanıcıAdı;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl FrnAdmin;
    }
}

