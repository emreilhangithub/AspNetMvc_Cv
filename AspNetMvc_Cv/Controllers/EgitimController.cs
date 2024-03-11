using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{
    public class EgitimController : Controller
    {
        GenericRepository<Tbl_Egitimlerim> repo = new GenericRepository<Tbl_Egitimlerim>();
        public ActionResult Index()
        {
            var egitimlerim = repo.List();
            return View(egitimlerim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(Tbl_Egitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }

            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        
    }
}