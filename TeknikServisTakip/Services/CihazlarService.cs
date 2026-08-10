using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;

namespace TeknikServisTakip.Services
{
    public class CihazlarService
    {
        private readonly CihazlarRepository _cihazlarRepository;

        public CihazlarService(CihazlarRepository cihazlarRepository)
        {
            _cihazlarRepository = cihazlarRepository;
        }

        private bool FormKontrol(Cihaz cihaz,out string hataMesaj)
        {
            hataMesaj = "";

            if (cihaz == null)
            {
                hataMesaj = "Cihaz bilgileri alınamadı!\n Lütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (cihaz.MusteriID <= 0)
            {
                hataMesaj = "Geçersiz Müşteri ID bilgisi!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cihaz.Marka))
            {
                hataMesaj = "Cihazın marka bilgisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cihaz.Model))
            {
                hataMesaj = "Cihazın model bilgisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cihaz.IMEI))
            {
                hataMesaj = "Cihazın IMEI bilgisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cihaz.SeriNo))
            {
                hataMesaj = "Cihazın seri No bilgisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            return true;
        }

        public DataTable CihazlarıListele()
        {
            return _cihazlarRepository.CihazlarListele();
        }

        public bool CihazEkle(Cihaz cihaz,out string mesaj)
        {
            mesaj = "";

            if (!FormKontrol(cihaz,out string hataMesaj))
            {
                mesaj = hataMesaj;
                return false;
            }

            bool VarMi = _cihazlarRepository.ImeıVarMı(cihaz.IMEI);

            if (VarMi)
            {
                mesaj = "Girdiğiniz IMEI bilgisi zaten sistemde kayıtlı!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _cihazlarRepository.CihazEkle(cihaz);

            if (!basariliMi)
            {
                mesaj = "Maalesef cihaz kayıt işlemi gerçekleştirilemedi!\nLütfen bilgileri kontrol edip tekrar deneyiniz";
                return false;
            }

            mesaj = "Cihaz kayıt işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public bool CihazGuncelle(Cihaz cihaz,out string mesaj)
        {
            mesaj = "";

            if (!FormKontrol(cihaz,out string hataMesaj))
            {
                mesaj = hataMesaj;
                return false;
            }

            if (cihaz.CihazID <= 0)
            {
                mesaj = "Geçersiz Cihaz ID bilgisi!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool varMi = _cihazlarRepository.BuImeıBaskaKayıttaVarMı(cihaz.CihazID, cihaz.IMEI);

            if (varMi)
            {
                hataMesaj = "Girdiğiniz IMEI sistemde zaten kayıtlı\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _cihazlarRepository.CihazGuncelle(cihaz);

            if (!basariliMi)
            {
                mesaj = "Maalesef cihaz güncelleme işlemi gerçekleştirilemedi\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Cihaz güncelleme işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public bool CihazSil(Cihaz cihaz,out string mesaj)
        {
            mesaj = "";

            if (cihaz.CihazID <= 0)
            {
                mesaj = "Geçersiz Cihaz ID bilgisi!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basarilMi = _cihazlarRepository.CihazSil(cihaz.CihazID);

            if (!basarilMi)
            {
                mesaj = "Maalesef cihaz silinemedi!\nLütfen bilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Cihaz silme işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public DataTable CihazAra(string aranan)
        {
            return _cihazlarRepository.CihazArama(aranan);
        }

        public DataTable MusteriCihaziGetir(int musteriId)
        {
            return _cihazlarRepository.MusterininCihazlarınıGetir(musteriId);
        }
    }
}
