using Common.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ServiceUrlList
    {
        public string GetSirketlerListesi { get; set; }
        public string GetTedarikcilerListesi { get; set; }
        public string GetTiplerListesi { get; set; }
        public string GetUrunlerListesi { get; set; }
        public string GetDepartmanlarListesi { get; set; }
        public string GetServislerListesi { get; set; }
        public string GetLokasyonlarListesi { get; set; }
        public string GetMasrafMerkezleriListesi { get; set; }
        public string GetProjelerListesi { get; set; }

    }
}
