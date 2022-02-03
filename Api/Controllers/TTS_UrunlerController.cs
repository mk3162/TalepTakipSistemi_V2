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
    public class TTS_UrunlerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_UrunlerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetUrunlerListesi")]
        public BaseResponseApi<ResponseUrunlerListesiDto> GetUrunlerListesi() => _dbService.ExecuteSqlQuery<ResponseUrunlerListesiDto>(GlobalEnum.StoredProcedure.UrunlerListesi, null);
    }
}
