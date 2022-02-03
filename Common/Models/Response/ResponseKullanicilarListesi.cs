using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Response
{
    public class ResponseKullanicilarListesi
    {
        public string Kodu { get; set; }
        public string Sifre { get; set; }
        public string AdiSoyadi { get; set; }
        public int Yetki { get; set; }
    }
}
