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
    public class TTS_SurecTipleriController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_SurecTipleriController(IDBService dBService)
        {
            _dbService = dBService;
        }
        [HttpGet]
        [Route("GetSurecTipleriListesi")]
        public BaseResponseApi<ResponseSurecTipleriDto> GetSurecTipleriListesi() => _dbService.ExecuteSqlQuery<ResponseSurecTipleriDto>(GlobalEnum.StoredProcedure.SurecTipleriListesi, null);
    }
}
