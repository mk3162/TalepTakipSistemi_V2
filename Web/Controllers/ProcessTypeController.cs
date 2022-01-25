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
            return View(_context.IslemTipleri.FromSqlRaw(GlobalEnum.StoredProcedure.IslemTipleriListesi.ToString()).ToList());
        }

        [HttpGet]
        public IActionResult GetProcessType(int SiraNo)
        {
            var processType = _context.IslemTipleri.Find(SiraNo);
            return View("GetProcessType", processType);
        }

        [HttpPost]
        public IActionResult AddProcessType(IslemTip ıslem)
        {
            try
            {
                _context.IslemTipleri.Add(ıslem);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProcessType(IslemTip islem)
        {
            _context.IslemTipleri.Update(islem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedProcess = _context.IslemTipleri.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.IslemTipleri.Remove(deletedProcess);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
