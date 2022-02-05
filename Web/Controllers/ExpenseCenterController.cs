using Common.Models;
using Common.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class ExpenseCenterController : Controller
    {
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public ExpenseCenterController(IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }
        public IActionResult Index()
        {
            var req = new RequestMasrafMerkezleriListesiDto();
            req.SirketSiraNo = 1;
            var resp = _apiService.GetMasrafMerkezleriListesi<ResponseMasrafMerkezleriListesiDto, RequestMasrafMerkezleriListesiDto>(_serviceUrlList.GetMasrafMerkezleriListesi, req).Data;
            return View(resp);
        }
    }
}
