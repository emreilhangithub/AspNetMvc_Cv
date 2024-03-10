using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvc_Cv.Models.Entity;

namespace AspNetMvc_Cv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Hakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Deneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.Tbl_Egitimlerim.ToList();
            return PartialView(egitimler);
        }

    }
}