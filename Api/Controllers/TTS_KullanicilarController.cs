using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

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
        public BaseResponseApi<ResponseKullanicilarListesiDto> GetKullanicilarListesi() => _dbService.ExecuteSqlQuery<ResponseKullanicilarListesiDto>(GlobalEnum.StoredProcedure.KullanicilarListesi, null);
    }
}
