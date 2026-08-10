using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServisTakip.Repositories.cs
{
    public class KullanıcıRepository
    {
        private readonly string _baglanti;

        public KullanıcıRepository(string baglanti)
        {
            _baglanti = baglanti;
        }


        public bool KullaniciGirisKontrol(string kullaniciAdi, string sifre)
        {
            string query = "SELECT COUNT(*) FROM Kullanıcılar WHERE [KullanıcıAdı] = @kullaniciAdi AND [Sifre] = @sifre";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    int eslestiMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return eslestiMi > 0;
                }
            }
        }

    }
}
