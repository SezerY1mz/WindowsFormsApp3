using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class cÜrünÇeşitleri
    {
        cGenel1 gnl = new cGenel1();

        #region fields
        private int _UrunTurNo;
        private string _KategorId;
        private string _Aciklama;        
        private string _KategorAd; 
        #endregion

       
        #region Properties
        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string TurAd { get => _KategorId; set => _KategorId = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public string KategorAd { get => _KategorAd; set => _KategorAd = value; }
        #endregion

        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select URUNAD, FIYAT,urunler.ID From kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID where urunler.KATEGORIID = @KATEGORIID", conn);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }

        public void getByProductSearch(ListView Cesitler, int txt)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select from urunler where ID=@ID", conn);



            comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = txt;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();


        }

        public void urunCesitleriGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from kategoriler Where Durum=0", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    cÜrünÇeşitleri uc = new cÜrünÇeşitleri();
                    uc.UrunTurNo = Convert.ToInt32(dr["ID"]);
                    uc.KategorAd = dr["KATEGORIADI"].ToString();
                    uc.Aciklama = dr["ACIKLAMA"].ToString();

                   
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

        public void urunCesitleriGetir(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler Where Durum=0", con);
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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
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

        public void urunCesitleriGetir(ListView lv, String source)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler Where Durum=0 and KATEGORIAD like '%' + @source + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@source", SqlDbType.VarChar).Value = source;
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIAD"].ToString());
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

        public int urunKategoriEkle(cÜrünÇeşitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Kategoriler(KATEGORIAD,ACIKLAMA) values(@KATEGORIAD,@ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@KATEGORIAD", SqlDbType.VarChar).Value = u._KategorId;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u.Aciklama;

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

        public int urunKategoriGuncelle(cÜrünÇeşitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Kategoriler set KATEGORIAD=@KATEGORIAD,ACIKLAMA=@ACIKLAMA where ID=@ID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@KATEGORIAD", SqlDbType.VarChar).Value = u._KategorId; 
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama; 
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = u._UrunTurNo;

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

        public int urunKategoriSil(int Id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Kategoriler set DURUM=1 where ID=@ID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Id; 

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

        public override string ToString()
        {
            return TurAd;
        }
    }
}
