using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp3
{

    internal class cPersoneller
    {

        cGenel1 gnl = new cGenel1();
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private bool _PersunelDurum;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private int _PerId;
        #endregion

        #region ProPerties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGorevId1 { get => _PersonelGorevId; set => _PersonelGorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad1 { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public bool PersunelDurum { get => _PersunelDurum; set => _PersunelDurum = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi1 { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public int PerId { get => _PerId; set => _PerId = value; }

        #endregion


        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Personeller where ID=@Id and PAROLA=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                String hata = ex.Message;
                throw;
            }
            {
                return result;
            }
        }
        public void PersonelGetbyInformation(ComboBox cb)
        {

            cb.Items.Clear();
            cGenel1 gnl = new cGenel1();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Personeller ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cPersoneller p = new cPersoneller();
                    p.PersonelId = Convert.ToInt32(dr["ID"]);
                    p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                    p.PersonelAd = Convert.ToString(dr["AD"]);
                    p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                    p.PersonelParola = Convert.ToString(dr["PAROLA"]);
                    p._PersonelKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                    p.PersunelDurum = Convert.ToBoolean(dr["DURUM"]);
                    cb.Items.Add(p);

                }
                dr.Close();
                con.Close();

            }




        }
        internal bool personelEntryControl(TextBox txtSifre, int personelId)
        {
            throw new NotImplementedException();
        }

        public void PersonelBilgileriniGetirLV(ListView lv)
        {

            lv.Items.Clear();
            cGenel1 gnl = new cGenel1();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Personeller .*,PersonlGorevleri.GOREV from Personeller Inner join PersonelGorevleri on PersonelGorevleri.ID=Personel.GOREVID where Personeller.Durum=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            {
                SqlDataReader dr = cmd.ExecuteReader();

                int i = 0;
                while (dr.Read())
                {

                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                    lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                    lv.Items[i].SubItems.Add(dr["AD"].ToString());
                    lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                    i++;


                }
                dr.Close();
                con.Close();

            }




        }
        public void PersonelBilgileriniGetirfromIDLV(ListView lv, int PerID)
        {

            lv.Items.Clear();
            cGenel1 gnl = new cGenel1();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Personeller .*,PersonlGorevleri.GOREV from Personeller Inner join PersonelGorevleri on PersonelGorevleri.ID=Personel.GOREVID where Personeller.Durum=0 and Personeller.ID = @PerId", con);

            cmd.Parameters.Add("PerID", SqlDbType.Int).Value = PerID;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            {
                SqlDataReader dr = cmd.ExecuteReader();

                int i = 0;
                while (dr.Read())
                {

                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                    lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                    lv.Items[i].SubItems.Add(dr["AD"].ToString());
                    lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                    i++;


                }
                dr.Close();
                con.Close();

            }




        }
        public string PersonelBilgiGetirIsim(int perId)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select AD from personeller where Personeller.Durum=0 and Personeller.ID=@perId", con);
            cmd.Parameters.Add("perID", SqlDbType.Int).Value = perId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }

            con.Close();



            return sonuc;
        }


        public bool personelSifreDegistir(int personelID, string pass)

        {

            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update personeller set PAROLA=@pass where ID=@perId", con);
            cmd.Parameters.Add("perID", SqlDbType.Int).Value = personelID;
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                throw;

            }

            con.Close();
            return sonuc;
        }
        public bool personelEkle(cPersoneller cp)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into Personeller(AD,SOYAD, KULLANICIADI, PAROLA, GOREVID) values(@AD,@SOYAD,@KULLANICIADI,@PAROLA,@GOREVID)", con);
            cmd.Parameters.Add("AD", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("KULLANICIADI", SqlDbType.VarChar).Value = _PersonelKullaniciAdi;
            cmd.Parameters.Add("PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("GOREVID", SqlDbType.Int).Value = _PersonelGorevId;
            try
            {
                if( con.State == ConnectionState.Closed)
                { 
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch(Exception)
            {
                throw;
            }
            con.Close();
            return sonuc;

        }
        public bool personelGuncelle(cPersoneller cp,int PerId)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update personeler set AD=@AD,SOYAD=@SOYAD,PAROLA=@PAROLA,GOREVID=@GOREVIDwhere ID=@perID", con);
            cmd.Parameters.Add("AD", SqlDbType.Int).Value = PerId;



            cmd.Parameters.Add("perID", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("KULLANICIADI", SqlDbType.VarChar).Value = _PersonelKullaniciAdi;
            cmd.Parameters.Add("PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("GOREVID", SqlDbType.Int).Value = _PersonelGorevId;
                                  try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();
            return sonuc;

        }
        public bool personelSil(cPersoneller cp, int PerId)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update personeler set DURUM=1 where ID=@PerID", con);
            cmd.Parameters.Add("perID", SqlDbType.VarChar).Value = _PersonelAd;

            sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();

            return sonuc;

        }

















    }
}


