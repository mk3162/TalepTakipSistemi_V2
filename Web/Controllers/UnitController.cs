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
    public class UnitController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public UnitController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }
        public IActionResult Index()
        {
            return View(_apiService.GetBirimlerListesi<ResponseBirimlerListesiDto>(_serviceUrlList.GetBirimlerListesi).Data);
        }
    }
}
