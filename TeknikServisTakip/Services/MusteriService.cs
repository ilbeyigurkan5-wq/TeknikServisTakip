using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;

namespace TeknikServisTakip.Services
{
    public class MusteriService
    {
        private readonly MusteriRepository _musteriRepository;

        public MusteriService(MusteriRepository musteriRepository)
        {
            _musteriRepository = musteriRepository;
        }

        public bool İslemKontrol(Musteriler musteri,out string hatamesajı)
        {
            hatamesajı = "";

            if (string.IsNullOrWhiteSpace(musteri.MusteriAd))
            {
                hatamesajı = "Müşteri adı bilgisi boş bırakılamaz!\nBilgileri kontrol ediniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(musteri.MusteriSoyad))
            {
                hatamesajı = "Müşteri soyad bilgisi boş bırakılamaz!\nBilgileri kontrol ediniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(musteri.MusteriTelNo))
            {
                hatamesajı = "Telefon numarası boş bırakılamaz!\nBilgileri kontrol ediniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(musteri.MusteriIl))
            {
                hatamesajı = "İl bilgisi boş bırakılamaz!\nBilgileri kontrol ediniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(musteri.MusteriIlce))
            {
                hatamesajı = "İlçe bilgisi boş bırakılamaz!\nBilgileri kontrol ediniz.";
                return false;
            }

            return true;
        }

        public DataTable MusteriListele()
        {
            return _musteriRepository.MusterileriListele();
        }

        public bool MusteriEkle(Musteriler musteri,out string mesaj)
        {
            mesaj = "";

            if (musteri == null)
            {
                mesaj = "Müşteri bilgileri alınmadı!\nBilgileri kontrol edip lütfen tekrar deneyiniz.";
                return false;
            }

            if (!İslemKontrol(musteri,out string hatamesajı))
            {
                mesaj = hatamesajı;
                return false;
            }

            bool varMi = _musteriRepository.TelefonVarMı(musteri.MusteriTelNo);

            if (varMi)
            {
                mesaj = "Girdiğiniz telefon numarası sistemde zaten kayıtlı!\n" +
                    "Bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _musteriRepository.MusteriEkle(musteri);

            if (!basariliMi)
            {
                mesaj = "Maalesef müşteri kayıt etme işlemi gerçekleştirilemedi!\n" +
                    "Bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Müşteri kayıt etme işlemi başarıyla gerçekleştirildi.";
            return true;
        }


        public bool MusteriGuncelle(Musteriler musteri,out string mesaj)
        {
            mesaj = "";

            if (musteri == null)
            {
                mesaj = "Müşteri bilgileri alınmadı!\nBilgileri kontrol edip lütfen tekrar deneyiniz.";
                return false;
            }

            if (musteri.MusteriID <= 0)
            {
                mesaj = "Geçersiz Müşteri ID bilgisi\n Bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (!İslemKontrol(musteri,out string hatamesajı))
            {
                mesaj = hatamesajı;
                return false;
            }

            bool VarMi = _musteriRepository.BaskaBuTelefonVarMı(musteri.MusteriTelNo, musteri.MusteriID);

            if (VarMi)
            {
                mesaj = "Girmiş olduğunuz telefon numarası zaten sistemde kayıtlı!\n" +
                    "Bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _musteriRepository.MusteriGuncelle(musteri);

            if (!basariliMi)
            {
                mesaj = "Maalesef müşteri kayıt işlemi gerçekleştirilemedi!\n" +
                    "Bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Müşteri güncelleme işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public DataTable MusteriAra(Musteriler musteri)
        {
            return _musteriRepository.MusteriAra(musteri.MusteriAd);
        }

        public bool MusteriSil(int musteriId,out string mesaj)
        {
            mesaj = "";

            if (musteriId <= 0)
            {
                mesaj = "Geçersiz müşteri blgisi bilgileri kontrol edip.\nTekrar deneyiniz!";
                return false;
            }

            bool silindiMi = _musteriRepository.MusteriSil(musteriId);

            if (!silindiMi)
            {
                mesaj = "Maalesef müşteri silinemedi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Müşteri silme işlemi başarıyla gerçekleşti.";
            return true;
        }
    }
}
