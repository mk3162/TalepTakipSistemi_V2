using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_PersonellerController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_PersonellerController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetPersonellerListesi")]
        public BaseResponseApi<ResponsePersonellerListesiDto> GetPersonellerListesi(RequestPersonellerListesiDto model) => _dbService.ExecuteSqlQuery<ResponsePersonellerListesiDto>(GlobalEnum.StoredProcedure.PersonellerListesi, model);
    }
}
