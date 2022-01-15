using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Response
{
    public class ResponseMasrafMerkezleriListesiDto
    {
        public int SiraNo { get; set; }
        public string Tanimi { get; set; }
        public string MuhasebeKodu1 { get; set; }
        public string MuhasebeKodu2 { get; set; }
        public string MuhasebeKodu3 { get; set; }
    }
}
