using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TaleplerEkDosyaController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerEkDosyaController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetTaleplerEkDosyaListesi")]
        public BaseResponseApi<ResponseTaleplerEkDosyaListesiDto> GetTaleplerEkDosyaListesi(RequestTaleplerEkDosyaListesiDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerEkDosyaListesiDto>(GlobalEnum.StoredProcedure.TaleplerEkDosyaListesi, model);




        [HttpPost]
        [Route("PostTaleplerEkDosyaKaydet")]
        public BaseResponseApi<ResponseTaleplerEkDosyaKaydetDto> PostTaleplerEkDosyaKaydet([FromBody] RequestTaleplerEkDosyaKaydetDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerEkDosyaKaydetDto>(GlobalEnum.StoredProcedure.TaleplerEkDosyaKaydet, model);


        [HttpDelete]
        [Route("DeleteTaleplerEkDosyaSil")]
        public BaseResponseApi<ResponseTaleplerEkDosyaSilDto> DeleteTaleplerEkDosyaSil([FromBody] RequestTaleplerEkDosyaSilDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerEkDosyaSilDto>(GlobalEnum.StoredProcedure.TaleplerEkDosyaSil, model);
    }
}
