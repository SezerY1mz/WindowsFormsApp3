﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class cAdisyon
    {
        cGenel1 gnl = new cGenel1();

        #region fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _TArih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime TArih { get => _TArih; set => _TArih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion


        public int getByAddition(int MasaID)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 Id From Adisyonlar Where MasaId=@MasaId Order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaID = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                String hata = ex.Message;
            }
            finally
            {
                con.Close();

            }
            return MasaID;
        }//Açık olan masanın adisyon numrası

        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Adisyonlar(SERVISTURNO,TARIH, PERSONELID,MASAID,DURUMD values(@ServisTurNo,@Tarih,PERSONELID,MASAID,DURUM) values (@ServisTurNo,@Tarih,@PersonelID,@MasaId,@Durum)", con);
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;

                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.TArih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

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
    }
}

