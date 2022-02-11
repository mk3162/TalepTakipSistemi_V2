using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Request
{
    public class RequestTaleplerEkDosyaKaydetDto
    {
        public int SiraNo { get; set; }
        public int GrupSiraNo { get; set; }
        public string Aciklama { get; set; }
        public string DosyaYolu { get; set; }
        public string DosyaAdi { get; set; }
        public string Url { get; set; }
    }
}
