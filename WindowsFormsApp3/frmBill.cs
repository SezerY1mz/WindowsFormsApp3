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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
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


        cSipariş cs = new cSipariş();
        private void frmBill_Load(object sender, EventArgs e)
        {
           
         
            
            
            if (cGenel1._ServisTurNo == 1)
            {
                lblAdisyonId.Text = cGenel1._AdisyonId;
                txtIndirimTutarı.TextChanged += new EventHandler(txtIndirimTutarı_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count>0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++) 
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = String.Format("{0:0,000}", toplam);
                    lblOdenecek.Text = String.Format("{0:0,000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = String.Format("0:0,000", kdv);
                
            }
                if (chkIndirim.Checked)

                    gblIndirim.Visible = false;

                else

                    gblIndirim.Visible = true;
               
                txtIndirimTutarı.Clear();

            }
            else
                if (cGenel1._ServisTurNo == 2)
            {
                lblAdisyonId.Text = cGenel1._AdisyonId;
                txtIndirimTutarı.TextChanged += new EventHandler(txtIndirimTutarı_TextChanged);

                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));




                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);

                    }
                    lblToplamTutar.Text = String.Format("{0:0,000}", toplam);
                    lblOdenecek.Text = String.Format("{0:0,000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = String.Format("0:0,000", kdv);
                }
            }
            if (chkIndirim.Checked)

                gblIndirim.Visible = false;

            else

                gblIndirim.Visible = true;
            txtIndirimTutarı.Clear();


            
            
        }
          
        private void txtIndirimTutarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutarı.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = String.Format("{0:0,000}", Convert.ToDecimal(txtIndirimTutarı.Text));
                    }
                    catch (Exception)
                    {
                        lblIndirim.Text = String.Format("{0:0,000}", 0);
                    }
                }
                else
                    {
                    MessageBox.Show("inidirm tutarı toplam tutardan fazla olamaz !!!");
                    }

                
            }
            catch (Exception)
            {
                lblIndirim.Text = String.Format("{0:0,000}", 0);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIndirim.Checked)
            {
                gblIndirim.Visible = true;

            }
            else
            {
                gblIndirim.Visible = false;
            }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblIndirim.Text = String.Format("0:0,000", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
            lblKdv.Text = String.Format("0:0,000", kdv);
        }
        cMasalar masalar=new cMasalar();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (cGenel1._ServisTurNo == 1);
        }

        private void btnHesapOzet_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
            Font Baslik = new Font("Verdana", 15, FontStyle.Bold);       
            Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);        
            Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("İtadakimasu RESTAURANT", Baslik, sb, 350, 100, st);
            e.Graphics.DrawString("----------------------", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı            Adet           Fiyat", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("            ", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("--------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı:-------------------"+ lblIndirim.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 1), st);
        }

        private void lvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

