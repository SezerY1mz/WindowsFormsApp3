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
    internal class cPersonelGörevleri
    {
        #region Fields
        private int _personelgorevId;
        private string _Tanım;
        #endregion

        #region Properties
        public int PersonelgorevId { get => _personelgorevId; set => _personelgorevId = value; }
        public string Tanım { get => _Tanım; set => _Tanım = value; }
        #endregion
        cGenel1 gnl = new cGenel1();
        public void PersonelGorevleriGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from PersonelGorevleri", con);
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
                    cPersonelGörevleri c = new cPersonelGörevleri();
                    c.PersonelgorevId = Convert.ToInt32(dr["ID"].ToString());
                    c.Tanım = dr["GOREV"].ToString();
                    cb.Items.Add(c);
                }
            }
            catch (SqlException ex)
            {
                String hata = ex.Message;
                throw;
            }
            dr.Close();
            con.Close();
        }
        public string PersonelGorevleriTanım(int per)
        {

            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select GOREV from PersonelGorevleri where ID=@perId", con);

            cmd.Parameters.Add("perId", SqlDbType.Int).Value = per;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                String hata = ex.Message;
                throw;
            }

            con.Close();

            return sonuc;
        }

        public override string ToString()
        {
            return _Tanım;

        }








    }

}



