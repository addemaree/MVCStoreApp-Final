using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Sportscasters_final.DAL;
using System.Data.Entity.Infrastructure.Interception;
using Sportscasters_final.Logging;

namespace Sportscasters_final
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new StoreInterceptorTransientErrors());
            DbInterception.Add(new StoreInterceptorLogging());
        }
    }
}
