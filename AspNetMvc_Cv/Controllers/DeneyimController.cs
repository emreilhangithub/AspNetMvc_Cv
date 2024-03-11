using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        GenericRepository<Tbl_Deneyimlerim> repo = new GenericRepository<Tbl_Deneyimlerim>();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(Tbl_Deneyimlerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeneyimSil(int id)
        {
            var deneyim = repo.Find(x => x.ID == id);
            repo.TDelete(deneyim);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            var deneyim = repo.Find(x => x.ID == id);
            return View(deneyim);
        }

        [HttpPost]
        public ActionResult DeneyimGetir(Tbl_Deneyimlerim t)
        {
            var deneyim = repo.Find(x => x.ID == t.ID);
            deneyim.Baslik = t.Baslik;
            deneyim.AltBaslik = t.AltBaslik;
            deneyim.Tarih = t.Tarih;
            deneyim.Aciklama  = t.Aciklama;
            repo.TUpdate(deneyim);
            return RedirectToAction("Index");
        }
    }
}