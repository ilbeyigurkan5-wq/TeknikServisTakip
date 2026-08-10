using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;

namespace TeknikServisTakip.Repositories.cs
{
    public class MusteriRepository
    {
        private readonly string _baglanti;

        public MusteriRepository(string baglanti)
        {
            _baglanti = baglanti;
        }


        public DataTable MusterileriListele()
        {
            string query =
                "SELECT [MusteriID], [Ad], [Soyad], [TelefonNo], [İl], [İlce] FROM Musteriler ORDER BY [MusteriID] DESC"; 
                

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

        public bool MusteriEkle(Musteriler musteri)
        {
            string query = "INSERT INTO Musteriler ([Ad], [Soyad], [TelefonNo], [İl], [İlce]) VALUES (@musteriAd, @musteriSoyad, @telefonNo, @il, @ilce)";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriAd", musteri.MusteriAd);
                    cmd.Parameters.AddWithValue("@musteriSoyad", musteri.MusteriSoyad);
                    cmd.Parameters.AddWithValue("@telefonNo", musteri.MusteriTelNo);
                    cmd.Parameters.AddWithValue("@il", musteri.MusteriIl);
                    cmd.Parameters.AddWithValue("@ilce", musteri.MusteriIlce);

                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    return etkilenenSatir > 0;
                }
            }
        }

        public bool MusteriGuncelle(Musteriler musteri)
        {
            string query =
                "UPDATE Musteriler SET [Ad] = @musteriAd, [Soyad] = @musteriSoyad, [TelefonNo] = @telefonNo, [İl] = @il, [İlce] = @ilce WHERE [MusteriID] = @musteriId";



            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriAd", musteri.MusteriAd);
                    cmd.Parameters.AddWithValue("@musteriSoyad", musteri.MusteriSoyad);
                    cmd.Parameters.AddWithValue("@telefonNo", musteri.MusteriTelNo);
                    cmd.Parameters.AddWithValue("@il", musteri.MusteriIl);
                    cmd.Parameters.AddWithValue("@ilce", musteri.MusteriIlce);
                    cmd.Parameters.AddWithValue("@musteriId", musteri.MusteriID);

                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    return etkilenenSatir > 0;
                }
            }
        }

        public bool MusteriSil(int musteriId)
        {
            string query = "DELETE FROM Musteriler WHERE [MusteriID] = @musteriId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);

                    int silindiMi = cmd.ExecuteNonQuery();

                    return silindiMi > 0;
                }
            }
        }

        public DataTable MusteriAra(string musteriAdi)
        {
            string query = "SELECT * FROM Musteriler WHERE [Ad] LIKE @musteriAdi";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@musteriAdi", "%" + musteriAdi + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;

                }
            }
        }


        public bool BaskaBuTelefonVarMı(string telefonNo, int musteriId)
        {
            string query = "SELECT COUNT(*) FROM Musteriler WHERE [TelefonNo] = @telefonNo AND [MusteriID] <> @musteriId";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@telefonNo", telefonNo);
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);

                    int VarMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return VarMi > 0;

                }
            }
        }

        public bool TelefonVarMı(string telefonNo)
        {
            string query = "SELECT COUNT(*) FROM Musteriler WHERE [TelefonNo] = @telefonNo";

            using (SqlConnection con = new SqlConnection(_baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@telefonNo", telefonNo);

                    int kayitVarMi = Convert.ToInt32(cmd.ExecuteScalar());

                    return kayitVarMi > 0;
                }
            }
        }
    }
}
