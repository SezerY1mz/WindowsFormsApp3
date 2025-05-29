using System;
using System.Collections;
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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnAnayemek_Click(object sender, EventArgs e)
        {
            cÜrünÇeşitleri uc = new cÜrünÇeşitleri();
            uc.getByProductTypes(lvMenu, btnAnayemek3);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {

        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {

        }
        //Hesap İşlemş
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("Sayı gir");
                    break;


            }


        }
        int tableId; int AdditionId;
        private void frmSiparis_Load_1(object sender, EventArgs e)
        {
            lblMasaNumarası.Text = cGenel1._ButtonValue;
            cMasalar ms = new cMasalar();
            tableId = ms.TableGetbyNumber(cGenel1._ButtonName);
            if (ms.TableGetbyState(tableId, 2) == true || ms.TableGetbyState(tableId, 4) == true)
            {
                cAdisyon Ad = new cAdisyon();
                AdditionId = Ad.getByAddition(tableId);
                cSipariş orders = new cSipariş();
                orders.getByOrder(lvSiparişler, AdditionId);
            }

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnÇıkış_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }
        }
        cÜrünÇeşitleri uc = new cÜrünÇeşitleri();
        private void btnAnayemek3_Click(object sender, EventArgs e)
        {

            uc.getByProductTypes(lvMenu, btnAnayemek3);
        }

        private void btnicecekler8_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnicecekler8);
        }

        private void BtnTatlılar7_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, BtnTatlılar7);
        }

        private void btnSalata6_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnSalata6);
        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnFastFood5);
        }

        private void btnÇorba1_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnÇorba1);
        }

        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnMakarna4);
        }

        private void btnArasıcak2_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnArasıcak2);
        }
        int sayac = 0; int sayac2 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";
            }



            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparişler.Items.Count;
                lvSiparişler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparişler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparişler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparişler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAdet.Text)).ToString());
                lvSiparişler.Items[sayac].SubItems.Add("0");
                sayac2 = lvYeniEklenenler.Items.Count;
                lvSiparişler.Items[sayac].SubItems.Add(sayac.ToString());


                lvYeniEklenenler.Items.Add(AdditionId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvYeniEklenenler.Items[sayac].SubItems.Add(tableId.ToString());
                lvYeniEklenenler.Items[sayac].SubItems.Add(sayac2.ToString());


            }
        }

        ArrayList silinenler = new ArrayList();




        private void btnSipariş_Click(object sender, EventArgs e)
        {
            cMasalar masa = new cMasalar();
            cAdisyon newaddition = new cAdisyon();
            cSipariş saveOrder = new cSipariş();
            frmMasa ms = new frmMasa();
            bool sonuc = false;
            if (masa.TableGetbyState(tableId, 1) == true)
            {
                newaddition.ServisTurNo = 1;
               
                newaddition.PersonelId = 1;
                newaddition.MasaId = tableId;
                newaddition.TArih = DateTime.Now;
                sonuc = newaddition.setByAdditionNew(newaddition);
                masa.setChangeTableStatel(cGenel1._ButtonName, 2);

                if (lvSiparişler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparişler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparişler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonId = newaddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparişler.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    this.Close();
                    ms.Show();
                }
            }
            else 
            if (masa.TableGetbyState(tableId, 2) == true || masa.TableGetbyState(tableId, 4) == true)
            {
               

                if (lvYeniEklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1].Text);
                        saveOrder.AdisyonId = newaddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[2].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                   
                }
                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        saveOrder.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                ms.Show();
            }
            else if (masa.TableGetbyState(tableId, 1) == true)
            {
                

                newaddition.ServisTurNo = 1;
                newaddition.PersonelId = 1;
                newaddition.MasaId = tableId;
                newaddition.TArih = DateTime.Now;
                sonuc = newaddition.setByAdditionNew(newaddition);
                masa.setChangeTableStatel(cGenel1._ButtonName, 4);

                if (lvSiparişler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparişler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparişler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonId = newaddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparişler.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    this.Close();
                    ms.Show();
                }
            }
        }
        private void lvSiparişler_DoubleClick(object sender, EventArgs e)
        {
            if (lvSiparişler.Items.Count > 0)
            {
                if (lvSiparişler.SelectedItems[0].SubItems[4].Text != "0")
                {

                    cSipariş saveOrder = new cSipariş();
                    saveOrder.setDeleteOrder(Convert.ToInt32(lvSiparişler.SelectedItems[0].SubItems[4].Text));
                }

                else
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        if (lvYeniEklenenler.Items[i].SubItems[4].Text == lvSiparişler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvYeniEklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                lvSiparişler.Items.RemoveAt(lvSiparişler.SelectedItems[0].Index);

            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
            {
                txtAra.Text = "1";
            }
            else
            {
                cÜrünÇeşitleri cu = new cÜrünÇeşitleri();
                cu.getByProductSearch(lvMenu, Convert.ToInt32(txtAra.Text));
            }
        }

        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnödeme_Click(object sender, EventArgs e)
        {
            
            frmBill frm = new frmBill();
            this.Close();
            frm.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }
    }
    }

        

    

