namespace WindowsFormsApp3
{
    partial class frmMutfak
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
            this.lvGıdaListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDeğiştir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.txtGidaFiyati = new System.Windows.Forms.TextBox();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.rbAltkategori = new System.Windows.Forms.CheckBox();
            this.rbAnaKategori = new System.Windows.Forms.CheckBox();
            this.panelAnaKategori = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.afgsdg = new System.Windows.Forms.Label();
            this.TxtKategoriId = new System.Windows.Forms.TextBox();
            this.txtAçıklma = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.panelUrun = new System.Windows.Forms.Panel();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panelAnaKategori.SuspendLayout();
            this.panelUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvGıdaListesi
            // 
            this.lvGıdaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10});
            this.lvGıdaListesi.FullRowSelect = true;
            this.lvGıdaListesi.GridLines = true;
            this.lvGıdaListesi.HideSelection = false;
            this.lvGıdaListesi.Location = new System.Drawing.Point(331, 225);
            this.lvGıdaListesi.Name = "lvGıdaListesi";
            this.lvGıdaListesi.Size = new System.Drawing.Size(306, 252);
            this.lvGıdaListesi.TabIndex = 3;
            this.lvGıdaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGıdaListesi.View = System.Windows.Forms.View.Details;
            this.lvGıdaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGıdaListesi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Id";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UrunTurNo";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 57;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 2;
            this.columnHeader9.Text = "Urun Adı";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fiyat";
            this.columnHeader10.Width = 153;
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.HideSelection = false;
            this.lvKategoriler.Location = new System.Drawing.Point(74, 225);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(257, 252);
            this.lvKategoriler.TabIndex = 4;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TurId";
            this.columnHeader11.Width = 115;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Kategori";
            this.columnHeader12.Width = 145;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Açıklama";
            this.columnHeader13.Width = 150;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(74, 158);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(186, 61);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDeğiştir
            // 
            this.btnDeğiştir.Location = new System.Drawing.Point(266, 158);
            this.btnDeğiştir.Name = "btnDeğiştir";
            this.btnDeğiştir.Size = new System.Drawing.Size(167, 61);
            this.btnDeğiştir.TabIndex = 5;
            this.btnDeğiştir.Text = "Değiştir";
            this.btnDeğiştir.UseVisualStyleBackColor = true;
            this.btnDeğiştir.Click += new System.EventHandler(this.btnDeğiştir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(439, 158);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 61);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gıda Kategorisi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gıda Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gıda Adı :";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(102, 22);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(163, 21);
            this.cbKategoriler.TabIndex = 7;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // txtGidaFiyati
            // 
            this.txtGidaFiyati.Location = new System.Drawing.Point(102, 75);
            this.txtGidaFiyati.Name = "txtGidaFiyati";
            this.txtGidaFiyati.Size = new System.Drawing.Size(163, 20);
            this.txtGidaFiyati.TabIndex = 2;
            this.txtGidaFiyati.TextChanged += new System.EventHandler(this.txtGidaFiyati_TextChanged);
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Location = new System.Drawing.Point(102, 49);
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(147, 20);
            this.txtGidaAdi.TabIndex = 1;
            // 
            // rbAltkategori
            // 
            this.rbAltkategori.AutoSize = true;
            this.rbAltkategori.Location = new System.Drawing.Point(429, 10);
            this.rbAltkategori.Name = "rbAltkategori";
            this.rbAltkategori.Size = new System.Drawing.Size(73, 17);
            this.rbAltkategori.TabIndex = 9;
            this.rbAltkategori.Text = "Ürün Ekle";
            this.rbAltkategori.UseVisualStyleBackColor = true;
            this.rbAltkategori.CheckedChanged += new System.EventHandler(this.rbAltkategori_CheckedChanged);
            // 
            // rbAnaKategori
            // 
            this.rbAnaKategori.AutoSize = true;
            this.rbAnaKategori.Location = new System.Drawing.Point(535, 9);
            this.rbAnaKategori.Name = "rbAnaKategori";
            this.rbAnaKategori.Size = new System.Drawing.Size(115, 17);
            this.rbAnaKategori.TabIndex = 10;
            this.rbAnaKategori.Text = "Ürün Kategori Ekle";
            this.rbAnaKategori.UseVisualStyleBackColor = true;
            this.rbAnaKategori.CheckedChanged += new System.EventHandler(this.rbAnaKategori_CheckedChanged);
            // 
            // panelAnaKategori
            // 
            this.panelAnaKategori.Controls.Add(this.label5);
            this.panelAnaKategori.Controls.Add(this.afgsdg);
            this.panelAnaKategori.Controls.Add(this.TxtKategoriId);
            this.panelAnaKategori.Controls.Add(this.txtAçıklma);
            this.panelAnaKategori.Controls.Add(this.txtKategoriAd);
            this.panelAnaKategori.Location = new System.Drawing.Point(78, 39);
            this.panelAnaKategori.Name = "panelAnaKategori";
            this.panelAnaKategori.Size = new System.Drawing.Size(282, 113);
            this.panelAnaKategori.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklma :";
            // 
            // afgsdg
            // 
            this.afgsdg.AutoSize = true;
            this.afgsdg.Location = new System.Drawing.Point(41, 52);
            this.afgsdg.Name = "afgsdg";
            this.afgsdg.Size = new System.Drawing.Size(67, 13);
            this.afgsdg.TabIndex = 8;
            this.afgsdg.Text = "KategoriAdı :";
            // 
            // TxtKategoriId
            // 
            this.TxtKategoriId.Location = new System.Drawing.Point(253, 45);
            this.TxtKategoriId.Name = "TxtKategoriId";
            this.TxtKategoriId.Size = new System.Drawing.Size(26, 20);
            this.TxtKategoriId.TabIndex = 1;
            // 
            // txtAçıklma
            // 
            this.txtAçıklma.Location = new System.Drawing.Point(112, 71);
            this.txtAçıklma.Name = "txtAçıklma";
            this.txtAçıklma.Size = new System.Drawing.Size(163, 20);
            this.txtAçıklma.TabIndex = 2;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(112, 45);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(141, 20);
            this.txtKategoriAd.TabIndex = 1;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(243, 48);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(26, 20);
            this.txtUrunId.TabIndex = 1;
            // 
            // panelUrun
            // 
            this.panelUrun.Controls.Add(this.label2);
            this.panelUrun.Controls.Add(this.txtUrunId);
            this.panelUrun.Controls.Add(this.label3);
            this.panelUrun.Controls.Add(this.label1);
            this.panelUrun.Controls.Add(this.cbKategoriler);
            this.panelUrun.Controls.Add(this.txtGidaFiyati);
            this.panelUrun.Controls.Add(this.txtGidaAdi);
            this.panelUrun.Location = new System.Drawing.Point(368, 39);
            this.panelUrun.Name = "panelUrun";
            this.panelUrun.Size = new System.Drawing.Size(269, 113);
            this.panelUrun.TabIndex = 11;
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(640, 351);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(79, 60);
            this.btnÇıkış.TabIndex = 12;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(638, 417);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(81, 60);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 489);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panelUrun);
            this.Controls.Add(this.panelAnaKategori);
            this.Controls.Add(this.rbAnaKategori);
            this.Controls.Add(this.rbAltkategori);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDeğiştir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvKategoriler);
            this.Controls.Add(this.lvGıdaListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.Text = "frmMutfak";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panelAnaKategori.ResumeLayout(false);
            this.panelAnaKategori.PerformLayout();
            this.panelUrun.ResumeLayout(false);
            this.panelUrun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGıdaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDeğiştir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtGidaFiyati;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rbAnaKategori;
        private System.Windows.Forms.CheckBox rbAltkategori;
        private System.Windows.Forms.Panel panelAnaKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label afgsdg;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtAçıklma;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.TextBox TxtKategoriId;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnGeri;
    }
}