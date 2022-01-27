using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Web.Context;

namespace Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DatabaseContext _context;

        public DashboardController(DatabaseContext context)
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
            var entity = _context.Servisler.Where(a => a.DepartmanSiraNo == depSiraNo).ToList();
            return Json(entity);
        }
    }
}
