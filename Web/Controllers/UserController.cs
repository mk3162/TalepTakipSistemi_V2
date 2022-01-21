using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;

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
    }
}
