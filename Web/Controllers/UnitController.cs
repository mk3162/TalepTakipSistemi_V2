using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;

namespace Web.Controllers
{
    public class UnitController : Controller
    {
        private readonly DatabaseContext _context;

        public UnitController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Units.ToList());
        }

        [HttpGet]
        public IActionResult GetUnit(int SiraNo)
        {
            var unit = _context.Units.Find(SiraNo);
            return View("GetUnit", unit);
        }

        [HttpPost]
        public IActionResult AddUnit(Birim birim)
        {
            try
            {
                _context.Units.Add(birim);
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
            _context.Units.Update(birim);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedUnit = _context.Units.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Units.Remove(deletedUnit);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
