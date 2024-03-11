﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetMvc_Cv
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalFilters.Filters.Add(new AuthorizeAttribute());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            var httpException = exception as HttpException;

            if (httpException != null && httpException.GetHttpCode() == 404 && !Request.IsAuthenticated)
            {
                // Kullanıcı girişi yapılmadan 404 hatası alındığında özel 404 sayfasına yönlendirme
                Response.Clear();
                Server.ClearError();
                Response.Redirect("~/Error/Page404");
            }
        }
    }
}
