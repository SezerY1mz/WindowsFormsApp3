namespace WindowsFormsApp3
{
    partial class frmSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDegiştir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonel = new System.Windows.Forms.ComboBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBilgiDeğiştir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbGorev = new System.Windows.Forms.ComboBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtGorevId2 = new System.Windows.Forms.TextBox();
            this.txtpersonelıD = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeğiştir2 = new System.Windows.Forms.Button();
            this.txtYeniSifreTekrar2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYeniSifre2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDegiştir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPersonel);
            this.groupBox1.Controls.Add(this.txtYeniSifreTekrar);
            this.groupBox1.Controls.Add(this.txtPersonelId);
            this.groupBox1.Controls.Add(this.txtYeniSifre);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDegiştir
            // 
            this.btnDegiştir.Location = new System.Drawing.Point(38, 159);
            this.btnDegiştir.Name = "btnDegiştir";
            this.btnDegiştir.Size = new System.Drawing.Size(104, 79);
            this.btnDegiştir.TabIndex = 3;
            this.btnDegiştir.Text = "Değiştir";
            this.btnDegiştir.UseVisualStyleBackColor = true;
            this.btnDegiştir.Click += new System.EventHandler(this.btnDegiştir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "T Yeni Şifre";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Şifre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPersonel
            // 
            this.cbPersonel.FormattingEnabled = true;
            this.cbPersonel.Location = new System.Drawing.Point(6, 49);
            this.cbPersonel.Name = "cbPersonel";
            this.cbPersonel.Size = new System.Drawing.Size(157, 21);
            this.cbPersonel.TabIndex = 1;
            this.cbPersonel.SelectedIndexChanged += new System.EventHandler(this.cbPersonel_SelectedIndexChanged);
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(94, 102);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifreTekrar.TabIndex = 0;
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(169, 50);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(25, 20);
            this.txtPersonelId.TabIndex = 0;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(94, 76);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnBilgiDeğiştir);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.cbGorev);
            this.groupBox2.Controls.Add(this.btnYeni);
            this.groupBox2.Controls.Add(this.txtGorevId2);
            this.groupBox2.Controls.Add(this.txtpersonelıD);
            this.groupBox2.Controls.Add(this.txtSifreTekrar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Location = new System.Drawing.Point(262, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 390);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(25, 305);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 79);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBilgiDeğiştir
            // 
            this.btnBilgiDeğiştir.Location = new System.Drawing.Point(165, 305);
            this.btnBilgiDeğiştir.Name = "btnBilgiDeğiştir";
            this.btnBilgiDeğiştir.Size = new System.Drawing.Size(134, 79);
            this.btnBilgiDeğiştir.TabIndex = 3;
            this.btnBilgiDeğiştir.Text = "Değiştir";
            this.btnBilgiDeğiştir.UseVisualStyleBackColor = true;
            this.btnBilgiDeğiştir.Click += new System.EventHandler(this.btnBilgiDeğiştir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(165, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 79);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbGorev
            // 
            this.cbGorev.FormattingEnabled = true;
            this.cbGorev.Location = new System.Drawing.Point(155, 159);
            this.cbGorev.Name = "cbGorev";
            this.cbGorev.Size = new System.Drawing.Size(144, 21);
            this.cbGorev.TabIndex = 1;
            this.cbGorev.SelectedIndexChanged += new System.EventHandler(this.cbGorev_SelectedIndexChanged);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(25, 220);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(134, 79);
            this.btnYeni.TabIndex = 3;
            this.btnYeni.Text = "+Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtGorevId2
            // 
            this.txtGorevId2.Location = new System.Drawing.Point(295, 157);
            this.txtGorevId2.Name = "txtGorevId2";
            this.txtGorevId2.Size = new System.Drawing.Size(25, 20);
            this.txtGorevId2.TabIndex = 0;
            // 
            // txtpersonelıD
            // 
            this.txtpersonelıD.Location = new System.Drawing.Point(299, 50);
            this.txtpersonelıD.Name = "txtpersonelıD";
            this.txtpersonelıD.Size = new System.Drawing.Size(21, 20);
            this.txtpersonelıD.TabIndex = 0;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(155, 131);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(144, 20);
            this.txtSifreTekrar.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Görevi";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Şifre Tekrar";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(155, 105);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(144, 20);
            this.txtSifre.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(155, 76);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(144, 20);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(155, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(144, 20);
            this.txtAd.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeğiştir2);
            this.groupBox3.Controls.Add(this.txtYeniSifreTekrar2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtYeniSifre2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(612, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 275);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnDeğiştir2
            // 
            this.btnDeğiştir2.Location = new System.Drawing.Point(45, 169);
            this.btnDeğiştir2.Name = "btnDeğiştir2";
            this.btnDeğiştir2.Size = new System.Drawing.Size(104, 79);
            this.btnDeğiştir2.TabIndex = 3;
            this.btnDeğiştir2.Text = "Değiştir";
            this.btnDeğiştir2.UseVisualStyleBackColor = true;
            this.btnDeğiştir2.Click += new System.EventHandler(this.btnDeğiştir2_Click);
            // 
            // txtYeniSifreTekrar2
            // 
            this.txtYeniSifreTekrar2.Location = new System.Drawing.Point(100, 108);
            this.txtYeniSifreTekrar2.Name = "txtYeniSifreTekrar2";
            this.txtYeniSifreTekrar2.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifreTekrar2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "T Yeni Şifre";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtYeniSifre2
            // 
            this.txtYeniSifre2.Location = new System.Drawing.Point(100, 79);
            this.txtYeniSifre2.Name = "txtYeniSifre2";
            this.txtYeniSifre2.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Yeni Şifre";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvPersoneller
            // 
            this.lvPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvPersoneller.FullRowSelect = true;
            this.lvPersoneller.GridLines = true;
            this.lvPersoneller.HideSelection = false;
            this.lvPersoneller.Location = new System.Drawing.Point(6, 12);
            this.lvPersoneller.Name = "lvPersoneller";
            this.lvPersoneller.Size = new System.Drawing.Size(226, 109);
            this.lvPersoneller.TabIndex = 1;
            this.lvPersoneller.UseCompatibleStateImageBehavior = false;
            this.lvPersoneller.View = System.Windows.Forms.View.Details;
            this.lvPersoneller.SelectedIndexChanged += new System.EventHandler(this.lvPersoneller_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PersonelId";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PersonelGörevId";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Görev";
            this.columnHeader6.Width = 69;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ad";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Soyad";
            this.columnHeader8.Width = 98;
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(103, 381);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(79, 60);
            this.btnÇıkış.TabIndex = 6;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(18, 381);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(79, 60);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvPersoneller);
            this.groupBox4.Location = new System.Drawing.Point(588, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 127);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(28, 14);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(61, 13);
            this.lblBilgi.TabIndex = 9;
            this.lblBilgi.Text = "Giriş Yapan";
            this.lblBilgi.Click += new System.EventHandler(this.lblBilgi_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 453);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonel;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Button btnDegiştir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBilgiDeğiştir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtGorevId2;
        private System.Windows.Forms.TextBox txtpersonelıD;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnDeğiştir2;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYeniSifre2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbGorev;
        private System.Windows.Forms.Label lblBilgi;
    }
}