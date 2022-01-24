using Microsoft.AspNetCore.Mvc;
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
            return View(_context.Users.ToList());
        }

        [HttpGet]
        public IActionResult GetUser(int SiraNo)
        {
            var user = _context.Users.Find(SiraNo);
            return View("GetUser", user);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedUser = _context.Users.FirstOrDefault(x => x.UserId == siraNo);
            _context.Users.Remove(deletedUser);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
