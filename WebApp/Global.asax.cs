using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //need to create a customer info controller with first name, last name, email address.
            WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection("BearhugWear", "Customer", "CustomerID", "EmailAddress", true);

            if (!Roles.RoleExists("administrator"))
                Roles.CreateRole("Administrator");
        }
    }
}
