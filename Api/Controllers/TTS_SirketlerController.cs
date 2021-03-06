using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_SirketlerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_SirketlerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetSirketlerListesi")]
        public BaseResponseApi<ResponseSirketlerListesiDto> GetSirketlerListesi() => _dbService.ExecuteSqlQuery<ResponseSirketlerListesiDto>(GlobalEnum.StoredProcedure.SirketlerListesi, null);
    }
}
