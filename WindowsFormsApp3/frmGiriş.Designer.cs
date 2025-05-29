namespace WindowsFormsApp3
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnÇıkıs = new System.Windows.Forms.Button();
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(297, 188);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 47);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnÇıkıs
            // 
            this.btnÇıkıs.Location = new System.Drawing.Point(424, 188);
            this.btnÇıkıs.Name = "btnÇıkıs";
            this.btnÇıkıs.Size = new System.Drawing.Size(60, 47);
            this.btnÇıkıs.TabIndex = 0;
            this.btnÇıkıs.Text = "Çkış";
            this.btnÇıkıs.UseVisualStyleBackColor = true;
            this.btnÇıkıs.Click += new System.EventHandler(this.btnÇıkıs_Click);
            // 
            // cbKullanici
            // 
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.Location = new System.Drawing.Point(297, 135);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(187, 21);
            this.cbKullanici.TabIndex = 1;
            this.cbKullanici.SelectedIndexChanged += new System.EventHandler(this.cbKullanici_SelectedIndexChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(297, 162);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(187, 20);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // FrmGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.cbKullanici);
            this.Controls.Add(this.btnÇıkıs);
            this.Controls.Add(this.btnGiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetlişi Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnÇıkıs;
        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

