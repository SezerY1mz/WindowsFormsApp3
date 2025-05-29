using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
        }

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cÜrünÇeşitleri Anakategori = new cÜrünÇeşitleri();
            Anakategori.urunCesitleriGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;

            label3.Visible = false;
           
        }

        private void Temizle()
        {
            txtGidaAdi.Clear();
            txtGidaFiyati.Clear();
            txtGidaFiyati.Text = String.Format("{0:##0.00}", 0);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gıda Adı Fiyatı ve kategori seçilmemiştir.", "Dikkat, Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.Urunad = txtGidaAdi.Text;
                    c.Aciklama = "ürün eklendi";
                    c.Urunturno = urunTurNo;
                    int sonuc = c.urunEkle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Eklenmiştir");
                        Yenile();
                        Temizle();
                    }
                }

            }
            else
            {
                if (txtKategoriAd.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori ismi giriniz.", "Dikkat,Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cÜrünÇeşitleri gida = new cÜrünÇeşitleri();
                    gida.TurAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAçıklma.Text;
                    int sonuc = gida.urunKategoriEkle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Eklenmiştir");
                        Yenile();
                        Temizle();
                    }


                }
            }


        }
        int urunTurNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if (cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                u.urunleriListele(lvGıdaListesi);
            }
            else
            {
                cÜrünÇeşitleri cesit = (cÜrünÇeşitleri)cbKategoriler.SelectedItem;
                urunTurNo = cesit.UrunTurNo;
                u.urunleriListelebyUrunId(lvGıdaListesi, urunTurNo);
            }

        }

        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gıda Adı Fiyatı ve kategori seçilmemiştir.", "Dikkat, Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.Urunad = txtGidaAdi.Text;
                    c.Urunid = Convert.ToInt32(txtUrunId.Text);
                    c.Urunturno = Convert.ToInt32(TxtKategoriId.Text);
                    c.Aciklama = "ürün güncellendi";

                    int sonuc = c.UrunGuncelle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Güncellenmiştir");
                        Yenile();
                      
                        Temizle();
                    }
                }

            }
            else
            {
                if (TxtKategoriId.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori Seçiniz .", "Dikkat,Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cÜrünÇeşitleri gida = new cÜrünÇeşitleri();
                    gida.TurAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAçıklma.Text;
                    gida.UrunTurNo = Convert.ToInt32(TxtKategoriId.Text);
                    int sonuc = gida.urunKategoriGuncelle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Güncelenmiştir");

                        gida.urunCesitleriGetir(lvKategoriler);
                        Temizle();
                    }


                }
            }
        }

        private void lvGıdaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGıdaListesi.SelectedItems.Count > 0)
            {
                txtGidaAdi.Text = lvGıdaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidaFiyati.Text = lvGıdaListesi.SelectedItems[0].SubItems[5].Text;
                txtUrunId.Text = lvGıdaListesi.SelectedItems[0].SubItems[0].Text;

            }
        }

        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                txtKategoriAd.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
                TxtKategoriId.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtAçıklma.Text = lvKategoriler.SelectedItems[0].SubItems[3].Text;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (lvGıdaListesi.SelectedItems.Count > 0)

                {
                    if (MessageBox.Show("Ürün Silmekte Eminmisiniz.", "Dikkat, Bilgiler Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        cÜrünÇeşitleri uc = new cÜrünÇeşitleri();
                        int sonuc = uc.urunKategoriSil(Convert.ToInt32(TxtKategoriId.Text));
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün Silinmiştir");
                            cUrunler c = new cUrunler();
                            c.Urunid = Convert.ToInt32(TxtKategoriId.Text);
                            c.UrunSil(c,0);
                            Yenile();
                            Temizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Silmekte İçin Bİr Ürün Seçiniz.", "Dikkat, Ürün SEçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lvKategoriler.SelectedItems.Count > 0)
                {

                    {
                        if (MessageBox.Show("Ürün Silmekte Emin misiniz?.", "Dikkat, Bilgiler Silinecek", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {


                            cÜrünÇeşitleri uc = new cÜrünÇeşitleri();



                            int sonuc = uc.urunKategoriSil(Convert.ToInt32(TxtKategoriId.Text));
                            if (sonuc != 0)
                            {
                                MessageBox.Show("Ürün Silinmiştir");
                                Yenile();
                                
                                Temizle();
                            }
                        }
                    }
                }
            }
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
           
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                cUrunler u = new cUrunler();
              
            }
            else
            {
                cÜrünÇeşitleri uc = new cÜrünÇeşitleri();
              
            }
        }

        private void rbAltkategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGıdaListesi.Visible = true;
            Yenile();
        }

        private void rbAnaKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGıdaListesi.Visible = false;
            Yenile();
        }

        private void Yenile()

        {
            cÜrünÇeşitleri uc = new cÜrünÇeşitleri();
            uc.urunCesitleriGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex=0;
            uc.urunCesitleriGetir(lvKategoriler);
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGıdaListesi);

        }

        private void txtGidaFiyati_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





