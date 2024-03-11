using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{
    public class IletisimController : Controller
    {
        GenericRepository<Tbl_Iletisim> repo = new GenericRepository<Tbl_Iletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
        public ActionResult MesajSil(int id)
        {
            var mesaj = repo.Find(x => x.ID == id);
            repo.TDelete(mesaj);
            return RedirectToAction("Index");
        }
    }
}