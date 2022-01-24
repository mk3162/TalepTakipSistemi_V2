using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;

namespace Web.Controllers
{
    public class SupplierController : Controller
    {
        private readonly DatabaseContext _context;
        public SupplierController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Supplierss.ToList().OrderBy(x => x.TedarikciId));
        }

        [HttpGet]
        public IActionResult GetSupplier(int SiraNo)
        {
            var supplier = _context.Supplierss.Find(SiraNo);
            return View("GetSupplier", supplier);
        }

        [HttpPost]
        public IActionResult AddSupplier(Tedarikci tedarikci)
        {
            try
            {
                _context.Supplierss.Add(tedarikci);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateSupplier(Tedarikci tedarikci)
        {
            _context.Supplierss.Update(tedarikci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedSupplier = _context.Supplierss.FirstOrDefault(x => x.TedarikciId == siraNo);
            _context.Supplierss.Remove(deletedSupplier);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
