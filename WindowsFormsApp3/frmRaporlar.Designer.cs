namespace WindowsFormsApp3
{
    partial class frmRaporlar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpMenuBaslik = new System.Windows.Forms.GroupBox();
            this.btnMakarna4 = new System.Windows.Forms.Button();
            this.btnFastFood5 = new System.Windows.Forms.Button();
            this.btnicecekler8 = new System.Windows.Forms.Button();
            this.btnSalata6 = new System.Windows.Forms.Button();
            this.BtnTatlılar7 = new System.Windows.Forms.Button();
            this.btnArasıcak2 = new System.Windows.Forms.Button();
            this.btnÇorba1 = new System.Windows.Forms.Button();
            this.btnAnayemek3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.gbIstatistik = new System.Windows.Forms.GroupBox();
            this.lvIstatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTümÜrünler = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.grpMenuBaslik.SuspendLayout();
            this.gbIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBaslik
            // 
            this.grpMenuBaslik.Controls.Add(this.btnMakarna4);
            this.grpMenuBaslik.Controls.Add(this.btnFastFood5);
            this.grpMenuBaslik.Controls.Add(this.btnicecekler8);
            this.grpMenuBaslik.Controls.Add(this.btnSalata6);
            this.grpMenuBaslik.Controls.Add(this.BtnTatlılar7);
            this.grpMenuBaslik.Controls.Add(this.btnArasıcak2);
            this.grpMenuBaslik.Controls.Add(this.btnÇorba1);
            this.grpMenuBaslik.Controls.Add(this.btnAnayemek3);
            this.grpMenuBaslik.Location = new System.Drawing.Point(12, 46);
            this.grpMenuBaslik.Name = "grpMenuBaslik";
            this.grpMenuBaslik.Size = new System.Drawing.Size(316, 351);
            this.grpMenuBaslik.TabIndex = 2;
            this.grpMenuBaslik.TabStop = false;
            this.grpMenuBaslik.Text = "MENÜ";
            // 
            // btnMakarna4
            // 
            this.btnMakarna4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMakarna4.Location = new System.Drawing.Point(6, 263);
            this.btnMakarna4.Name = "btnMakarna4";
            this.btnMakarna4.Size = new System.Drawing.Size(151, 82);
            this.btnMakarna4.TabIndex = 0;
            this.btnMakarna4.Text = "Makarna";
            this.btnMakarna4.UseVisualStyleBackColor = true;
            this.btnMakarna4.Click += new System.EventHandler(this.btnMakarna4_Click);
            // 
            // btnFastFood5
            // 
            this.btnFastFood5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFastFood5.Location = new System.Drawing.Point(6, 181);
            this.btnFastFood5.Name = "btnFastFood5";
            this.btnFastFood5.Size = new System.Drawing.Size(151, 76);
            this.btnFastFood5.TabIndex = 0;
            this.btnFastFood5.Text = "FastFood";
            this.btnFastFood5.UseVisualStyleBackColor = true;
            this.btnFastFood5.Click += new System.EventHandler(this.btnFastFood5_Click);
            // 
            // btnicecekler8
            // 
            this.btnicecekler8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnicecekler8.Location = new System.Drawing.Point(163, 22);
            this.btnicecekler8.Name = "btnicecekler8";
            this.btnicecekler8.Size = new System.Drawing.Size(151, 71);
            this.btnicecekler8.TabIndex = 0;
            this.btnicecekler8.Text = "İçeçekler";
            this.btnicecekler8.UseVisualStyleBackColor = true;
            this.btnicecekler8.Click += new System.EventHandler(this.btnicecekler8_Click);
            // 
            // btnSalata6
            // 
            this.btnSalata6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalata6.Location = new System.Drawing.Point(163, 99);
            this.btnSalata6.Name = "btnSalata6";
            this.btnSalata6.Size = new System.Drawing.Size(151, 76);
            this.btnSalata6.TabIndex = 0;
            this.btnSalata6.Text = "Salata";
            this.btnSalata6.UseVisualStyleBackColor = true;
            this.btnSalata6.Click += new System.EventHandler(this.btnSalata6_Click);
            // 
            // BtnTatlılar7
            // 
            this.BtnTatlılar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTatlılar7.Location = new System.Drawing.Point(6, 99);
            this.BtnTatlılar7.Name = "BtnTatlılar7";
            this.BtnTatlılar7.Size = new System.Drawing.Size(151, 76);
            this.BtnTatlılar7.TabIndex = 0;
            this.BtnTatlılar7.Text = "Tatlılar";
            this.BtnTatlılar7.UseVisualStyleBackColor = true;
            this.BtnTatlılar7.Click += new System.EventHandler(this.BtnTatlılar7_Click);
            // 
            // btnArasıcak2
            // 
            this.btnArasıcak2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArasıcak2.Location = new System.Drawing.Point(162, 263);
            this.btnArasıcak2.Name = "btnArasıcak2";
            this.btnArasıcak2.Size = new System.Drawing.Size(151, 82);
            this.btnArasıcak2.TabIndex = 0;
            this.btnArasıcak2.Text = "AraSıcak";
            this.btnArasıcak2.UseVisualStyleBackColor = true;
            this.btnArasıcak2.Click += new System.EventHandler(this.btnArasıcak2_Click);
            // 
            // btnÇorba1
            // 
            this.btnÇorba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇorba1.Location = new System.Drawing.Point(162, 181);
            this.btnÇorba1.Name = "btnÇorba1";
            this.btnÇorba1.Size = new System.Drawing.Size(151, 76);
            this.btnÇorba1.TabIndex = 0;
            this.btnÇorba1.Text = "Çorba";
            this.btnÇorba1.UseVisualStyleBackColor = true;
            this.btnÇorba1.Click += new System.EventHandler(this.btnÇorba1_Click);
            // 
            // btnAnayemek3
            // 
            this.btnAnayemek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnayemek3.Location = new System.Drawing.Point(6, 19);
            this.btnAnayemek3.Name = "btnAnayemek3";
            this.btnAnayemek3.Size = new System.Drawing.Size(151, 74);
            this.btnAnayemek3.TabIndex = 0;
            this.btnAnayemek3.Text = "AnaYemek";
            this.btnAnayemek3.UseVisualStyleBackColor = true;
            this.btnAnayemek3.Click += new System.EventHandler(this.btnAnayemek3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(517, 24);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(517, 46);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 4;
            // 
            // gbIstatistik
            // 
            this.gbIstatistik.Controls.Add(this.lvIstatistik);
            this.gbIstatistik.Controls.Add(this.chRapor);
            this.gbIstatistik.Location = new System.Drawing.Point(353, 105);
            this.gbIstatistik.Name = "gbIstatistik";
            this.gbIstatistik.Size = new System.Drawing.Size(422, 286);
            this.gbIstatistik.TabIndex = 5;
            this.gbIstatistik.TabStop = false;
            // 
            // lvIstatistik
            // 
            this.lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvIstatistik.HideSelection = false;
            this.lvIstatistik.Location = new System.Drawing.Point(322, 52);
            this.lvIstatistik.Name = "lvIstatistik";
            this.lvIstatistik.Size = new System.Drawing.Size(28, 37);
            this.lvIstatistik.TabIndex = 6;
            this.lvIstatistik.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adedi";
            // 
            // chRapor
            // 
            chartArea1.Name = "ChartArea1";
            this.chRapor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chRapor.Legends.Add(legend1);
            this.chRapor.Location = new System.Drawing.Point(6, 19);
            this.chRapor.Name = "chRapor";
            this.chRapor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "satislar";
            this.chRapor.Series.Add(series1);
            this.chRapor.Size = new System.Drawing.Size(410, 261);
            this.chRapor.TabIndex = 0;
            this.chRapor.Text = "chart1";
            // 
            // btnTümÜrünler
            // 
            this.btnTümÜrünler.Location = new System.Drawing.Point(353, 397);
            this.btnTümÜrünler.Name = "btnTümÜrünler";
            this.btnTümÜrünler.Size = new System.Drawing.Size(125, 56);
            this.btnTümÜrünler.TabIndex = 6;
            this.btnTümÜrünler.Text = "Tüm Ürünler";
            this.btnTümÜrünler.UseVisualStyleBackColor = true;
            this.btnTümÜrünler.Click += new System.EventHandler(this.btnTümÜrünler_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(99, 394);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(79, 60);
            this.btnÇıkış.TabIndex = 14;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 394);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(81, 60);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnTümÜrünler);
            this.Controls.Add(this.gbIstatistik);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMenuBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            this.grpMenuBaslik.ResumeLayout(false);
            this.gbIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBaslik;
        private System.Windows.Forms.Button btnMakarna4;
        private System.Windows.Forms.Button btnFastFood5;
        private System.Windows.Forms.Button btnicecekler8;
        private System.Windows.Forms.Button btnSalata6;
        private System.Windows.Forms.Button BtnTatlılar7;
        private System.Windows.Forms.Button btnArasıcak2;
        private System.Windows.Forms.Button btnÇorba1;
        private System.Windows.Forms.Button btnAnayemek3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.GroupBox gbIstatistik;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRapor;
        private System.Windows.Forms.Button btnTümÜrünler;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnGeri;
    }
}