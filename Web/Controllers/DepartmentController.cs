using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.ViewModels;
using Web.Service.Interface;
using Common.Models.Response;
using Web.Models;

namespace Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;
        public DepartmentController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;

        }

        public IActionResult Index()
        {
            var req = new RequestDepartmanlarListesiDto();
            req.SirketSiraNo = 1;
            var resp = _apiService.GetDepartmanlarListesi<ResponseDepartmanlarListesiDto, RequestDepartmanlarListesiDto>(_serviceUrlList.GetDepartmanlarListesi, req).Data;
            return View(resp);
        }
    }
}