using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTATOEIc.Models;
using MTATOEIc.Models.code;
using MTATOEIc.Models.EF;
namespace MTATOEIc.Controllers
{
    public class BTLuyenNgheController : Controller
    {
        // GET: BTLuyenNghe
        public ActionResult BTLuyenNghe()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTLuyenNghe1()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTLuyenNghe2()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTLuyenNghe3()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTLuyenNghe4()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
    }
}