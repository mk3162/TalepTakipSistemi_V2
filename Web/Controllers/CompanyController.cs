using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;

namespace Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly DatabaseContext _context;

        public CompanyController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Sirketler.ToList());
        }

        [HttpGet]
        public IActionResult GetCompany(int SiraNo)
        {
            var company = _context.Sirketler.FirstOrDefault(x => x.SiraNo == SiraNo);
            return View("GetCompany", company);
        }

        [HttpPost]
        public IActionResult AddCompany(Sirket sirket)
        {
            try
            {
                _context.Sirketler.Add(sirket);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateCompany(Sirket sirket)
        {
            _context.Sirketler.Update(sirket);
            //_context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SoftDelete(Sirket sirket)
        {
            _context.Sirketler.Remove(sirket);
            return RedirectToAction("Index");
        }
    }
}
