using System;
using System.Collections.Generic;
using System.Text;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;

namespace TeknikServisTakip.Services
{
    public class KullanıcıService
    {
        private readonly KullanıcıRepository _kullaniciRepository;

        public KullanıcıService(KullanıcıRepository kullanıcıRepository)
        {
            _kullaniciRepository = kullanıcıRepository;
        }

        public bool GirisKontrol(Kullanıcılar kullanıcı,out string mesaj)
        {
            mesaj = "";

            if (kullanıcı == null)
            {
                mesaj = "Geçersiz kullanıcı bilgileri tekrar deneyiniz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(kullanıcı.kullaniciAdi))
            {
                mesaj = "Kullanıcı Adı boş bırakılamaz! Tekrar deneyiniz";
                return false;
            }

            if (string.IsNullOrWhiteSpace(kullanıcı.kullaniciSifre))
            {
                mesaj = "Şifre boş bırakılamaz! Tekrar deneyiniz";
                return false;
            }

            bool eslestiMi = _kullaniciRepository.KullaniciGirisKontrol(kullanıcı.kullaniciAdi, kullanıcı.kullaniciSifre);

            if (!eslestiMi)
            {
                mesaj = "Kullanıcı adınızı veya şifrenizi yanlış girdiniz. Bilgilerinizi kontrol edip.\n Tekrar deneyiniz";
                return false;
            }

            mesaj = "Giriş Başarılı";
            return true;
        }
    }
}
