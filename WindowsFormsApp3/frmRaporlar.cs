using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp3
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void btnAnayemek3_Click(object sender, EventArgs e)
        {

            Istatistik("AnaYemekler Grafiği", 3, Color.Red);


        }

        private void btnicecekler8_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 8, Color.Orange);
        }

        private void Istatistik(string gfname,int KatId,Color renk)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = renk;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIsatisklereGoreUrunId(lvIstatistik, dtBaslangic, dtBitis, KatId);
            gbIstatistik.Text = gfname;

            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
                }
            }
        }

        private void BtnTatlılar7_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 7, Color.Blue);
        }

        private void btnSalata6_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 6, Color.Green);
        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 5, Color.LightBlue);
        }

        private void btnÇorba1_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 1, Color.Yellow);
        }

        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 4, Color.Purple);
        }

        private void btnArasıcak2_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği ", 2, Color.Pink);
        }

        private void btnTümÜrünler_Click(object sender, EventArgs e)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color =Color.GreenYellow;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunlerListeleIstekliKredereGore(lvIstatistik, dtBaslangic, dtBitis);
            gbIstatistik.Text = "Tüm Ürünler";

            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
                }
            }else
            {
                MessageBox.Show("Gösterilecek istatistil yok,Başka bir zaman dilimi seçiniz ");
            }
        }
    }
}
