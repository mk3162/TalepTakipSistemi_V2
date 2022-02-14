using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_ServislerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_ServislerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetServislerListesi")]
        public BaseResponseApi<ResponseServislerListesiDto> GetServislerListesi(RequestServislerListesiDto model) => _dbService.ExecuteSqlQuery<ResponseServislerListesiDto>(GlobalEnum.StoredProcedure.ServislerListesi, model);
    }
}
