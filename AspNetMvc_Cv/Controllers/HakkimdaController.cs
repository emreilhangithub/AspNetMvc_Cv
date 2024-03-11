using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{
    public class HakkimdaController : Controller
    {
        GenericRepository<Tbl_Hakkimda> repo = new GenericRepository<Tbl_Hakkimda>();
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }

        [HttpPost]
        public ActionResult Index(Tbl_Hakkimda t)
        {
            var hakkimda = repo.Find(x => x.ID == 1); //ilkini getirdik
            hakkimda.Ad = t.Ad;
            hakkimda.Soyad = t.Soyad;
            hakkimda.Adres = t.Adres;
            hakkimda.Mail = t.Mail;
            hakkimda.Telefon = t.Telefon;
            hakkimda.Aciklama = t.Aciklama;
            hakkimda.Resim = t.Resim;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }


    }
}