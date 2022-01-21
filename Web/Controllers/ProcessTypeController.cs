using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;

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
            return View(_context.IslemTipleri.ToList());
        }
    }
}
