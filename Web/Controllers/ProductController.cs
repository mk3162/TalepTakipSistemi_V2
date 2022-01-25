﻿using Common.Models;
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
    public class ProductController : Controller
    {
        private readonly DatabaseContext _context;
        public ProductController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Urunler.FromSqlRaw(GlobalEnum.StoredProcedure.UrunlerListesi.ToString()).ToList());
        }

        [HttpGet]
        public IActionResult GetProduct(int SiraNo)
        {
            var product = _context.Urunler.Find(SiraNo);
            return View("GetProduct", product);
        }

        [HttpPost]
        public IActionResult AddProduct(Urun urun)
        {
            try
            {
                _context.Urunler.Add(urun);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProduct(Urun urun)
        {
            _context.Urunler.Update(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult SoftDelete(int siraNo)
        //{
        //    var deletedProduct = _context.Urunler.FirstOrDefault(x => x.UrunId == siraNo);
        //    _context.Urunler.Remove(deletedProduct);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
