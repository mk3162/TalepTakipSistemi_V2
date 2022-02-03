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
    public class TTS_KullanicilarController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_KullanicilarController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetKullanicilarListesi")]
        public BaseResponseApi<ResponseKullanicilarListesi> GetKullanicilarListesi() => _dbService.ExecuteSqlQuery<ResponseKullanicilarListesi>(GlobalEnum.StoredProcedure.KullanicilarListesi, null);
    }
}
