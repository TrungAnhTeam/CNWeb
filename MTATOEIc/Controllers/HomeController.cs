using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTATOEIc.Models.EF;

namespace MTATOEIc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Trangchu()
        {
            return View();
        }
        public ActionResult TuVung()
        {
            return View();
        }
        public ActionResult NguPhap()
        {
            return View();
        }
        public ActionResult LuyenNghe()
        {
            return View();
        }
        
        
    }
}