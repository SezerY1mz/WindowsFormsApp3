using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp3
{
    internal class cMasalar
    {
        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int SERVISTURU { get => _SERVISTURU; set => _SERVISTURU = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }
        #endregion
        cGenel1 gnl = new cGenel1();
        private string masaNo;

        public string SessionSum(int state, string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih, MasaId From Adisyon Right Join Masalar on Adisyon MasaId=Masalar.ID Where Masalar.DURUM=@durum and  Adisyon.Durum=0 and Masalar.ID=@masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }

        internal int TableGetbyNumber(string TableValue)
        {

            {
                // *** HATAYI ÖNLEYEN KONTROL BURADA ***
                if (string.IsNullOrEmpty(TableValue)) // TableValue null veya boş mu kontrolü
                {
                    // Eğer null veya boşsa, uygun bir varsayılan değer döndürün
                    // Veya bir hata fırlatın (örneğin throw new ArgumentNullException("TableValue");)
                    return 0; // Masa numarası bulunamadı anlamında 0 dönebilirsiniz
                }

                string aa = TableValue; // Eğer buraya geldiysek, TableValue artık null değil
                int Length = aa.Length; // 'Lenght' yazım hatası 'Length' olarak düzeltildi

                if (Length > 8) // Düzeltilmiş 'Length' kullanıldı
                {
                    // Substring metodunun da hata vermemesi için ek kontrol faydalı olabilir
                    if (Length < 2) return 0; // Eğer uzunluk 2'den küçükse, son 2 karakteri alamazsın
                    return Convert.ToInt32(aa.Substring(Length - 2, 2));
                }
                else
                {
                    // Substring metodunun da hata vermemesi için ek kontrol
                    if (Length < 1) return 0; // Eğer uzunluk 1'den küçükse, son 1 karakteri alamazsın
                    return Convert.ToInt32(aa.Substring(Length - 1, 1));
                }
            }

        } 
    


        public bool TableGetbyState(int ButtonName, int state)
        {

            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select durum From Masalar Where Id=@TableId and DURUM=@state", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@StateId", SqlDbType.Int).Value = state;
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
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;

        }

        public void setChangeTableStatel(string ButonName, int state)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM=@Durum where ID=@MasaNo ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            if(uzunluk > 8)
            {
                masaNo = aa.Substring(uzunluk - 2, 2);
            }
            else
            {
                masaNo = aa.Substring(uzunluk - 1, 1);
            }
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = masaNo;
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}
        