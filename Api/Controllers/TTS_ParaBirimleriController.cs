using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_ParaBirimleriController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_ParaBirimleriController(IDBService dBService)
        {
            _dbService = dBService;
        }
        [HttpGet]
        [Route("GetParaBirimleriListesi")]
        public BaseResponseApi<ResponseParaBirimleriListesiDto> GetParaBirimleriListesi() => _dbService.ExecuteSqlQuery<ResponseParaBirimleriListesiDto>(GlobalEnum.StoredProcedure.ParaBirimleriListesi, null);
    }
}
