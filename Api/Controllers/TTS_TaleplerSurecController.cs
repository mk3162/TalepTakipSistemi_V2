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
    [ApiController]
    public class TTS_TaleplerSurecController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerSurecController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetTaleplerSurecListesi")]
        public BaseResponseApi<ResponseTaleplerSurecListesiDto> GetTaleplerSurecListesi(RequestTaleplerSurecListesiDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerSurecListesiDto>(GlobalEnum.StoredProcedure.TaleplerSurecListesi, model);
    }
}
