using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TaleplerKarsilamaKaydetController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerKarsilamaKaydetController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("PostTaleplerKarsilamaKaydet")]
        public BaseResponseApi<ResponseTaleplerKarsilamaKaydetDto> PostTaleplerKarsilamaKaydet([FromBody] RequestTaleplerKarsilamaKaydetDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerKarsilamaKaydetDto>(GlobalEnum.StoredProcedure.TaleplerKarsilamaKaydet, model);
    }
}
