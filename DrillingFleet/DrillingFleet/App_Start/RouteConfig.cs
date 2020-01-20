using System.Web.Mvc;
using System.Web.Routing;

namespace DrillingFleet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Rig", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
