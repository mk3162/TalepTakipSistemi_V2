using Common.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Session;
using Web.ViewModels;

namespace Web.Controllers
{
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
        public async Task<IActionResult> Index([Bind]KullaniciViewModel user)
        {
            if ((!string.IsNullOrEmpty(user.Kodu)) && (!string.IsNullOrEmpty(user.Sifre)))
            {
                var log = _context.Kullanicilar.FirstOrDefault(x => x.Kodu == user.Kodu && x.Sifre == user.Sifre);
                if (log != null)
                {       
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Kodu),
                    new Claim(ClaimTypes.Role, "User"),
                };
                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.Now.AddMinutes(1),
                    };

                    await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                    ViewBag.Login = "Giriş Başarılı Yönlendiriliyorsunuz...";
                    return RedirectToAction("Index", "Request");

                }
                else
                {
                    ViewBag.LoginError = "Hatalı Bilgi Girişi Yaptınız,Tekrar Deneyiniz...";
                    return View("Index");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                 CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Login");
        }
    }
}
