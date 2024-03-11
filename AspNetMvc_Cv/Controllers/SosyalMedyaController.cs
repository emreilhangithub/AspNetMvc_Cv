using AspNetMvc_Cv.Models.Entity;
using AspNetMvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc_Cv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        GenericRepository<Tbl_SosyalMedya> repo = new GenericRepository<Tbl_SosyalMedya>();
        public ActionResult Index()
        {
            var veriler = repo.List();
            return View(veriler);
        }
    }
}