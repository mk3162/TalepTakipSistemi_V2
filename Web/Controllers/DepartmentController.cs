using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;



namespace Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DatabaseContext _context;
        public DepartmentController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var param = new SqlParameter("@SirketSiraNo",1);


            return View(_context.Departmanlar.FromSqlRaw("DepartmanlarListesi @SirketSiraNo ", param).ToList());
        }
    }
}
