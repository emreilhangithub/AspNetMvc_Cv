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
    }
}