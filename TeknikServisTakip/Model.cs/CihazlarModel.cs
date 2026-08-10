using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServisTakip.Model.cs
{
    public class Cihaz
    {
        public int CihazID { get; set; }
        public int MusteriID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public string SeriNo { get; set; }
        public DateTime kayitTarihi { get; set; }
    }
}
