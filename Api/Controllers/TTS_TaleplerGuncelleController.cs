using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class TTS_TaleplerGuncelleController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerGuncelleController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPut]
        [Route("PutTaleplerGuncelle")]
        public BaseResponseApi<ResponseTaleplerGuncelleDto> PutTaleplerGuncelle([FromBody] RequestTaleplerGuncelleDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerGuncelleDto>(GlobalEnum.StoredProcedure.TaleplerGuncelle, model);
    }
}
