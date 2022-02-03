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
    public class TTS_BirimlerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_BirimlerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetBirimlerListesi")]
        public BaseResponseApi<ResponseBirimlerListesiDto> GetBirimlerListesi() => _dbService.ExecuteSqlQuery<ResponseBirimlerListesiDto>(GlobalEnum.StoredProcedure.BirimlerListesi, null);
    }
}
