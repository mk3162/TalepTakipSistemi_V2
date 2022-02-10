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
        public string GetBirimlerListesi { get; set; }
        public string GetIslemTipleriListesi { get; set; }
        public string GetSurecTipleriListesi { get; set; }
        public string GetKullanicilarListesi { get; set; }
        public string GetParaBirimleriListesi { get; set; }
        public string GetTalepSahibiListesi { get; set; }


        public string GetDepartmanlarListesi { get; set; }
        public string GetServislerListesi { get; set; }
        public string GetLokasyonlarListesi { get; set; }
        public string GetMasrafMerkezleriListesi { get; set; }
        public string GetProjelerListesi { get; set; }
        public string GetPersonellerListesi { get; set; }
        public string GetTaleplerIslemListesi { get; set; }
        public string GetTaleplerSurecListesi { get; set; }
        public string GetTaleplerEkDosyaListesi { get; set; }

        public string PostTaleplerKaydet { get; set; }

    }
}
