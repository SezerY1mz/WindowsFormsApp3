using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
        cGenel1 gnl = new cGenel1();
        private void Setting_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGörevleri cpg = new cPersonelGörevleri();
            string gorev = cpg.PersonelGorevleriTanım(cGenel1._gorevId);
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnBilgiDeğiştir_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {


                if (txtAd.Text == "" || txtSoyad.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "" || txtGorevId2.Text == "")
                {


                    if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length >= 5 || txtSifreTekrar.Text.Length >= 5))
                    {
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad1 = txtSoyad.Text.Trim();
                        c.PersonelParola = txtSifre.Text.Trim();
                        c.PersonelGorevId1 = Convert.ToInt32(txtGorevId2.Text);
                        bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtpersonelıD.Text));

                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                            c.PersonelBilgileriniGetirLV(lvPersoneller);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Eklenirken bir hata oluştu.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("şifre aynı değil");
                    }
                }

                else
                {
                    MessageBox.Show("boş alan bırakmayınız");
                }
            }
            else
            {
                MessageBox.Show("kayıt Seçiniz");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" & txtSoyad.Text.Trim() == "" & txtSifre.Text.Trim() == "" & txtSifreTekrar.Text.Trim() == "" & txtGorevId2.Text.Trim() == "")
            {


                if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length >= 5 || txtSifreTekrar.Text.Length >= 5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad1 = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifre.Text.Trim();
                    c.PersonelGorevId1 = Convert.ToInt32(txtGorevId2.Text);
                    bool sonuc = c.personelEkle(c);

                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Eklenirken bir hata oluştu.");
                    }

                }
            }
            else
            {
                MessageBox.Show("şifre aynı değil");
            }
        }

        private void lblBilgi_Click(object sender, EventArgs e)
        {

        }

        private void btnDegiştir_Click(object sender, EventArgs e)
        {

            if (txtYeniSifre.Text.Trim() != txtYeniSifreTekrar.Text.Trim() || txtYeniSifre.Text.Trim() == "")
            {

                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    if (txtYeniSifreTekrar.Text != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelId.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi başarıyla gerçekleşmiştir.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("personel seçiniz");
                    }
                    }
                    else
                    {
                        MessageBox.Show("şifre aynı değil");
                    }
                }
                else
                {
                    MessageBox.Show("şifre alanını boş bırakmayınız");
                }
            }
        

        private void cbGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGörevleri c = (cPersonelGörevleri)cbGorev.SelectedItem;
            txtGorevId2.Text = Convert.ToString(c.PersonelgorevId);
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnKaydet.Enabled = true;
            btnBilgiDeğiştir.Enabled = false;
            btnSil.Enabled = false;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
        }

        private void btnDeğiştir2_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre2.Text.Trim() != txtYeniSifreTekrar2.Text.Trim() || txtYeniSifre2.Text.Trim() == "")
            {

                if (txtYeniSifre2.Text == txtYeniSifreTekrar2.Text)
                {
                    if (cGenel1._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel1._personelId), txtYeniSifre2.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi başarıyla gerçekleşmiştir.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("personel seçiniz");
                    }
                    }
                    else
                    {
                        MessageBox.Show("şifre aynı değil");
                    }
                }
                else
                {
                    MessageBox.Show("şifre alanını boş bırakmayınız");
                }
            }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lvPersoneller.SelectedItems.Count>0)
            {
                btnSil.Enabled = true;

                txtPersonelId.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorev.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) -1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnSil.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    }



        




