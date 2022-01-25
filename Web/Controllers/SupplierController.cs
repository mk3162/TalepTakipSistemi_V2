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
    public class SupplierController : Controller
    {
        private readonly DatabaseContext _context;
        public SupplierController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Tedarikciler.FromSqlRaw(GlobalEnum.StoredProcedure.TedarikcilerListesi.ToString()).ToList());
        }

        [HttpGet]
        public IActionResult GetSupplier(int SiraNo)
        {
            var supplier = _context.Tedarikciler.Find(SiraNo);
            return View("GetSupplier", supplier);
        }

        [HttpPost]
        public IActionResult AddSupplier(Tedarikci tedarikci)
        {
            try
            {
                _context.Tedarikciler.Add(tedarikci);
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
            _context.Tedarikciler.Update(tedarikci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult SoftDelete(int siraNo)
        //{
        //    var deletedSupplier = _context.Tedarikciler.FirstOrDefault(x => x.TedarikciId == siraNo);
        //    _context.Tedarikciler.Remove(deletedSupplier);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
