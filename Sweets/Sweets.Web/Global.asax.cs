using Sweets.Web.Infrastructure.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sweets.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AddViewEngines();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private static void AddViewEngines()
        {
            ViewEngines.Engines.Add(new PartialViewEngine());
        }
    }
}
