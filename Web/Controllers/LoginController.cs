using Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Session;

namespace Web.Controllers
{
    //[AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;

        public LoginController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici kullanici)
        {
            var log = _context.Kullanicilar.FirstOrDefault(x => x.Kodu == kullanici.Kodu && x.Sifre == kullanici.Sifre);

            if (log != null)
            {
                SessionUserModel.CurrentUser = new SessionUserModel
                {
                    Kodu = log.Kodu,
                    Sifre = log.Sifre,
                    AdiSoyadi = log.AdiSoyadi,
                    Yetki = log.Yetki
                };
                ViewBag.Login = "Giriş Başarılı Yönlendiriliyorsunuz..";
                //Todo -- set cookie --(For remember me)
                //FormsAuthentication.SetAuthCookie(log.Sifre, false);

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.LoginError = "Hatalı Bilgi Girişi Yaptınız,Tekrar Deneyiniz..";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Login");
        }
    }
}
