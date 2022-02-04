using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class TTS_TaleplerIslemController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_TaleplerIslemController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetTaleplerIslemListesi")]
        public BaseResponseApi<ResponseTaleplerIslemListesiDto> GetTaleplerSurecListesi(RequestTaleplerIslemListesiDto model) => _dbService.ExecuteSqlQuery<ResponseTaleplerIslemListesiDto>(GlobalEnum.StoredProcedure.TaleplerIslemListesi, model);
    }
}
