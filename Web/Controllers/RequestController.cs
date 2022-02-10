using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Service.Interface;

namespace Web.Controllers
{
    public class RequestController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;

        public RequestController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCompany()
        {
            //return Json(_context.Sirketler.ToList());
            return Json(_apiService.GetSirketlerListesi<ResponseSirketlerListesiDto>(_serviceUrlList.GetSirketlerListesi).Data);
        }

        public IActionResult GetDepartments(int SiraNo = 1)
        {
            //return Json(_context.Departmanlar.Where(a => a.SirketSiraNo == SiraNo).ToList());
            var req = new RequestDepartmanlarListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetDepartmanlarListesi<ResponseDepartmanlarListesiDto, RequestDepartmanlarListesiDto>(_serviceUrlList.GetDepartmanlarListesi, req).Data);
        }

        public IActionResult GetLocations(int SiraNo = 1)
        {
            //return Json(_context.Lokasyonlar.Where(a => a.SirketSiraNo == SiraNo).ToList());
            var req = new RequestLokasyonlarListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetLokasyonlarListesi<ResponseLokasyonlarListesiDto, RequestLokasyonlarListesiDto>(_serviceUrlList.GetLokasyonlarListesi, req).Data);

        }

        public IActionResult GetProjects(int SiraNo = 1)
        {
            //return Json(_context.Projeler.Where(a => a.SirketSiraNo == SiraNo).ToList());
            var req = new RequestProjelerListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetProjelerListesi<ResponseProjelerListesiDto, RequestProjelerListesiDto>(_serviceUrlList.GetProjelerListesi, req).Data);
        }

        public IActionResult GetExpenseCenters(int SiraNo = 1)
        {
            //return Json(_context.MasrafMerkezleri.Where(a => a.SirketSiraNo == SiraNo).ToList());
            var req = new RequestMasrafMerkezleriListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetMasrafMerkezleriListesi<ResponseMasrafMerkezleriListesiDto, RequestMasrafMerkezleriListesiDto>(_serviceUrlList.GetMasrafMerkezleriListesi, req).Data);
        }

        public IActionResult GetServices(int SiraNo)
        {
            //TODO : Get data from service
            return Json(_context.Servisler.Where(a => a.DepartmanSiraNo == SiraNo).ToList());
        }

        public IActionResult GetTypes()
        {
            //return Json(_context.Tipler.ToList());
            return Json(_apiService.GetTiplerListesi<ResponseTiplerListesiDto>(_serviceUrlList.GetTiplerListesi).Data);
        }

        public IActionResult GetProducts()
        {
            //return Json(_context.Urunler.ToList());
            return Json(_apiService.GetUrunlerListesi<ResponseUrunlerListesiDto>(_serviceUrlList.GetUrunlerListesi).Data);
        }
        public IActionResult GetUnits()
        {
            //return Json(_context.Birimler.ToList());
            return Json(_apiService.GetBirimlerListesi<ResponseBirimlerListesiDto>(_serviceUrlList.GetBirimlerListesi).Data);
        }
        public IActionResult GetSuppliers()
        {
            //return Json(_context.Tedarikciler.ToList());
            return Json(_apiService.GetTedarikcilerListesi<ResponseTedarikcilerListesiDto>(_serviceUrlList.GetTedarikcilerListesi).Data);
        }

        public IActionResult GetCurrencies()
        {
            //return Json(_context.ParaBirimleri.ToList());
            return Json(_apiService.GetParaBirimleriListesi<ResponseParaBirimleriListesiDto>(_serviceUrlList.GetParaBirimleriListesi).Data);
        }

        public IActionResult GetRequestOwners()
        {
            //return Json(_context.Personeller.ToList());
            return Json(_apiService.GetTalepSahibiListesi<ResponseTalepSahibiListesiDto>(_serviceUrlList.GetTalepSahibiListesi).Data);
        }

        //public IActionResult GetRequestProcessList()
        //{
        //    //TODO
        //    var req = new RequestTaleplerIslemListesiDto();
        //    req.KullaniciKodu = 11111111111.ToString();
        //    req.Yetki = 0;

        //    var resp = _apiService.GetTaleplerIslemListesi<ResponseTaleplerIslemListesiDto, RequestTaleplerIslemListesiDto>(_serviceUrlList.GetTaleplerIslemListesi, req);
        //    return Json(resp);
        //}

        public IActionResult GetRequestPeriodList()
        {
            var req = new RequestTaleplerSurecListesiDto();
            req.TalepSiraNo = 8;

            var resp = _apiService.GetTaleplerSurecListesi<ResponseTaleplerSurecListesiDto, RequestTaleplerSurecListesiDto>(_serviceUrlList.GetTaleplerSurecListesi, req);
            return Json(resp);
        }

        [HttpPost]
        public IActionResult AddRequest()
        {
            var req = new RequestTaleplerKaydetDto();
            return Json(_apiService.PostTaleplerKaydet<ResponseTaleplerKaydetDto,RequestTaleplerKaydetDto>(_serviceUrlList.PostTaleplerKaydet, req).Data);
        }
    }
}
