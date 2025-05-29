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
    public partial class FrmGiris : Form
    {
       
        
            public FrmGiris()
            {
                InitializeComponent();
            }
            cGenel1 gnl = new cGenel1();
            private void Form1_Load(object sender, EventArgs e)
            {
                cPersoneller p = new cPersoneller();
                p.PersonelGetbyInformation(cbKullanici);
            }

            private void btnGiris_Click(object sender, EventArgs e)
            {
                cPersoneller p = new cPersoneller();
                bool result = p.personelEntryControl(txtSifre.Text, cGenel1._personelId);

                if (result)

                {
                

                    this.Hide();
                    frmMenu menu = new frmMenu();
                    menu.Show();

                }
            }      

            private void btnÇıkıs_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { Application.Exit(); }
            }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel1._personelId = p.PersonelId;
            cGenel1._gorevId = p.PersonelGorevId1;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    



    

