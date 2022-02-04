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
            return View(_context.Birimler.FromSqlRaw(GlobalEnum.StoredProcedure.BirimlerListesi.ToString()).ToList());
            //return Json(_apiService.GetBirimlerListesi<ResponseBirimlerListesiDto>(_serviceUrlList.GetBirimlerListesi));
        }

        [HttpGet]
        public IActionResult GetUnit(int SiraNo)
        {
            var unit = _context.Birimler.Find(SiraNo);
            return View("GetUnit", unit);
        }

        [HttpPost]
        public IActionResult AddUnit(Birim birim)
        {
            try
            {
                _context.Birimler.Add(birim);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateUnit(Birim birim)
        {
            _context.Birimler.Update(birim);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedUnit = _context.Birimler.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Birimler.Remove(deletedUnit);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
