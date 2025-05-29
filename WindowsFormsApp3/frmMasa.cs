using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmMasa : Form
    {
        public frmMasa()
        {
            InitializeComponent();
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

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa1.Name.Length;


            cGenel1._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa2.Name.Length;

           
            cGenel1._ButtonName = btnMasa2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa3.Name.Length;

            
            cGenel1._ButtonName = btnMasa3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa4.Name.Length;

           
            cGenel1._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }
        cGenel1 gnl = new cGenel1();
        private void frmMasa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM, ID from Masalar", con);
           
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }
           
        } 
    } 
        }
    

