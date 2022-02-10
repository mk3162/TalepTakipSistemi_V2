using Common.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Service.Interface
{
    public interface IApiService
    {
        RequestResponse<T> GetSirketlerListesi<T>(string url);
        RequestResponse<T> GetTedarikcilerListesi<T>(string url);
        RequestResponse<T> GetTiplerListesi<T>(string url);
        RequestResponse<T> GetUrunlerListesi<T>(string url);
        RequestResponse<T> GetBirimlerListesi<T>(string url);
        RequestResponse<T> GetIslemTipleriListesi<T>(string url);
        RequestResponse<T> GetSurecTipleriListesi<T>(string url);
        RequestResponse<T> GetKullanicilarListesi<T>(string url);
        RequestResponse<T> GetParaBirimleriListesi<T>(string url);
        RequestResponse<T> GetTalepSahibiListesi<T>(string url);


        RequestResponse<T> MetodPost<T, Y>(string url, Y model);
        RequestResponse<T> GetDepartmanlarListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetServislerListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetLokasyonlarListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetMasrafMerkezleriListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetProjelerListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetPersonellerListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetTaleplerIslemListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetTaleplerSurecListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetTaleplerEkDosyaListesi<T, Y>(string url, Y model);

        RequestResponse<T> PostTaleplerKaydet<T, Y>(string url, Y model);

    }
}
