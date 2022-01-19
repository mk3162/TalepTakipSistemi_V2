using Common.Models;
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
            //var req = new RequestDepartmanlarListesiDto();
            //req.SirketSiraNo = 1;
            //var resp = _apiService.GetSirketlerListesi<ResponseSirketlerListesiDto>(_serviceUrlList.GetSirketlerListesi);
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
