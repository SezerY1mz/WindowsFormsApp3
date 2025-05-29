namespace WindowsFormsApp3
{
    partial class frmMenu
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
            this.btnMasalar = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnsiparişler = new System.Windows.Forms.Button();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasalar
            // 
            this.btnMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasalar.Location = new System.Drawing.Point(100, 70);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(188, 144);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.Text = "Masa";
            this.btnMasalar.UseVisualStyleBackColor = true;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.Location = new System.Drawing.Point(488, 70);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(188, 144);
            this.btnRaporlar.TabIndex = 0;
            this.btnRaporlar.Text = "Rapor";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnsiparişler
            // 
            this.btnsiparişler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparişler.Location = new System.Drawing.Point(294, 70);
            this.btnsiparişler.Name = "btnsiparişler";
            this.btnsiparişler.Size = new System.Drawing.Size(188, 144);
            this.btnsiparişler.TabIndex = 0;
            this.btnsiparişler.Text = "Sipraişler";
            this.btnsiparişler.UseVisualStyleBackColor = true;
            this.btnsiparişler.Click += new System.EventHandler(this.btnsiparişler_Click);
            // 
            // btnMutfak
            // 
            this.btnMutfak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMutfak.Location = new System.Drawing.Point(100, 211);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(188, 144);
            this.btnMutfak.TabIndex = 0;
            this.btnMutfak.Text = "Mutfak";
            this.btnMutfak.UseVisualStyleBackColor = true;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.Location = new System.Drawing.Point(294, 220);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(188, 144);
            this.btnAyarlar.TabIndex = 0;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(488, 220);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(188, 144);
            this.btnÇıkış.TabIndex = 0;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnMutfak);
            this.Controls.Add(this.btnsiparişler);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnMasalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnsiparişler;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnÇıkış;
    }
}