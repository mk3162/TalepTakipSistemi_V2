using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            return View(_context.Companies.ToList());
        }

        [HttpGet]
        public IActionResult GetCompany(int SiraNo)
        {
            var company = _context.Companies.Find(SiraNo);
            return View("GetCompany", company);
        }

        [HttpPost]
        public IActionResult AddCompany(Sirket sirket)
        {
            try
            {
                _context.Companies.Add(sirket);
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
            _context.Companies.Update(sirket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedCompany = _context.Companies.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Companies.Remove(deletedCompany);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
