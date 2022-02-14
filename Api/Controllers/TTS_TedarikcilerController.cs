using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TedarikcilerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TedarikcilerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpGet]
        [Route("GetTedarikcilerListesi")]
        public BaseResponseApi<ResponseTedarikcilerListesiDto> GetTedarikcilerListesi() => _dbService.ExecuteSqlQuery<ResponseTedarikcilerListesiDto>(GlobalEnum.StoredProcedure.TedarikcilerListesi, null);
    }
}
