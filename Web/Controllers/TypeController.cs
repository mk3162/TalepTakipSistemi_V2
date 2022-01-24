﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;

namespace Web.Controllers
{
    public class TypeController : Controller
    {
        private readonly DatabaseContext _context;
        public TypeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Tip.ToList());
        }

        [HttpGet]
        public IActionResult GetType(int SiraNo)
        {
            var type = _context.Tip.Find(SiraNo);
            return View("GetType", type);
        }

        [HttpPost]
        public IActionResult AddType(Tip tip)
        {
            try
            {
                _context.Tip.Add(tip);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateType(Tip tip)
        {
            _context.Tip.Update(tip);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedType = _context.Tip.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Tip.Remove(deletedType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
