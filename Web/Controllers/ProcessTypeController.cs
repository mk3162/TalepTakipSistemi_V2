using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;

namespace Web.Controllers
{
    public class ProcessTypeController : Controller
    {
        private readonly DatabaseContext _context;

        public ProcessTypeController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Islemler.ToList());
        }

        [HttpGet]
        public IActionResult GetProcessType(int SiraNo)
        {
            var processType = _context.Islemler.Find(SiraNo);
            return View("GetProcessType", processType);
        }

        [HttpPost]
        public IActionResult AddProcessType(Islem ıslem)
        {
            try
            {
                _context.Islemler.Add(ıslem);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProcessType(Islem islem)
        {
            _context.Islemler.Update(islem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedProcess = _context.Islemler.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Islemler.Remove(deletedProcess);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
