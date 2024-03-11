using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<Tbl_Admin> repo = new GenericRepository<Tbl_Admin>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(Tbl_Admin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult AdminSil(int id)
        {
            var admin = repo.Find(x => x.ID == id);
            repo.TDelete(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminDuzenle(int id)
        {
            var admin = repo.Find(x => x.ID == id);
            return View(admin);
        }

        [HttpPost]
        public ActionResult AdminDuzenle(Tbl_Admin t)
        {
            var admin = repo.Find(x => x.ID == t.ID);
            admin.KullaniciAdi = t.KullaniciAdi;
            admin.Sifre = t.Sifre;
            repo.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}