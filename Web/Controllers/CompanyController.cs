using Common.Models;
using Common.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public CompanyController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //return View(_context.Sirketler.FromSqlRaw(GlobalEnum.StoredProcedure.SirketlerListesi.ToString()).ToList());
            return View(_apiService.GetSirketlerListesi<ResponseSirketlerListesiDto>(_serviceUrlList.GetSirketlerListesi).Data);
        }

        [HttpGet]
        public IActionResult GetCompanyList()
        {
            return Json(_apiService.GetSirketlerListesi<ResponseSirketlerListesiDto>(_serviceUrlList.GetSirketlerListesi).Data);
        }

    }
}
