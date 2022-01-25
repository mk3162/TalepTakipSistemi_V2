using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View(_context.Birimler.FromSqlRaw(GlobalEnum.StoredProcedure.BirimlerListesi.ToString()).ToList());
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
