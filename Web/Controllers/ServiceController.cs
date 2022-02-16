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
            var req = new RequestServislerListesiDto();
            req.DepartmanSiraNo = 1;

            var resp = _apiService.GetServislerListesi<ResponseServislerListesiDto, RequestServislerListesiDto>(_serviceUrlList.GetServislerListesi, req).Data;
            return View(resp);
        }

        public IActionResult GetDepartments()
        {
            var req2 = new RequestDepartmanlarListesiDto();
            req2.SirketSiraNo = 1;

            var resp2 = _apiService.GetDepartmanlarListesi<ResponseDepartmanlarListesiDto, RequestDepartmanlarListesiDto>(_serviceUrlList.GetDepartmanlarListesi, req2).Data;
            return Json(resp2);
        }
    }
}
