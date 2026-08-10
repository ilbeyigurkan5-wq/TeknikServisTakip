using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;

namespace TeknikServisTakip.Services
{
    public class ServisKayitService
    {
        private readonly ServisKayitRepository _serviceKayitRepository;

        public ServisKayitService(ServisKayitRepository servisKayitRepository)
        {
            _serviceKayitRepository = servisKayitRepository;
        }

        public bool FormKontrol(ServisKayit servisKayit,out string hataMesaj)
        {
            hataMesaj = "";

            if (servisKayit == null)
            {
                hataMesaj = "Kayıt bilgileri alınamadı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (servisKayit.musteriID <= 0)
            {
                hataMesaj = "Müşteri ID bilgisi geçersiz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (servisKayit.cihazID <= 0)
            {
                hataMesaj = "Cihaz ID bilgisi geçersiz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(servisKayit.arizaAciklama))
            {
                hataMesaj = "Arıza açıklaması boş bırakılamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(servisKayit.durum))
            {
                hataMesaj = "Durum bilgisi boş bırakılamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (servisKayit.tahminiUcret.HasValue && servisKayit.tahminiUcret < 0)
            {
                hataMesaj = "Tahmini ücret 0'dan daha küçük olamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (servisKayit.kesinUcret.HasValue && servisKayit.kesinUcret < 0)
            {
                hataMesaj = "Kesin ücret 0'dan daha küçük olamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            return true;
        }

        public DataTable ServisKayitliListele()
        {
            return _serviceKayitRepository.ServisKayitlariListele();
        }

        public bool ServisKayitEkle(ServisKayit servisKayit,out string mesaj)
        {
            mesaj = "";

            if (!FormKontrol(servisKayit,out string hataMesaj))
            {
                mesaj = hataMesaj;
                return false;
            }

            bool varMi = _serviceKayitRepository.AktifServisKaydiVarMi(servisKayit.cihazID, servisKayit.musteriID);

            if (varMi)
            {
                mesaj = "Girmiş olduğunuz bilgilerdeki cihaz zaten sistemde kayıtlı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _serviceKayitRepository.ServisKayitEkle(servisKayit);

            if (!basariliMi)
            {
                mesaj = "Maalesef servis kayıt işlemi gerçekleştirilemedi\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Servis kayıt işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public bool SevisKayitGuncelle(ServisKayit servisKayit,out string mesaj)
        {
            mesaj = "";

            if (!FormKontrol(servisKayit,out string hataMesaj))
            {
                mesaj = hataMesaj;
                return false;
            }

            if (servisKayit.servisID <= 0)
            {
                mesaj = "Geçersiz servis ID bilgisi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool varMi = _serviceKayitRepository.BaskaAktifKayitVarMi(servisKayit.cihazID, servisKayit.musteriID, servisKayit.servisID);

            if (varMi)
            {
                mesaj = "Girmiş olduğunuz bilgilerdeki cihaz zaten sistemde kayıtlı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _serviceKayitRepository.ServisKayitGuncelle(servisKayit);

            if (!basariliMi)
            {
                mesaj = "Maalesef servis kaydı güncelleme işlemi gerçekleştirilemedi\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Servis kaydı güncelleme işlemi başarıyla gerçekleştirildi.";

            return true;
        }

        public DataTable KayitAra(string aranan)
        {
            return _serviceKayitRepository.ServisAra(aranan);
        }

        public bool TeslimEt(int servisId, out string mesaj)
        {
            mesaj = "";


            if (servisId <= 0)
            {
                mesaj = "Geçersiz servis ID bilgisi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool varMi = _serviceKayitRepository.ServisZatenTeslimEdilmisMi(servisId);

            if (varMi)
            {
                mesaj = "Bu kayıt zaten teslim edilmiş!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _serviceKayitRepository.TeslimEt(servisId);

            if (!basariliMi)
            {
                mesaj = "Maalesef teslimat işlemi gerçekleştirilemedi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Teslimat işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public bool ServiskayitSil(int servisId, out string mesaj)
        {
            mesaj = "";

            if (servisId <= 0)
            {
                mesaj = "Geçersiz servis ID bilgisi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _serviceKayitRepository.ServisKayitSil(servisId);

            if (!basariliMi)
            {
                mesaj = "Maalesef servis kaydı silme işlemi gerçekleştirilemedi\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Servis kaydı silme işlemi başarıyla gerçekleştirildi.";
            return true;
        }
    }
}
