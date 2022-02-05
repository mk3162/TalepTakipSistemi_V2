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
    public class TypeController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;
        public TypeController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }
        public IActionResult Index()
        {
            //return View(_context.Tipler.FromSqlRaw(GlobalEnum.StoredProcedure.TiplerListesi.ToString()).ToList());
            return View(_apiService.GetTiplerListesi<ResponseTiplerListesiDto>(_serviceUrlList.GetTiplerListesi).Data);
        }

        [HttpGet]
        public IActionResult GetType(int SiraNo)
        {
            var type = _context.Tipler.Find(SiraNo);
            return View("GetType", type);
        }

        [HttpPost]
        public IActionResult AddType(Tip tip)
        {
            try
            {
                _context.Tipler.Add(tip);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateType(Tip tip)
        {
            _context.Tipler.Update(tip);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedType = _context.Tipler.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Tipler.Remove(deletedType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
