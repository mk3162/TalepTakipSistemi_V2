using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_MasrafMerkezleriController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_MasrafMerkezleriController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetMasrafMerkezleriListesi")]
        public BaseResponseApi<ResponseMasrafMerkezleriListesiDto> GetMasrafMerkezleriListesi(RequestMasrafMerkezleriListesiDto model) => _dbService.ExecuteSqlQuery<ResponseMasrafMerkezleriListesiDto>(GlobalEnum.StoredProcedure.MasrafMerkezleriListesi, model);
    }
}
