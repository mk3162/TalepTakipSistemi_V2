using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Response
{
    public class ResponsePersonellerListesiDto
    {
        public string Kodu { get; set; }
        public string AdiSoyadi { get; set; }
        public string Unvani { get; set; }
        public int Oncelik { get; set; }
        public int Pasif { get; set; }
    }
}
