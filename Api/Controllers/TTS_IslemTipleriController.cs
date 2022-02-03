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
    public class TTS_IslemTipleriController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_IslemTipleriController(IDBService dBService)
        {
            _dbService = dBService;
        }
        [HttpGet]
        [Route("GetIslemTipleriListesi")]
        public BaseResponseApi<ResponseIslemTipleriDto> GetIslemTipleriListesi() => _dbService.ExecuteSqlQuery<ResponseIslemTipleriDto>(GlobalEnum.StoredProcedure.IslemTipleriListesi, null);
    }
}
