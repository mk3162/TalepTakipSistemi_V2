using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;

namespace Web.Controllers
{
    public class PeriodTypeController : Controller
    {
        private readonly DatabaseContext _context;
        public PeriodTypeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.SurecTipler.FromSqlRaw(GlobalEnum.StoredProcedure.SurecTipleriListesi.ToString()).ToList());
        }
    }
}
