using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MTATOEIc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "Trangchu" }
            );
            routes.MapRoute(
                name: "TuVung",
                url: "tu-vung",
                defaults: new { controller = "Home", action = "TuVung" }
            );
            routes.MapRoute(
                name: "NguPhap",
                url: "ngu-phap",
                defaults: new { controller = "Home", action = "NguPhap" }
            );
            routes.MapRoute(
                name: "BTNguPhap",
                url: "bai-tap-ngu-phap",
                defaults: new { controller = "BTNguPhap", action = "BTNguPhap" }
            );
            routes.MapRoute(
                name: "BTNguPhap1",
                url: "bai-tap-ngu-phap-unit1",
                defaults: new { controller = "BTNguPhap", action = "BTNguPhap1" }
            );
            routes.MapRoute(
                name: "BTNguPhap2",
                url: "bai-tap-ngu-phap-unit2",
                defaults: new { controller = "BTNguPhap", action = "BTNguPhap2" }
            );
            routes.MapRoute(
                name: "BTNguPhap3",
                url: "bai-tap-ngu-phap-unit3",
                defaults: new { controller = "BTNguPhap", action = "BTNguPhap3" }
            );
            routes.MapRoute(
                name: "BTNguPhap4",
                url: "bai-tap-ngu-phap-unit4",
                defaults: new { controller = "BTNguPhap", action = "BTNguPhap4" }
            );
            routes.MapRoute(
                name: "BTTuvung2",
                url: "bai-tap-tu-vung-unit2",
                defaults: new { controller = "BTTuVung", action = "BTTuVung2" }
            );
            routes.MapRoute(
                name: "BTTuvung3",
                url: "bai-tap-tu-vung-unit3",
                defaults: new { controller = "BTTuVung", action = "BTTuVung3" }
            );
            routes.MapRoute(
                name: "BTTuvung4",
                url: "bai-tap-tu-vung-unit4",
                defaults: new { controller = "BTTuVung", action = "BTTuVung4" }
            );
            routes.MapRoute(
                name: "BTTuvung1",
                url: "bai-tap-tu-vung-unit1",
                defaults: new { controller = "BTTuVung", action = "BTTuVung1" }
            );

            routes.MapRoute(
                name: "BTLuyenNghe",
                url: "bai-tap-luyen-nghe",
                defaults: new { controller = "BTLuyenNghe", action = "BTLuyenNghe" }
            );
            routes.MapRoute(
                name: "BTLuyenNghe1",
                url: "bai-tap-luyen-nghe-unit1",
                defaults: new { controller = "BTLuyenNghe", action = "BTLuyenNghe1" }
            );
            routes.MapRoute(
                name: "BTLuyenNghe2",
                url: "bai-tap-luyen-nghe-unit2",
                defaults: new { controller = "BTLuyenNghe", action = "BTLuyenNghe2" }
            );
            routes.MapRoute(
                name: "Login",
                url: "Login",
                defaults: new { controller = "Login", action = "Index" }
            );
            routes.MapRoute(
                name: "LuyenNghe",
                url: "Luyen-Nghe",
                defaults: new { controller = "trangchu", action = "LuyenNghe" }
            );
            routes.MapRoute(
                name: "NguPhapCoBan",
                url: "Ngu-Phap-co-ban",
                defaults: new { controller = "trangchu", action = "NguPhap" }
            );
            routes.MapRoute(
                name: "TuVungCoBan",
                url: "Tu-vung-co-ban",
                defaults: new { controller = "trangchu", action = "TuVung"}
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "trangchu", action = "trangchu", id = UrlParameter.Optional }
            );
        }
    }
}
