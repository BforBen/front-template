using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace GuildfordBoroughCouncil.Web.FrontTemplateDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.LowercaseUrls = true;
            RouteTable.Routes.MapMvcAttributeRoutes();

            BundleTable.Bundles.Add(new StyleBundle("~/assets/css").Include("~/assets/main.css"));
        }
    }
}
