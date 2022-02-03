using Common.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class RequestController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public RequestController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCompany()
        {
            var entity = _context.Sirketler.ToList();
            return Json(entity);
        }

        public IActionResult GetDepartments(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Departmanlar.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public IActionResult GetLocations(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Lokasyonlar.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public IActionResult GetProjects(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Projeler.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public IActionResult GetExpenseCenters(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.MasrafMerkezleri.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public IActionResult GetServices(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Servisler.Where(a => a.DepartmanSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public IActionResult GetTypes()
        {
            var entity = _context.Tipler.ToList();
            return Json(entity);
        }

        public IActionResult GetProducts()
        {
            var entity = _context.Urunler.ToList();
            return Json(entity);
        }
        public IActionResult GetUnits()
        {
            var entity = _context.Birimler.ToList();
            return Json(entity);
        }
        public IActionResult GetSuppliers()
        {
            var entity = _context.Tedarikciler.ToList();
            return Json(entity);
        }

        public IActionResult GetCurrencies()
        {
            var entity = _context.ParaBirimleri.ToList();
            return Json(entity);
        }

        public IActionResult GetRequestOwners()
        {
            var entity = _context.Personeller.ToList();
            return Json(entity);
        }

        public IActionResult GetRequestProcessList()
        {
            //var req = new();
            //req.SirketSiraNo = 1;
            //var resp = _apiService.GetRequestList<ResponseSirketlerListesiDto, Re>(_serviceUrlList.GetSirketlerListesi);
            return View();
        }
    }
}
