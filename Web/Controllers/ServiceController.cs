using Common.Models;
using Common.Models.Response;
using Common.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;
        public ServiceController(IApiService apiService, ServiceUrlList serviceUrlList, DatabaseContext context)
        {
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
            _context = context;
        }
        public IActionResult Index()
        {
            var req = new RequestLokasyonlarListesiDto();
            req.SirketSiraNo = 1;

            var resp = _apiService.GetLokasyonlarListesi<ResponseLokasyonlarListesiDto, RequestLokasyonlarListesiDto>(_serviceUrlList.GetLokasyonlarListesi, req);
            return View(resp);
        }
    }
}
