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
    public class BTNguPhapController : Controller
    {
        // GET: BTNguPhap
        public ActionResult BTNguPhap()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTNguPhap1()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTNguPhap2()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTNguPhap3()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
        public ActionResult BTNguPhap4()
        {
            DATABASE da = new DATABASE();
            ViewBag.Unit = da.Units.ToList();
            ViewBag.qs = da.Questions.ToList();
            return View();
        }
    }
}