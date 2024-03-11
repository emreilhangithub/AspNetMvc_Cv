using AspNetMvc_Cv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvc_Cv.Repositories;

namespace AspNetMvc_Cv.Controllers
{
    public class YetenekController : Controller
    {
        GenericRepository<Tbl_Yeteneklerim> repo = new GenericRepository<Tbl_Yeteneklerim> ();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
    }
}