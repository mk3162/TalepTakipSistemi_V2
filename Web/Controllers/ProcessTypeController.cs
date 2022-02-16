using Common.Models;
using Common.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class ProcessTypeController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public ProcessTypeController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //return View(_context.IslemTipleri.FromSqlRaw(GlobalEnum.StoredProcedure.IslemTipleriListesi.ToString()).ToList());
            return View(_apiService.GetIslemTipleriListesi<ResponseIslemTipleriDto>(_serviceUrlList.GetIslemTipleriListesi).Data);
        }
    }
}
