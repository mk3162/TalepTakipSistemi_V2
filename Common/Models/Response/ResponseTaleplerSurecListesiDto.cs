using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Response
{
    public class ResponseTaleplerSurecListesiDto
    {
        public int SiraNo { get; set; }
        public int IslemSiraNo { get; set; }
        public string YapilanIslem { get; set; }
        public DateTime? IslemZamani { get; set; }
        public string IslemYapanAdi { get; set; }
        public string Aciklama { get; set; }


    }
}
