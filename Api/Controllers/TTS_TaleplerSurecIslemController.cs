using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TaleplerSurecIslemController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerSurecIslemController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetTaleplerSurecIslem")]
        public BaseResponseApi<ResponseTaleplerSurecIslemDto> GetTaleplerSurecIslem(RequestTaleplerSurecIslemDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerSurecIslemDto>(GlobalEnum.StoredProcedure.TaleplerSurecIslem, model);
    }
}