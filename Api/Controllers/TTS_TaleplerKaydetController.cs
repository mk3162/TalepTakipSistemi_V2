using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TaleplerKaydetController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerKaydetController(IDBService dBService)
        {
            _dbService = dBService;
        }


        [HttpPost]
        [Route("PostTaleplerKaydet")]
        public BaseResponseApi<ResponseTaleplerKaydetDto> PostTaleplerKaydet([FromBody] RequestTaleplerKaydetDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerKaydetDto>(GlobalEnum.StoredProcedure.TaleplerKaydet, model);
    }
}
