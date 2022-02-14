using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TalepSahibiController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TalepSahibiController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetTalepSahibiListesi")]
        public BaseResponseApi<ResponseTalepSahibiListesiDto> GetTalepSahibiListesi() => _dbService.ExecuteSqlQuery<ResponseTalepSahibiListesiDto>(GlobalEnum.StoredProcedure.TalepSahibiListesi, null);
    }
}
