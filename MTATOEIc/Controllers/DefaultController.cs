using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTATOEIc.Models;

namespace MTATOEIc.Controllers
{
    public class DefaultController : Controller
    {
        Model1 SA = new Model1();
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Levels = SA.LevelTAs.ToList();
            return View();
        }
    }
}