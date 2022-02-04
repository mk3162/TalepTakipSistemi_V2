using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Request
{
    public class RequestTaleplerSurecIslemDto
    {
        public int TalepSiraNo { get; set; }
        public int TalepSurecSiraNo { get; set; }
        public int IslemSiraNo { get; set; }
        public string IslemYapanKodu { get; set; }
        public int IslemTipi { get; set; }
        public string Aciklama { get; set; }
        public string SahibiKodu { get; set; }
        public string IslemYapacakKodu { get; set; }
        public int Sonuc { get; set; }


    }
}
