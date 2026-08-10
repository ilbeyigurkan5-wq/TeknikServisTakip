using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;

namespace TeknikServisTakip.Services
{
    public class OdemelerService
    {
        private readonly OdemelerRepository _odemelerRepository;

        public OdemelerService(OdemelerRepository odemelerRepository)
        {
            _odemelerRepository = odemelerRepository;
        }

        public DataTable ServisleriOdemeicinListele()
        {
            return _odemelerRepository.ServisleriOdemeİcinListele();
        }

        public DataTable OdemeleriListele()
        {
            return _odemelerRepository.OdemeleriListele();
        }

        public DataTable ServiseGoreOdemeleriListele(int servisId)
        {
            if (servisId <= 0)
            {
                return new DataTable();
            }

            return _odemelerRepository.ServiseGoreOdemeleriListele(servisId);
        }

        public bool OdemeKontrol(Odeme odeme, out string hataMesaj)
        {
            hataMesaj = "";

            if (odeme == null)
            {
                hataMesaj = "Ödeme bilgileri alınamadı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (odeme.ServisID <= 0)
            {
                hataMesaj = "Geçersiz servis ID bilgisi alınamadı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (odeme.OdemeTutari <= 0)
            {
                hataMesaj = "Ödeme tutarı 0 veya daha küçük olamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(odeme.OdemeTipi))
            {
                hataMesaj = "Ödeme seçilmedi ödeme tipi seçiniz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool varMi = _odemelerRepository.ServisKaydiVarMi(odeme.ServisID);

            if (!varMi)
            {
                hataMesaj = "Seçilen servis kaydı sistemde bulunamadı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            decimal? kesinUcret = _odemelerRepository.KesinUcretGetir(odeme.ServisID);

            if (!kesinUcret.HasValue)
            {
                hataMesaj = "Kesin ücret tutarı girilmeden ödeneme alınamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            if (kesinUcret.Value <= 0)
            {
                hataMesaj = "Kesin ücret 0 veya daha küçük olamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            decimal toplamOdenen = _odemelerRepository.ToplamOdenenGetir(odeme.ServisID);

            decimal kalanTutar = kesinUcret.Value - toplamOdenen;

            if (kalanTutar <= 0)
            {
                hataMesaj = "Bu servis kaydının ödemesi zaten tamamlanmış.";
                return false;
            }

            if (odeme.OdemeTutari > kalanTutar)
            {
                hataMesaj = "Ödeme tutarı kalan tutardan fazla olamaz!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            return true;
        }

        public bool OdemeEkle(Odeme odeme, out string mesaj)
        {
            mesaj = "";

            if (!OdemeKontrol(odeme, out string hataMEsaj))
            {
                mesaj = hataMEsaj;
                return false;
            }

            bool basariliMi = _odemelerRepository.OdemeEkle(odeme);

            if (!basariliMi)
            {
                mesaj = "Maalesf ödeme şlemi gerçekleştirilemedi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Ödeme işlemi başarıyla gerçekleştirildi.";
            return true;
        }

        public bool OdemeSil(int odemeId,out string mesaj)
        {
            mesaj = "";

            if (odemeId <= 0)
            {
                mesaj = "Geçersiz ödeme kaydı seçimi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool varMi = _odemelerRepository.OdemeVarMi(odemeId);

            if (!varMi)
            {
                mesaj = "Silinecek ödeme kaydı bulunamadı!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            bool basariliMi = _odemelerRepository.OdemeSil(odemeId);

            if (!basariliMi)
            {
                mesaj = "Maalesf ödeme kaydı silinemedi!\nBilgileri kontrol edip tekrar deneyiniz.";
                return false;
            }

            mesaj = "Ödeme kaydı başarıyla silindi.";
            return true;
        }

        public DataTable OdemeAra(string aranan)
        {
            if (string.IsNullOrWhiteSpace(aranan))
            {
                return _odemelerRepository.OdemeleriListele();
            }

            return _odemelerRepository.OdemeAra(aranan);
        }

        public decimal ToplamOdenenGetir(int servisId)
        {
            if (servisId <= 0)
            {
                return 0;
            }

            return _odemelerRepository.ToplamOdenenGetir(servisId);
        }

        public decimal KalanUcretGetir(int servisId)
        {
            if (servisId <= 0)
            {
                return 0;
            }

            decimal? kesinUcret = _odemelerRepository.KesinUcretGetir(servisId);

            if (!kesinUcret.HasValue)
            {
                return 0;
            }

            decimal toplamOdenen = _odemelerRepository.ToplamOdenenGetir(servisId);

            return kesinUcret.Value - toplamOdenen;
        }
    }
}
