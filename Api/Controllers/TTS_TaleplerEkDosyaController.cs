using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class TTS_TaleplerEkDosyaController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerEkDosyaController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetTaleplerEkDosyaListesi")]
        public BaseResponseApi<ResponseTaleplerEkDosyaListesiDto> GetTaleplerEkDosyaListesi(RequestTaleplerEkDosyaListesiDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerEkDosyaListesiDto>(GlobalEnum.StoredProcedure.TaleplerEkDosyaListesi, model);
    }
}
