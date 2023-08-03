using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yerleşimbilgiplatformu1.Controllers
{
    public class AraController : Controller
    {
        // GET: Ara
        ProvinceManager Pm = new ProvinceManager(new EfProvinceDal());
        DistrictManager Dm = new DistrictManager(new EfDistrictDal());
        NeighbourhoodManager Nm = new NeighbourhoodManager(new EfNeighbourhoodDal());
        UserManager Um = new UserManager(new EfUserDal());
        StreetManager Sm = new StreetManager(new EfStreetDal());
        BuildingNumberManager Bm = new BuildingNumberManager(new EfBuildngNumberDal());
        ApartmentnumberManager Am = new ApartmentnumberManager(new EfApartmentnumberDal());
        UserManager USM = new UserManager(new EfUserDal());
        public ActionResult Index()
        {
            var model = Pm.GetList().ToList();
            return View(model);
        }
        public ActionResult GetDistricts(int cityId)
        {
            var model = Dm.GetList(cityId);
            return Json(model);
        }
        public ActionResult mahgetir(int ilceId)
        {
            var mah = Nm.GetList(ilceId);
            return Json(mah);
        }
        public ActionResult Liste(int NeighbourhoodID)
        {
            var A = Sm.GetList(NeighbourhoodID);
            ViewBag.ıd = NeighbourhoodID;
            return View(A);
        }
        public ActionResult MahalleListe(int StreetID)
        {
            var A = Bm.GetList(StreetID);
            return Json(A);
        }
        public ActionResult KapiNoList(int BuildingNumberID)
        {
            var A = Am.GetList(BuildingNumberID);
            return Json(A);
        }
        public ActionResult Göster(int StreetID)
        {
            var A = USM.GetList(StreetID);
            if(A.Count == 0)
            {
                return RedirectToAction("/Bilgiyok/");
            }
            else
            {
                return View(A);
            }
            
        }
        public ActionResult Sonuc(int id)
        {
            var A = USM.GetByID(id);
            return View(A);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        public ActionResult Bilgiyok()
        {
            return View();
        }
    }
}