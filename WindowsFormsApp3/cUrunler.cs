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
    internal class cUrunler
    {
        cGenel1 gnl = new cGenel1();
        #region fields
        private int _urunid;
        private int _urunturno;
        private string _urunad;
        private decimal _fiyat;
        private string _aciklama;
        #endregion

        #region properties
        public int Urunid { get => _urunid; set => _urunid = value; }
        public int Urunturno { get => _urunturno; set => _urunturno = value; }
        public string Urunad { get => _urunad; set => _urunad = value; }
        public decimal Fiyat { get => _fiyat; set => _fiyat = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        #endregion

        public void urunleriListelebyUrunAdi(ListView lv, string urunadi)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler. * , KATEGORIIDI from urunler inner join kategoriler on kategoriler.ID=urunler.KATEGORIID Where urunler. Durum=0 and urunler.KATEGORIID=@urunID", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@urunID", SqlDbType.VarChar).Value = Urunid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());                   
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();


            }
        }

        public int urunEkle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into urunler(URUNAD,KATEGORIID,ACIKLAMA,FIYAT) values(@urunAd,@katId,@aciklama,@fiyat)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return sonuc;

        }

        public void urunleriListele(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler.*,KATEGORIADI from urunler inner join kategoriler on kategoriler.ID=urunler.KATEGORIID where urunler.Durum=0", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["Id"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0.0}", dr["FIYAT"].ToString()));
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                   
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }


        }

        
        public int UrunGuncelle(cUrunler u)
        {
            int sonuc = 0; 
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update urunler set URUNAD=@urunad,KATEGORIID=@katId,ACIKLAMA=@aciklama,FIYAT=@fiyat where ID=@urunId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunturno; 
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = u._urunid;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                
            }
            finally
            {
                con.Dispose();
                con.Close();
               
            }
            return sonuc; 
        }

        public int UrunSil(cUrunler u,int kat)
        {
            int sonuc = 0; 

            SqlConnection con = new SqlConnection(gnl.conString);

            string sql = "Update urunler set Durum=1 where";
            if (kat == 0)
                sql += "KATEGORIID=@urunID";
            else
                sql += "ID=@urunID";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                
                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc ; 
        }

        public void urunleriListelebyUrunId(ListView lv, int urunId)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from urunler where Durum=0 and ID=urunId", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = urunId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["Id"].ToString());             
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();


            }
        }

        public void urunlerListeleIstekliKredereGore(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis)
        {
           
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT top 10 dbo.URUNLER.URUNAD, sum(dbo.satislar.ADET) as ADET from dbo.Kategoriler INNER JOIN dbo.URUNLER on dbo.Kategoriler.ID = dbo.URUNLER.KATEGORIID INNER JOIN dbo.satislar on dbo.URUNLER.ID = dbo.satislar.URUNID INNER JOIN dbo.adisoylar on dbo.satislar.ADISOYID = dbo.adisoylar.ID WHERE (CONVERT(datetime,tarih,104) BETWEEN CONVERT(datetime,@Baslangic,104) AND CONVERT(datetime,@bitis,104)) group by dbo.URUNLER.URUNAD order by ADET desc ", con);

            SqlDataReader dr = null;

            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToShortDateString();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
               string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }
           
        }


        public void urunleriListeleIsatisklereGoreUrunId (ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis,int urunkatId)
        {

            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT top 10 dbo.URUNLER.URUNAD, sum(dbo.satislar.ADET) as ADET from dbo.Kategoriler INNER JOIN dbo.URUNLER on dbo.Kategoriler.ID = dbo.URUNLER.KATEGORIID INNER JOIN dbo.satislar on dbo.URUNLER.ID = dbo.satislar.URUNID INNER JOIN dbo.adisoylar on dbo.satislar.ADISOYID = dbo.adisoylar.ID WHERE (CONVERT(datetime,tarih,104) BETWEEN CONVERT(datetime,@Baslangic,104) AND CONVERT(datetime,@Bitis,104)) and(dbo.urunler.KATEGORIID=katId) group by dbo.URUNLER.URUNAD order by ADET desc ", con);

            SqlDataReader dr = null;

            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToShortDateString();
            cmd.Parameters.Add("@katId", SqlDbType.Int).Value = urunkatId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                  

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }

        }


    }
}
