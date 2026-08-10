using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;

namespace TeknikServisTakip.Repositories.cs
{
    public class ServisKayitRepository
    {
        private readonly string _baglanti;

        public ServisKayitRepository(string baglanti)
        {
            _baglanti = baglanti;
        }

        public DataTable ServisKayitlariListele()
        {
            string query = @"
                        SELECT 
                         sk.[ServisID],
                         sk.[MusteriID],
                         m.[Ad] + ' ' + m.[Soyad] AS [Musteri],
                         sk.[CihazID],
                         c.[Marka],
                         c.[Model],
                         c.[IMEI],
                         c.[SeriNo],
                         sk.[ArizaAciklama] AS [Arıza],
                         sk.[Durum],
                         sk.[TahminiUcret],
                         sk.[KesinUcret],
                         sk.[KayitTarihi],
                         sk.[TeslimEdildiMi],
                         sk.[TeslimTarihi]
                      FROM ServisKayitlari sk
                      INNER JOIN Musteriler m ON sk.[MusteriID] = m.[MusteriID]
                      INNER JOIN Cihazlar c ON sk.[CihazID] = c.[CihazID]
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

        public bool ServisKayitEkle(ServisKayit servisKayit)
        {
            string query = @"
                           INSERT INTO Serviskayitlari

                         (
                           [MusteriID],
                           [CihazID],
                           [ArizaAciklama],
                           [Durum],
                           [TahminiUcret],
                           [KesinUcret],
                           [TeslimEdildiMi],
                           [TeslimTarihi]
                         )
                           VALUES
                         (
                           @musteriId,
                           @cihazId,
                           @arizaAciklama,
                           @durum,
                           @tahminiucret,
                           @kesinUcret,
                           @teslimEdildiMi,
                           @teslimTarihi
                            
                         )";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriId", servisKayit.musteriID);
                    cmd.Parameters.AddWithValue("@cihazId", servisKayit.cihazID);
                    cmd.Parameters.AddWithValue("@arizaAciklama", servisKayit.arizaAciklama);
                    cmd.Parameters.AddWithValue("@durum", servisKayit.durum);

                    cmd.Parameters.AddWithValue(
                        "@tahminiUcret",
                        servisKayit.tahminiUcret.HasValue ? (object)servisKayit.tahminiUcret.Value : DBNull.Value
                    );

                    cmd.Parameters.AddWithValue("@kesinUcret",
                         servisKayit.kesinUcret.HasValue ? (object)servisKayit.kesinUcret.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@teslimEdildiMi", servisKayit.teslimEdildiMi);

                    cmd.Parameters.AddWithValue("@teslimTarihi",
                        servisKayit.teslimTarihi.HasValue ? (object)servisKayit.teslimTarihi.Value : DBNull.Value);


                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    return etkilenenSatir > 0;
                }
            }
        }

        public bool ServisKayitGuncelle(ServisKayit servis)
        {
            string query = @"
                           UPDATE ServisKayitlari SET
                           [MusteriID] = @musteriId,
                           [cihazID] = @cihazId,
                           [ArizaAciklama] = @arizaAciklama,
                           [Durum] = @durum,
                           [TahminiUcret] = @tahminiUcret,
                           [KesinUcret] = @kesinUcret
                           WHERE [ServisID] = @servisId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriId", servis.musteriID);
                    cmd.Parameters.AddWithValue("@cihazId", servis.cihazID);
                    cmd.Parameters.AddWithValue("@arizaAciklama", servis.arizaAciklama);
                    cmd.Parameters.AddWithValue("@durum", servis.durum);

                    cmd.Parameters.AddWithValue("@tahminiUcret",
                        servis.tahminiUcret.HasValue ? (object)servis.tahminiUcret.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@kesinUcret",
                        servis.kesinUcret.HasValue ? (object)servis.kesinUcret.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@servisId", servis.servisID);

                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    return etkilenenSatir > 0;
                }
            }
        }

        public bool ServisKayitSil(int servisID)
        {
            string query = "DELETE FROM ServisKayitlari WHERE [ServisID] = @servisId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisId", servisID);

                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    return etkilenenSatir > 0;
                }
            }
        }

        public bool TeslimEt(int servisID)
        {
            string query = @"
                       UPDATE ServisKayitlari SET
                       [TeslimEdildiMi] = 1,
                       [TeslimTarihi] = @teslimTarihi,
                       [Durum] = @durum
                       WHERE [ServisID] = @servisId
                       AND [TeslimEdildiMi] = 0";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@teslimTarihi", DateTime.Now);
                    cmd.Parameters.AddWithValue("@durum", "Teslim edildi");
                    cmd.Parameters.AddWithValue("@servisId", servisID);

                    int basariliMi = cmd.ExecuteNonQuery();

                    return basariliMi > 0;
                }
            }
        }

        public DataTable ServisAra(string aranan)
        {
            string query = @"
                        SELECT
                         sk.[ServisID],
                         sk.[MusteriID],
                         m.[Ad] + ' ' + m.[Soyad] AS Musteri,
                         sk.[CihazID],
                         c.[Marka],
                         c.[Model],
                         c.[IMEI],
                         c.[SeriNo],
                         sk.[ArizaAciklama],
                         sk.[Durum],
                         sk.[TahminiUcret],
                         sk.[KesinUcret],
                         sk.[KayitTarihi],
                         sk.[TeslimEdildiMi],
                         sk.[TeslimTarihi]
                        FROM ServisKayitlari sk
                        INNER JOIN Musteriler m ON sk.[MusteriID] = m.[MusteriID]
                        INNER JOIN Cihazlar c ON sk.[CihazID] = c.[CihazID]
                        WHERE m.[Ad] LIKE @aranan
                        OR m.[Soyad] LIKE @aranan
                        OR c.[Marka] LIKE @aranan
                        OR c.[Model] LIKE @aranan
                        OR c.[IMEI] LIKE @aranan
                        OR c.[SeriNo] LIKE @aranan
                        OR sk.[ArizaAciklama] LIKE @aranan
                        OR sk.[Durum] LIKE @aranan
                        ORDER BY sk.[ServisID] DESC";

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

        public bool AktifServisKaydiVarMi(int cihazId, int musteriId)
        {
            string query = @"
                          SELECT COUNT(*) FROM ServisKayitlari
                          WHERE [MusteriID] = @musteriId
                          AND [CihazID] = @cihazId
                          AND [TeslimEdildiMi] = 0";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cihazId", cihazId);
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);

                    int varMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return varMi > 0;
                }
            }
        }

        public bool BaskaAktifKayitVarMi(int cihazId, int musteriId, int servisId)
        {
            string query = @"
                          SELECT COUNT(*) FROM ServisKayitlari
                          WHERE [MusteriID] = @musteriId
                          AND [CihazID] = @cihazId
                          AND [ServisID] <> @servisId
                          AND [TeslimEdildiMi] = 0";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cihazId", cihazId);
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);
                    cmd.Parameters.AddWithValue("@servisId", servisId); 

                    int varMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return varMi > 0;
                }
            }
        }

        public bool ServisZatenTeslimEdilmisMi(int servisID)
        {
            string query = @"
                          SELECT COUNT(*) FROM ServisKayitlari
                          WHERE [ServisID] = @servisId
                          AND [TeslimEdildiMi] = 1";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@servisId", servisID);

                    int varMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return varMi > 0;
                }
            }
        }
    }
}
