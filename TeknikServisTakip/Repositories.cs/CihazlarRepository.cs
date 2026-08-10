using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;

namespace TeknikServisTakip.Repositories.cs
{
    public class CihazlarRepository
    {
        private readonly string _baglanti;

        public CihazlarRepository(string baglanti)
        {
            _baglanti = baglanti;
        }

        public DataTable CihazlarListele()
        {
            string query = @"
                           SELECT
                           c.[CihazID],
                           c.[MusteriID],
                           m.[Ad] + '  ' + m.[Soyad] AS Musteri,
                           c.[Marka],
                           c.[Model],
                           c.[IMEI],
                           c.[SeriNo],
                           c.[KayitTarihi]
                           FROM Cihazlar c
                           INNER JOIN Musteriler m ON c.[MusteriID] = m.[MusteriID]
                           ORDER BY c.[CihazID] DESC";

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

        public bool CihazEkle(Cihaz cihaz)
        {
            string query = @"
                           INSERT INTO Cihazlar
                           ([MusteriID], [Marka], [Model], [IMEI], [SeriNo]) 
                           VALUES (@musteriID, @marka, @model, @ımeı, @serino)";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriID", cihaz.MusteriID);
                    cmd.Parameters.AddWithValue("@marka", cihaz.Marka);
                    cmd.Parameters.AddWithValue("@model", cihaz.Model);
                    cmd.Parameters.AddWithValue("@ımeı", cihaz.IMEI);
                    cmd.Parameters.AddWithValue("@serino", cihaz.SeriNo);

                    int etkileneSatir = Convert.ToInt32(cmd.ExecuteNonQuery());

                    return etkileneSatir > 0;
                }
            }
        }

        public DataTable MusterininCihazlarınıGetir(int musteriID)
        {
            string query = @"
                          SELECT [CihazID], [Marka], [Model], [IMEI], [SeriNo]
                          FROM Cihazlar
                          WHERE [MusteriID] = @musteriId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public bool CihazGuncelle(Cihaz cihaz)
        {
            string query = @"
                         UPDATE Cihazlar SET 
                         [MusteriID] = @musteriId,
                         [Marka] = @marka,
                         [Model] = @model,
                         [IMEI] = @Imeı,
                         [SeriNo] = @seriNo
                         WHERE [CihazID] = @cihazId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriId", cihaz.MusteriID);
                    cmd.Parameters.AddWithValue("@marka", cihaz.Marka);
                    cmd.Parameters.AddWithValue("@model", cihaz.Model);
                    cmd.Parameters.AddWithValue("@Imeı",cihaz.IMEI);
                    cmd.Parameters.AddWithValue("@seriNo", cihaz.SeriNo);
                    cmd.Parameters.AddWithValue("@cihazId", cihaz.CihazID);

                    int etkilenenSatir = Convert.ToInt32(cmd.ExecuteNonQuery());

                    return etkilenenSatir > 0;
                }
            }
        }

        public bool CihazSil(int cihazID)
        {
            string query = "DELETE FROM Cihazlar WHERE [CihazID] = @cihazId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cihazId", cihazID);

                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    return etkilenenSatir > 0;
                }
            }
        }

        public DataTable CihazArama(string aranan)
        {
            string query = @"
                        SELECT
                        c.[CihazID],
                        c.[MusteriID],
                        m.[Ad] + ' ' + m.[Soyad] AS [Müşteri],
                        c.[Marka],
                        c.[Model],
                        c.[IMEI],
                        c.[SeriNo],
                        c.[KayitTarihi]
                        FROM Cihazlar c
                      INNER JOIN Musteriler m ON c.[MusteriID] = m.[MusteriId]
                      WHERE c.[Marka] LIKE @aranan
                      OR c.[Model] LIKE @aranan
                      OR c.[IMEI] LIKE @aranan
                      OR c.[SeriNo] LIKE @aranan
                      OR m.[Ad] LIKE @aranan
                      OR m.[Soyad] LIKE @aranan
                      ORDER BY c.[CihazID] DESC";

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

        public DataTable MusteriyeGoreCihazListele(int musteriId)
        {
            string query = @"
                          SELECT
                           [CihazID],
                           [MusteriID],
                           [Marka] + ' ' + [Model] AS [Cihaz bilgisi],
                           [Marka],
                           [Model],
                           [IMEI],
                           [SeriNo],
                           [KayitTarihi]
                          FROM Cihazlar
                          WHERE [MusteriID] = @musteriId
                          ORDER BY [CihazID] DESC";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public bool ImeıVarMı(string ımeı)
        {
            string query = "SELECT COUNT(*) FROM Cihazlar WHERE [IMEI] = @ımeı";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ımeı", ımeı);

                    int kayitVarMı = Convert.ToInt32(cmd.ExecuteScalar());

                    return kayitVarMı > 0;
                }
            }
        }


        public bool BuImeıBaskaKayıttaVarMı(int cihazID, string ımeı)
        {
            string query = @"
                         SELECT COUNT(*) FROM Cihazlar
                         WHERE [IMEI] = @ımeı 
                         AND [CihazID] <> @cihazId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ımeı", ımeı);
                    cmd.Parameters.AddWithValue("@cihazId", cihazID);

                    int kayitVarMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return kayitVarMi > 0;
                }
            }
        }
    }
}
