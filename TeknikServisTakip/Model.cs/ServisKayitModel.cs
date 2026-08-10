using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServisTakip.Model.cs
{
    public class ServisKayit
    {
        public int servisID { get; set; }

        public int musteriID { get; set; }
        public int cihazID { get; set; }

        public string arizaAciklama { get; set; }
        public string durum { get; set; }


        public decimal? tahminiUcret { get; set; }
        public decimal? kesinUcret { get; set; }

        public DateTime kayitTarihi { get; set; }
        public bool teslimEdildiMi { get; set; }

        public DateTime? teslimTarihi { get; set; }
    }
}
