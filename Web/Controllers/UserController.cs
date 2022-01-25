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
    public class UserController : Controller
    {
        private readonly DatabaseContext _context;
        public UserController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Kullanicilar.FromSqlRaw(GlobalEnum.StoredProcedure.KullanicilarListesi.ToString()).ToList());
        }

        [HttpGet]
        public IActionResult GetUser(int SiraNo)
        {
            var user = _context.Kullanicilar.Find(SiraNo);
            return View("GetUser", user);
        }

        [HttpPost]
        public IActionResult AddUser(Kullanici kullanici)
        {
            try
            {
                _context.Kullanicilar.Add(kullanici);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateUser(Kullanici kullanici)
        {
            _context.Kullanicilar.Update(kullanici);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult SoftDelete(int siraNo)
        //{
        //    var deletedUser = _context.Kullanicilar.FirstOrDefault(x => x.UserId == siraNo);
        //    _context.Kullanicilar.Remove(deletedUser);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
