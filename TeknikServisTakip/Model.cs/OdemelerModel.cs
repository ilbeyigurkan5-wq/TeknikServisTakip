using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServisTakip.Model.cs
{
    public class Odeme
    {
        public int OdemeID { get; set; }
        public int ServisID { get; set; }

        public decimal OdemeTutari { get; set; }
        public string OdemeTipi { get; set; } = "";
        public DateTime OdemeTarihi { get; set; }
        public string Aciklama { get; set; } = "";
    }
}
