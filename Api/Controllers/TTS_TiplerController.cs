using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TiplerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TiplerController(IDBService dBService)
        {
            _dbService = dBService;
        }
        [HttpGet]
        [Route("GetTiplerListesi")]
        public BaseResponseApi<ResponseTiplerListesiDto> GetTiplerListesi() => _dbService.ExecuteSqlQuery<ResponseTiplerListesiDto>(GlobalEnum.StoredProcedure.TiplerListesi, null);
    }
}
