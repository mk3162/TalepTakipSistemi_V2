using Common.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Service.Implementation
{
    public class ApiService : IApiService
    {
        private readonly IServiceManager _serviceManager;

        public ApiService(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public RequestResponse<T> GetSirketlerListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }
        public RequestResponse<T> GetTedarikcilerListesi<T>(string url)
        {

            return _serviceManager.Get<T>(url);
        }

        public RequestResponse<T> GetTiplerListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }
        public RequestResponse<T> GetUrunlerListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }
        public RequestResponse<T> GetBirimlerListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }
        public RequestResponse<T> GetIslemTipleriListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }
        public RequestResponse<T> GetSurecTipleriListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }
        public RequestResponse<T> GetKullanicilarListesi<T>(string url)
        {
            return _serviceManager.Get<T>(url);
        }

        public RequestResponse<T> MetodPost<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }


        public RequestResponse<T> GetDepartmanlarListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }

        public RequestResponse<T> GetServislerListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }

        public RequestResponse<T> GetLokasyonlarListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }

        public RequestResponse<T> GetMasrafMerkezleriListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }

        public RequestResponse<T> GetProjelerListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }
        public RequestResponse<T> GetPersonellerListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }

        public RequestResponse<T> GetTaleplerIslemListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }

        public RequestResponse<T> GetTaleplerSurecListesi<T, Y>(string url, Y model)
        {
            return _serviceManager.Post<T, Y>(url, model);
        }
    }
}
