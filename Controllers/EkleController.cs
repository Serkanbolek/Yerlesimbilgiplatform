using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Yerleşimbilgiplatformu1.Controllers
{
    public class EkleController : Controller
    {
        // GET: Ekle
        UserManager USM = new UserManager(new EfUserDal());
        ProvinceManager Pm = new ProvinceManager(new EfProvinceDal());
        DistrictManager Dm = new DistrictManager(new EfDistrictDal());
        NeighbourhoodManager Nm = new NeighbourhoodManager(new EfNeighbourhoodDal());
        UserManager Um = new UserManager(new EfUserDal());
        StreetManager Sm = new StreetManager(new EfStreetDal());
        BuildingNumberManager Bm = new BuildingNumberManager(new EfBuildngNumberDal());
        ApartmentnumberManager Am = new ApartmentnumberManager(new EfApartmentnumberDal());
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.pr = Pm.GetList().ToList();
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(User Image, HttpPostedFileBase UserImage)
        {
            if (Image.StreetID != 0)
            {
                WebImage img = new WebImage(UserImage.InputStream);

                if (Request.Files.Count > 0)
                {
                    string dosyaadi = Guid.NewGuid().ToString().Substring(0, 10);
                    string uzantı = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "/Image/" + dosyaadi + uzantı;
                    img.Save(Server.MapPath(yol));
                    Image.UserImage = "/Image/" + dosyaadi + uzantı;
                }
                Image.Comments.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                USM.DistrictAdd(Image);
                return RedirectToAction("/Index");
            }
            else
            {
                return RedirectToAction("/Kayıthata");
            }

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
            return Json(A);
        }
        public ActionResult Kayıthata()
        {
            return View();
        }
    }
}