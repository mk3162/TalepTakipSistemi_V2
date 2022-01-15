﻿using Common.Models.Response;
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
        RequestResponse<T> MetodPost<T, Y>(string url, Y model);
        RequestResponse<T> GetDepartmanlarListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetServislerListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetLokasyonlarListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetMasrafMerkezleriListesi<T, Y>(string url, Y model);
        RequestResponse<T> GetProjelerListesi<T, Y>(string url, Y model);

    }
}