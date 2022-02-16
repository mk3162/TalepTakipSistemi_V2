using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.ViewModels;
using WebMatrix.WebData;

namespace Web.Controllers
{
    public class ProfileController : Controller
    {

        private readonly DatabaseContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProfileController(DatabaseContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View(_context.Personeller.Where(x => x.AdiSoyadi == _httpContextAccessor.HttpContext.Session.GetString("AdiSoyadi")).ToList());
        }
    }
}
