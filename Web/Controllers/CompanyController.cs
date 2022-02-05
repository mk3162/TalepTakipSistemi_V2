using Common.Models;
using Common.Models.Response;
using Intercom.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public CompanyController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //return View(_context.Sirketler.FromSqlRaw(GlobalEnum.StoredProcedure.SirketlerListesi.ToString()).ToList());
            return View(_apiService.GetSirketlerListesi<ResponseSirketlerListesiDto>(_serviceUrlList.GetSirketlerListesi).Data);
        }

        [HttpGet]
        public IActionResult GetCompany(int SiraNo)
        {
            var company = _context.Sirketler.Find(SiraNo);
            return View("GetCompany", company);
        }

        [HttpPost]
        public IActionResult AddCompany(Sirket sirket)
        {
            try
            {
                _context.Sirketler.Add(sirket);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateCompany(Sirket sirket)
        {
            _context.Sirketler.Update(sirket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SoftDelete(int siraNo)
        {
            var deletedCompany = _context.Sirketler.FirstOrDefault(x => x.SiraNo == siraNo);
            _context.Sirketler.Remove(deletedCompany);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
