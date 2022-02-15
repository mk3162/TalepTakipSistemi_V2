using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public HomeController(ILogger<HomeController> logger,IApiService apiService,ServiceUrlList serviceUrlList)
        {
            _serviceUrlList = serviceUrlList;
            _apiService = apiService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var req = new RequestDepartmanlarListesiDto();
            req.SirketSiraNo = 1;
            var resp = _apiService.GetDepartmanlarListesi<ResponseDepartmanlarListesiDto, RequestDepartmanlarListesiDto>(_serviceUrlList.GetDepartmanlarListesi, req);
            return View(resp);
        }
    }
}
