using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspNetMvc_Cv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        GenericRepository<Tbl_Admin> repo = new GenericRepository<Tbl_Admin>();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin p)
        {
            DbCvEntities db = new DbCvEntities();
            var bilgi = db.Tbl_Admin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index","Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}