using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{    
    public class HobiController : Controller
    {
        GenericRepository<Tbl_Hobilerim> repo = new GenericRepository<Tbl_Hobilerim>();
        public ActionResult Index()
        {
            var hobi = repo.List();
            return View(hobi);
        }
        [HttpGet]
        public ActionResult HobiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HobiEkle(Tbl_Hobilerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult HobiSil(int id)
        {
            var hobi = repo.Find(x => x.ID == id);
            repo.TDelete(hobi);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HobiDuzenle(int id)
        {
            var hobi = repo.Find(x => x.ID == id);
            return View(hobi);
        }

        [HttpPost]
        public ActionResult HobiDuzenle(Tbl_Hobilerim t)
        {
            var hobi = repo.Find(x => x.ID == t.ID);
            hobi.Aciklama1 = t.Aciklama1;
            hobi.Aciklama2 = t.Aciklama2;
            repo.TUpdate(hobi);
            return RedirectToAction("Index");
        }
    }
}