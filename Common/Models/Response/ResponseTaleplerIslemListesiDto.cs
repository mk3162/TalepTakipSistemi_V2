using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Response
{
    public class ResponseTaleplerIslemListesiDto
    {
        public int TalepSiraNo { get; set; }
        public string TalepSahibiAdi { get; set; }
        public string UrunTanimi { get; set; }
        public decimal Miktar { get; set; }
        public string MiktarBirim { get; set; }
        public decimal BirimFiyat { get; set; }
    }
}
