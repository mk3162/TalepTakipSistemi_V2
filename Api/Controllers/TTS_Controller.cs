using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_Controller : Controller
    {
        private readonly IDBService _dbService;
        public TTS_Controller(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetSirketlerListesi")]
        public BaseResponseApi<ResponseSirketlerListesiDto> GetSirketlerListesi() => _dbService.ExecuteSqlQuery<ResponseSirketlerListesiDto>(GlobalEnum.StoredProcedure.SirketlerListesi, null);

        [HttpGet]
        [Route("GetTedarikcilerListesi")]
        public BaseResponseApi<ResponseTedarikcilerListesiDto> GetTedarikcilerListesi() => _dbService.ExecuteSqlQuery<ResponseTedarikcilerListesiDto>(GlobalEnum.StoredProcedure.TedarikcilerListesi, null);

        [HttpGet]
        [Route("GetTiplerListesi")]
        public BaseResponseApi<ResponseTiplerListesiDto> GetTiplerListesi() => _dbService.ExecuteSqlQuery<ResponseTiplerListesiDto>(GlobalEnum.StoredProcedure.TiplerListesi, null);

        [HttpGet]
        [Route("GetUrunlerListesi")]
        public BaseResponseApi<ResponseUrunlerListesiDto> GetUrunlerListesi() => _dbService.ExecuteSqlQuery<ResponseUrunlerListesiDto>(GlobalEnum.StoredProcedure.UrunlerListesi, null);

        [HttpPost]
        [Route("GetDepartmanlarListesi")]
        public BaseResponseApi<ResponseDepartmanlarListesiDto> GetDepartmanlarListesi(RequestDepartmanlarListesiDto model) => _dbService.ExecuteSqlQuery<ResponseDepartmanlarListesiDto>(GlobalEnum.StoredProcedure.DepartmanlarListesi, model);

        [HttpPost]
        [Route("GetServislerListesi")]
        public BaseResponseApi<ResponseServislerListesiDto> GetServislerListesi(RequestServislerListesiDto model) => _dbService.ExecuteSqlQuery<ResponseServislerListesiDto>(GlobalEnum.StoredProcedure.ServislerListesi, model);

        [HttpPost]
        [Route("GetLokasyonlarListesi")]
        public BaseResponseApi<ResponseLokasyonlarListesiDto> GetLokasyonlarListesi(RequestLokasyonlarListesiDto model) => _dbService.ExecuteSqlQuery<ResponseLokasyonlarListesiDto>(GlobalEnum.StoredProcedure.LokasyonlarListesi, model);

        [HttpPost]
        [Route("GetMasrafMerkezleriListesi")]
        public BaseResponseApi<ResponseMasrafMerkezleriListesiDto> GetMasrafMerkezleriListesi(RequestMasrafMerkezleriListesiDto model) => _dbService.ExecuteSqlQuery<ResponseMasrafMerkezleriListesiDto>(GlobalEnum.StoredProcedure.MasrafMerkezleriListesi, model);

        [HttpPost]
        [Route("GetProjelerListesi")]
        public BaseResponseApi<ResponseProjelerListesiDto> GetProjelerListesi(RequestProjelerListesiDto model) => _dbService.ExecuteSqlQuery<ResponseProjelerListesiDto>(GlobalEnum.StoredProcedure.ProjelerListesi, model);
    }
}
