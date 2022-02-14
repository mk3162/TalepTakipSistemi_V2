using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_ProjelerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_ProjelerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetProjelerListesi")]
        public BaseResponseApi<ResponseProjelerListesiDto> GetProjelerListesi(RequestProjelerListesiDto model) => _dbService.ExecuteSqlQuery<ResponseProjelerListesiDto>(GlobalEnum.StoredProcedure.ProjelerListesi, model);
    }
}
