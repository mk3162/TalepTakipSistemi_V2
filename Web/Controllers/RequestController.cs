using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;

namespace Web.Controllers
{
    public class RequestController : Controller
    {
        private readonly DatabaseContext _context;
            
        public RequestController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetCompany()
        {
            var entity = _context.Sirketler.ToList();
            return Json(entity);
        }

        public ActionResult GetDepartments(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Departmanlar.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetLocations(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Lokasyonlar.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetProjects(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Projeler.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetExpenseCenters(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.MasrafMerkezleri.Where(a => a.SirketSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetServices(int SiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Servisler.Where(a => a.DepartmanSiraNo == SiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetTypes()
        {
            var entity = _context.Tipler.ToList();
            return Json(entity);
        }

        public ActionResult GetProducts()
        {
            var entity = _context.Urunler.ToList();
            return Json(entity);
        }
        public ActionResult GetUnits()
        {
            var entity = _context.Birimler.ToList();
            return Json(entity);
        }
        public ActionResult GetSuppliers()
        {
            var entity = _context.Tedarikciler.ToList();
            return Json(entity);
        }

        public ActionResult GetCurrencies()
        {
            var entity = _context.ParaBirimleri.ToList();
            return Json(entity);
        }
    }
}
