using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TaleplerIslemGrupController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerIslemGrupController(IDBService dBService)
        {
            _dbService = dBService;
        }


        [HttpPost]
        [Route("GetTaleplerIslemListesiGrup")]
        public BaseResponseApi<ResponseTaleplerIslemListesiGrupDto> GetTaleplerIslemListesiGrup(RequestTaleplerIslemListesiGrupDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerIslemListesiGrupDto>(GlobalEnum.StoredProcedure.TaleplerIslemListesiGrup, model);
    }
}
