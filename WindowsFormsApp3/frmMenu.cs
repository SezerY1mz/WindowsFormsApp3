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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            frmMasa frm = new frmMasa();
            this.Close();
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
          
        }

        private void btnsiparişler_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            this.Close();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

   

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            this.Close();
            frm.Show();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
        }
    }
}
