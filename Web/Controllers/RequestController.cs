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
        public ActionResult GetCompany()
        {
            var entity = _context.Sirketler.Where(a => a.SiraNo > 0).ToList();
            return Json(entity);
        }

        public ActionResult GetService(int depSiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Servisler.Where(a => a.SiraNo == depSiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetDepartment(int sirketSiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Departmanlar.Where(a => a.SiraNo == sirketSiraNo).ToList();
            return Json(entity);
        }

        public ActionResult GetLocation(int sirketSiraNo)
        {
            //_context.Configuration.ProxyCreationEnabled = false;
            var entity = _context.Lokasyonlar.Where(a => a.SiraNo == sirketSiraNo).ToList();
            return Json(entity);
        }
    }
}
