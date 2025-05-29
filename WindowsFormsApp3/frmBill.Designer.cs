namespace WindowsFormsApp3
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAdisyonId = new System.Windows.Forms.Label();
            this.gblIndirim = new System.Windows.Forms.GroupBox();
            this.txtIndirimTutarı = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkTicket = new System.Windows.Forms.CheckBox();
            this.chkKrediKartı = new System.Windows.Forms.CheckBox();
            this.chkNakit = new System.Windows.Forms.CheckBox();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapOzet = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gblIndirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvUrunler);
            this.groupBox1.Controls.Add(this.lblAdisyonId);
            this.groupBox1.Location = new System.Drawing.Point(54, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparişler";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(0, 13);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(335, 209);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.SelectedIndexChanged += new System.EventHandler(this.lvUrunler_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ÜrünAd";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ÜrünAdet";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 3;
            this.columnHeader6.Text = "Ürün Fiyat";
            this.columnHeader6.Width = 136;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 2;
            this.columnHeader7.Text = "Ürün Id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Satış Id";
            // 
            // lblAdisyonId
            // 
            this.lblAdisyonId.AutoSize = true;
            this.lblAdisyonId.Location = new System.Drawing.Point(91, -3);
            this.lblAdisyonId.Name = "lblAdisyonId";
            this.lblAdisyonId.Size = new System.Drawing.Size(35, 13);
            this.lblAdisyonId.TabIndex = 0;
            this.lblAdisyonId.Text = "label1";
            // 
            // gblIndirim
            // 
            this.gblIndirim.Controls.Add(this.txtIndirimTutarı);
            this.gblIndirim.Controls.Add(this.label10);
            this.gblIndirim.Location = new System.Drawing.Point(410, 135);
            this.gblIndirim.Name = "gblIndirim";
            this.gblIndirim.Size = new System.Drawing.Size(191, 127);
            this.gblIndirim.TabIndex = 0;
            this.gblIndirim.TabStop = false;
            this.gblIndirim.Text = "Özel Aktivite";
            this.gblIndirim.Visible = false;
            // 
            // txtIndirimTutarı
            // 
            this.txtIndirimTutarı.Location = new System.Drawing.Point(39, 56);
            this.txtIndirimTutarı.Name = "txtIndirimTutarı";
            this.txtIndirimTutarı.Size = new System.Drawing.Size(111, 20);
            this.txtIndirimTutarı.TabIndex = 0;
            this.txtIndirimTutarı.TextChanged += new System.EventHandler(this.txtIndirimTutarı_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "İndirim Tutar Giriniz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblKdv);
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblOdenecek);
            this.groupBox3.Controls.Add(this.lblIndirim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(54, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 116);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "AraToplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KDV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "TL";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(91, 47);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(13, 13);
            this.lblKdv.TabIndex = 0;
            this.lblKdv.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(91, 70);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(13, 13);
            this.lblToplamTutar.TabIndex = 0;
            this.lblToplamTutar.Text = "0";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(91, 94);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(13, 13);
            this.lblOdenecek.TabIndex = 0;
            this.lblOdenecek.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(91, 25);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(13, 13);
            this.lblIndirim.TabIndex = 0;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkIndirim);
            this.groupBox4.Location = new System.Drawing.Point(410, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 106);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(47, 50);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(92, 17);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "İndirim Uygula";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.Visible = false;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkTicket);
            this.groupBox5.Controls.Add(this.chkKrediKartı);
            this.groupBox5.Controls.Add(this.chkNakit);
            this.groupBox5.Location = new System.Drawing.Point(233, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 116);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ödeme Türleri";
            // 
            // chkTicket
            // 
            this.chkTicket.AutoSize = true;
            this.chkTicket.Location = new System.Drawing.Point(20, 71);
            this.chkTicket.Name = "chkTicket";
            this.chkTicket.Size = new System.Drawing.Size(56, 17);
            this.chkTicket.TabIndex = 0;
            this.chkTicket.Text = "Ticket";
            this.chkTicket.UseVisualStyleBackColor = true;
            this.chkTicket.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // chkKrediKartı
            // 
            this.chkKrediKartı.AutoSize = true;
            this.chkKrediKartı.Location = new System.Drawing.Point(20, 48);
            this.chkKrediKartı.Name = "chkKrediKartı";
            this.chkKrediKartı.Size = new System.Drawing.Size(74, 17);
            this.chkKrediKartı.TabIndex = 0;
            this.chkKrediKartı.Text = "Kredi Kartı";
            this.chkKrediKartı.UseVisualStyleBackColor = true;
            this.chkKrediKartı.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // chkNakit
            // 
            this.chkNakit.AutoSize = true;
            this.chkNakit.Location = new System.Drawing.Point(20, 25);
            this.chkNakit.Name = "chkNakit";
            this.chkNakit.Size = new System.Drawing.Size(51, 17);
            this.chkNakit.TabIndex = 0;
            this.chkNakit.Text = "Nakit";
            this.chkNakit.UseVisualStyleBackColor = true;
            this.chkNakit.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(148, 415);
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
            this.btnGeri.Location = new System.Drawing.Point(48, 415);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(81, 60);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnHesapOzet
            // 
            this.btnHesapOzet.Location = new System.Drawing.Point(419, 293);
            this.btnHesapOzet.Name = "btnHesapOzet";
            this.btnHesapOzet.Size = new System.Drawing.Size(173, 60);
            this.btnHesapOzet.TabIndex = 8;
            this.btnHesapOzet.Text = "Hessap Özetleri";
            this.btnHesapOzet.UseVisualStyleBackColor = true;
            this.btnHesapOzet.Click += new System.EventHandler(this.btnHesapOzet_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Location = new System.Drawing.Point(419, 359);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(173, 60);
            this.btnHesapKapat.TabIndex = 8;
            this.btnHesapKapat.Text = "Hesabı Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 479);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnHesapOzet);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.gblIndirim);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "hesap Ödeme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gblIndirim.ResumeLayout(false);
            this.gblIndirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gblIndirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.TextBox txtIndirimTutarı;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkTicket;
        private System.Windows.Forms.CheckBox chkKrediKartı;
        private System.Windows.Forms.CheckBox chkNakit;
        private System.Windows.Forms.Button btnHesapOzet;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}