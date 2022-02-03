﻿using Common.Models;
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
    public class TTS_DepartmanlarController : Controller
    {
        private readonly IDBService _dbService;
        public TTS_DepartmanlarController(IDBService dBService)
        {
            _dbService = dBService;
        }

        [HttpPost]
        [Route("GetDepartmanlarListesi")]
        public BaseResponseApi<ResponseDepartmanlarListesiDto> GetDepartmanlarListesi(RequestDepartmanlarListesiDto model) => _dbService.ExecuteSqlQuery<ResponseDepartmanlarListesiDto>(GlobalEnum.StoredProcedure.DepartmanlarListesi, model);

    }
}
