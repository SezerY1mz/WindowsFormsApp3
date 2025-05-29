namespace WindowsFormsApp3
{
    partial class frmMasa
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
            this.btnMasa1 = new System.Windows.Forms.Button();
            this.btnMasa2 = new System.Windows.Forms.Button();
            this.btnMasa3 = new System.Windows.Forms.Button();
            this.btnMasa4 = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasa1
            // 
            this.btnMasa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa1.Location = new System.Drawing.Point(12, 121);
            this.btnMasa1.Name = "btnMasa1";
            this.btnMasa1.Size = new System.Drawing.Size(186, 162);
            this.btnMasa1.TabIndex = 0;
            this.btnMasa1.Text = "MASA1";
            this.btnMasa1.UseVisualStyleBackColor = true;
            this.btnMasa1.Click += new System.EventHandler(this.btnMasa1_Click);
            // 
            // btnMasa2
            // 
            this.btnMasa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa2.Location = new System.Drawing.Point(204, 121);
            this.btnMasa2.Name = "btnMasa2";
            this.btnMasa2.Size = new System.Drawing.Size(186, 162);
            this.btnMasa2.TabIndex = 0;
            this.btnMasa2.Text = "MASA2";
            this.btnMasa2.UseVisualStyleBackColor = true;
            this.btnMasa2.Click += new System.EventHandler(this.btnMasa2_Click);
            // 
            // btnMasa3
            // 
            this.btnMasa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa3.Location = new System.Drawing.Point(396, 121);
            this.btnMasa3.Name = "btnMasa3";
            this.btnMasa3.Size = new System.Drawing.Size(186, 162);
            this.btnMasa3.TabIndex = 0;
            this.btnMasa3.Text = "MASA3";
            this.btnMasa3.UseVisualStyleBackColor = true;
            this.btnMasa3.Click += new System.EventHandler(this.btnMasa3_Click);
            // 
            // btnMasa4
            // 
            this.btnMasa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa4.Location = new System.Drawing.Point(588, 121);
            this.btnMasa4.Name = "btnMasa4";
            this.btnMasa4.Size = new System.Drawing.Size(186, 162);
            this.btnMasa4.TabIndex = 0;
            this.btnMasa4.Text = "MASA4";
            this.btnMasa4.UseVisualStyleBackColor = true;
            this.btnMasa4.Click += new System.EventHandler(this.btnMasa4_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 391);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(79, 60);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(97, 391);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(79, 60);
            this.btnÇıkış.TabIndex = 0;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // frmMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btnMasa4);
            this.Controls.Add(this.btnMasa3);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnMasa2);
            this.Controls.Add(this.btnMasa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMasa";
            this.Text = "frmMasa";
            this.Load += new System.EventHandler(this.frmMasa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasa1;
        private System.Windows.Forms.Button btnMasa2;
        private System.Windows.Forms.Button btnMasa3;
        private System.Windows.Forms.Button btnMasa4;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnÇıkış;
    }
}