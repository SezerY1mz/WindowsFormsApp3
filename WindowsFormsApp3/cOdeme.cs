﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class cOdeme
    {
        #region fields
        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _Kdvtutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;
        #endregion

        #region Properties
        public int OdemeID { get => _OdemeID; set => _OdemeID = value; }
        public int AdisyonID1 { get => _AdisyonID; set => _AdisyonID = value; }
        public int OdemeTurId { get => _OdemeTurId; set => _OdemeTurId = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indirim { get => _Indirim; set => _Indirim = value; }
        public decimal Kdvtutari { get => _Kdvtutari; set => _Kdvtutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        #endregion
        cGenel1 gnl = new cGenel1();
        public bool billClose(cOdeme bill)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into hesapOdemeleri(ADISYONID,ODEMETURLERI,MUSTERIID,ARATOPLAM,KDVTUTARI,TAPLAMTUTAR,INDIRIM ) values (@ADISYONID, @ODEMETURLERI,@MUSTERIID, @ARATOPLAM, @KDVTUTARI, @TAPLAMTUTAR,@INDIRIM", con);

            try
            {
                if (con.State == ConnectionState.Closed);
                {
                    con.Open();
                }
                cmd.Parameters.Add("AdisyonID", SqlDbType.Int).Value = bill._AdisyonID;
                cmd.Parameters.Add("ODEMETURLERI", SqlDbType.Int).Value = bill._OdemeTurId;
                cmd.Parameters.Add("MUSTERIID", SqlDbType.Int).Value = bill._MusteriId;
                cmd.Parameters.Add("ARATOPLAM", SqlDbType.Money).Value = bill._AraToplam;
                cmd.Parameters.Add("KDVTUTARI", SqlDbType.Money).Value = bill._Kdvtutari;
                cmd.Parameters.Add("TAPLAMTUTAR", SqlDbType.Money).Value = bill._GenelToplam;
                cmd.Parameters.Add("INDIRIM", SqlDbType.Int).Value = bill._Indirim;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }

        public decimal sumtTotalforClientId(int clientId)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select sum(TOPLAMTUTAR) as total from hesapOdemeleri Where MUSTERIID=@clientId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                }
                cmd.Parameters.Add("clientId", SqlDbType.Int).Value = clientId;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {

                con.Dispose();
                con.Close();
            }

            return total;
        }
    }
}
    
