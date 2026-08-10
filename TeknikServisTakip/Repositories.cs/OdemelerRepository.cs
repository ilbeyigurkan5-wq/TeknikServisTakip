using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;

namespace TeknikServisTakip.Repositories.cs
{
    public class OdemelerRepository
    {
        private readonly string _baglanti;

        public OdemelerRepository(string baglanti)
        {
            _baglanti = baglanti;
        }

        public DataTable ServisleriOdemeİcinListele()
        {
            string query = @"
                         SELECT
                          sk.[ServisID],
                           m.[Ad] + ' ' + m.[Soyad] AS [Musteri],
                           c.[Marka] + ' ' + c.[Model] AS [Cihaz],
                           c.[IMEI],
                           sk.[ArizaAciklama] AS [Aciklama],
                           sk.[Durum],
                           sk.[KesinUcret],
                           ISNULL(SUM(o.[OdemeTutari]), 0) AS [ToplamOdenen],
                           sk.[KesinUcret] - ISNULL(SUM(o.[OdemeTutari]), 0) AS [KalanTutar]
                         FROM ServisKayitlari sk
                         INNER JOIN Musteriler m ON sk.[MusteriID] = m.[MusteriID]
                         INNER JOIN Cihazlar c ON sk.[CihazID] = c.[CihazID]
                         LEFT JOIN Odemeler o ON sk.[ServisID] = o.[ServisID]
                         GROUP BY 
                           sk.[ServisID],
                           m.[Ad],
                           m.[Soyad],
                           c.[Marka],
                           c.[Model],
                           c.[IMEI],
                           sk.[ArizaAciklama],
                           sk.[Durum],
                           sk.[KesinUcret]
                           ORDER BY sk.[ServisID] DESC";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable OdemeleriListele()
        {
            string query = @"
                           SELECT
                            o.[OdemeID],
                            o.[ServisID],
                            m.[Ad] + ' ' + m.[Soyad] AS [Musteri],
                            c.[Marka] + ' ' + c.[Model] AS [Cihaz],
                            o.[OdemeTutari],
                            o.[OdemeTipi],
                            o.[OdemeTarihi],
                            o.[Aciklama]
                           FROM Odemeler o
                           INNER JOIN ServisKayitlari sk ON sk.[ServisID] = o.[ServisID]
                           INNER JOIN Musteriler m ON sk.[MusteriID] = m.[MusteriID]
                           INNER JOIN Cihazlar c ON sk.[CihazID] = c.[CihazID]
                           ORDER BY o.[OdemeID] DESC";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ServiseGoreOdemeleriListele(int servisId)
        {
            string query = @"
                          SELECT
                          o.[OdemeID],
                          o.[servisID],
                          o.[OdemeTutari],
                          o.[OdemeTipi],
                          o.[OdemeTarihi],
                          o.[Aciklama]
                          FROM Odemeler o
                          WHERE o.[ServisID] = @servisID
                          ORDER BY o.[OdemeID] DESC";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisID", servisId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public bool OdemeEkle(Odeme odeme)
        {
            string query = @"INSERT INTO Odemeler
                           ([ServisID],
                            [OdemeTutari],
                            [OdemeTipi],
                            [Aciklama])
                           VALUES
                           (@servisId,
                            @odemeTutari,
                            @odemeTipi,
                            @aciklama)";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisId", odeme.ServisID);
                    cmd.Parameters.AddWithValue("@odemeTutari", odeme.OdemeTutari);
                    cmd.Parameters.AddWithValue("@odemeTipi", odeme.OdemeTipi);

                    cmd.Parameters.AddWithValue("@aciklama",
                        string.IsNullOrWhiteSpace(odeme.Aciklama) ? DBNull.Value : odeme.Aciklama);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool OdemeSil(int odemeId)
        {
            string query = @"DELETE FROM Odemeler WHERE OdemeID = @odemeID";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@odemeID", odemeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public decimal ToplamOdenenGetir(int servisId)
        {
            string query = @"SELECT
                          ISNULL(SUM([OdemeTutari]), 0)
                          FROM Odemeler
                          WHERE [ServisID] = @servisId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisId", servisId);

                    decimal toplamOdenen = Convert.ToDecimal(cmd.ExecuteScalar());

                    return toplamOdenen;
                }
            }
        }

        public decimal? KesinUcretGetir(int servisId)
        {
            string query = @"SELECT
                           [KesinUcret]
                           FROM Serviskayitlari
                           WHERE [ServisID] = @servisId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisId", servisId);

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return null;
                    }

                    return Convert.ToDecimal(result);
                }
            }
        }

        public bool ServisKaydiVarMi(int servisId)
        {
            string query = @"SELECT COUNT(*)
                           FROM ServisKayitlari
                           WHERE [ServisID] = @servisId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisId", servisId);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public bool OdemeVarMi(int odemeId)
        {
            string query = @"SELECT COUNT(*)
                           FROM Odemeler
                           WHERE [OdemeID] = @odemeId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@odemeId", odemeId);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public DataTable OdemeAra(string aranan)
        {
            string query = @"
                         SELECT
                          o.[OdemeID],
                          o.[ServisID],
                          m.[Ad] + ' ' + m.[Soyad] AS [Musteri],
                          c.[Marka] + ' ' + c.[Model] AS [Cihaz],
                          o.[OdemeTutari],
                          o.[OdemeTipi],
                          o.[OdemeTarihi],
                          o.[Aciklama]
                         FROM Odemeler o
                         INNER JOIN ServisKayitlari sk ON sk.[ServisID] = o.[ServisID]
                         INNER JOIN Musteriler m ON sk.[MusteriID] = m.[MusteriID]
                         INNER JOIN Cihazlar c ON sk.[CihazID] = c.[CihazID]
                         WHERE m.[Ad] LIKE @aranan
                         OR m.[Soyad] LIKE @aranan
                         OR c.[Marka] LIKE @aranan
                         OR c.[Model] LIKE @aranan
                         OR o.[OdemeTipi] LIKE @aranan
                         OR o.[Aciklama] LIKE @aranan
                         OR CAST(o.[ServisID] AS NVARCHAR(20)) LIKE @aranan
                         ORDER BY o.[OdemeID] DESC";


            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
