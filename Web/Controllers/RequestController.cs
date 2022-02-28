using Common.Models;
using Common.Models.Request;
using Common.Models.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Context;
using Web.Entities;
using Web.Models;
using Web.Service.Interface;
using Web.ViewModels;

namespace Web.Controllers
{
    public class RequestController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IApiService _apiService;
        private readonly ServiceUrlList _serviceUrlList;
        private readonly ILogger<RequestController> _logger;

        public RequestController(DatabaseContext context, IApiService apiService, ServiceUrlList serviceUrlList, ILogger<RequestController> logger)
        {
            _context = context;
            _apiService = apiService;
            _serviceUrlList = serviceUrlList;
            _logger = logger;
        }

        //[Authorize]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult GetDepartments(int SiraNo)
        {
            var req = new RequestDepartmanlarListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetDepartmanlarListesi<ResponseDepartmanlarListesiDto, RequestDepartmanlarListesiDto>(_serviceUrlList.GetDepartmanlarListesi, req).Data);
        }

        public IActionResult GetLocations(int SiraNo)
        {
            var req = new RequestLokasyonlarListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetLokasyonlarListesi<ResponseLokasyonlarListesiDto, RequestLokasyonlarListesiDto>(_serviceUrlList.GetLokasyonlarListesi, req).Data);
        }

        public IActionResult GetProjects(int SiraNo)
        {
            var req = new RequestProjelerListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetProjelerListesi<ResponseProjelerListesiDto, RequestProjelerListesiDto>(_serviceUrlList.GetProjelerListesi, req).Data);
        }

        public IActionResult GetExpenseCenters(int SiraNo)
        {
            var req = new RequestMasrafMerkezleriListesiDto();
            req.SirketSiraNo = SiraNo;
            return Json(_apiService.GetMasrafMerkezleriListesi<ResponseMasrafMerkezleriListesiDto, RequestMasrafMerkezleriListesiDto>(_serviceUrlList.GetMasrafMerkezleriListesi, req).Data);
        }

        public IActionResult GetServices(int SiraNo)
        {
            var req = new RequestServislerListesiDto();
            req.DepartmanSiraNo = SiraNo;
            return Json(_apiService.GetServislerListesi<ResponseServislerListesiDto, RequestServislerListesiDto>(_serviceUrlList.GetServislerListesi, req).Data);
        }

        public IActionResult GetTypes()
        {
            return Json(_apiService.GetTiplerListesi<ResponseTiplerListesiDto>(_serviceUrlList.GetTiplerListesi).Data);
        }

        public IActionResult GetProducts()
        {
            return Json(_apiService.GetUrunlerListesi<ResponseUrunlerListesiDto>(_serviceUrlList.GetUrunlerListesi).Data);
        }
        public IActionResult GetUnits()
        {
            return Json(_apiService.GetBirimlerListesi<ResponseBirimlerListesiDto>(_serviceUrlList.GetBirimlerListesi).Data);
        }
        public IActionResult GetSuppliers()
        {
            return Json(_apiService.GetTedarikcilerListesi<ResponseTedarikcilerListesiDto>(_serviceUrlList.GetTedarikcilerListesi).Data);
        }

        public IActionResult GetCurrencies()
        {
            return Json(_apiService.GetParaBirimleriListesi<ResponseParaBirimleriListesiDto>(_serviceUrlList.GetParaBirimleriListesi).Data);
        }

        public IActionResult GetRequestOwners()
        {
            return Json(_apiService.GetTalepSahibiListesi<ResponseTalepSahibiListesiDto>(_serviceUrlList.GetTalepSahibiListesi).Data);
        }

        public IActionResult GetRequestProcessList()
        {
            var name = User.Claims.Where(x => x.Type == ClaimTypes.Name)
        .Select(x => x.Value).SingleOrDefault();

            var req = new RequestTaleplerIslemListesiDto();
            req.KullaniciKodu = name;
            req.Yetki = 0;

            var resp = _apiService.GetTaleplerIslemListesi<ResponseTaleplerIslemListesiDto, RequestTaleplerIslemListesiDto>(_serviceUrlList.GetTaleplerIslemListesi, req).Data;
            return Json(resp);
        }

        [HttpGet]
        public IActionResult GetRequestProcessListGroup()
        {
            var req = new RequestTaleplerIslemListesiGrupDto();
            req.GrupSiraNo = 3;
            req.TalepSiraNo = 6;
            var resp = _apiService.GetTaleplerIslemListesiGrup<ResponseTaleplerIslemListesiGrupDto, RequestTaleplerIslemListesiGrupDto>(_serviceUrlList.GetTaleplerIslemListesiGrup, req).Data;
            return Json(resp);
        }

        public IActionResult GetRequestPeriodList(int siraNo)
        {
            var req = new RequestTaleplerSurecListesiDto();
            req.TalepSiraNo = siraNo;

            var resp = _apiService.GetTaleplerSurecListesi<ResponseTaleplerSurecListesiDto, RequestTaleplerSurecListesiDto>(_serviceUrlList.GetTaleplerSurecListesi, req).Data;
            return Json(resp);
        }

        //[HttpGet]
        //public IActionResult GetRequestPeriodProcess()
        //{
        //    var req = new RequestTaleplerSurecIslemDto();
        //    req.TalepSiraNo = 8;
        //    req.IslemSiraNo = 13;
        //    req.IslemSiraNo = 1;
        //    req.IslemYapanKodu = "99999999999";
        //    req.IslemTipi = 1;
        //    req.Aciklama = "DENEME BLA";
        //    req.SahibiKodu = "26776912606";
        //    req.IslemYapacakKodu = "55555555555";
        //    req.Sonuc = 0;

        //    var resp = _apiService.GetTaleplerSurecIslem<ResponseTaleplerSurecIslemDto, RequestTaleplerSurecIslemDto>(_serviceUrlList.GetTaleplerSurecIslem, req).Data;
        //    return Json(resp);
        //}

        [HttpPost]
        public IActionResult AddRequest(RequestTaleplerKaydetDto model)
        {
            return RedirectToAction("Index", "Request", Json(_apiService.PostTaleplerKaydet<ResponseTaleplerKaydetDto, RequestTaleplerKaydetDto>(_serviceUrlList.PostTaleplerKaydet, model).Data));
        }

        //[HttpPost]
        //public IActionResult AddRequestSupply(RequestTaleplerKarsilamaKaydetDto model)
        //{
        //    return RedirectToAction("GetRequestProcessList", "Request", Json(_apiService.PostTaleplerKarsilamaKaydet<ResponseTaleplerKarsilamaKaydetDto, RequestTaleplerKarsilamaKaydetDto>(_serviceUrlList.PostTaleplerKarsilamaKaydet, model).Data));
        //}

        [HttpPost]
        public IActionResult UpdateRequest(RequestTaleplerGuncelleDto model)
        {
            model.GuncellemeTipi = 2;
            model.HedefTeslimTarihi = DateTime.Now;
            model.TedarikciKodu = "NULL";

            return RedirectToAction("Index", "Request", Json(_apiService.PutTaleplerGuncelle<ResponseTaleplerGuncelleDto, RequestTaleplerGuncelleDto>(_serviceUrlList.PutTaleplerGuncelle, model).Data));
        }

        [HttpGet]
        public IActionResult GetRequestFileList()
        {
            var req = new RequestTaleplerEkDosyaListesiDto();
            req.GrupSiraNo = 2;
            var resp = _apiService.GetTaleplerEkDosyaListesi<ResponseTaleplerEkDosyaListesiDto, RequestTaleplerEkDosyaListesiDto>(_serviceUrlList.GetTaleplerEkDosyaListesi, req).Data;
            return Json(resp);
        }

        [HttpPost]
        public IActionResult AddRequestFile(RequestTaleplerEkDosyaKaydetDto model)
        {
            return Json(_apiService.PostTaleplerEkDosyaKaydet<ResponseTaleplerEkDosyaKaydetDto, RequestTaleplerEkDosyaKaydetDto>(_serviceUrlList.PostTaleplerEkDosyaKaydet, model).Data);
        }

        [HttpDelete]
        public IActionResult DeleteRequestFile(RequestTaleplerEkDosyaSilDto model)
        {
            return Json(_apiService.DeleteTaleplerEkDosyaSil<ResponseTaleplerEkDosyaSilDto, RequestTaleplerEkDosyaSilDto>(_serviceUrlList.DeleteTaleplerEkDosyaSil, model).Data);
        }
    }
}
