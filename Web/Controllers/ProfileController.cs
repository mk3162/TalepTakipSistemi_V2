using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;

namespace Web.Controllers
{
    public class ProfileController : Controller
    {

        private readonly DatabaseContext _context;

        public ProfileController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Personeller.Where(x => x.ServisSiraNo==2).ToList());
        }
    }
}
