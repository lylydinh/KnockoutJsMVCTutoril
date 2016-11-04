using KnockoutjsCRUDinMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using static KnockoutjsCRUDinMVC.Migrations.Configuration;

namespace KnockoutjsCRUDinMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles); 
                
            var bookContext = new BookContext();
            Database.SetInitializer(new BookInitializer());
            bookContext.Database.Initialize(true);
        }
    }
}
