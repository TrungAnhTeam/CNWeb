using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTATOEIc.Models.EF;

namespace MTATOEIc.Areas.Admin.Controllers
{
    public class quantrivienController : Controller
    {
        // GET: Admin/quantrivien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult quantrivien()
        {
            DATABASE da = new DATABASE();
            ViewBag.ad = da.Accounts.ToList();
            return View();
        }
        
        public ActionResult chitietad(string username)
        {
            
            DATABASE da = new DATABASE();
            ViewBag.ct = da.ProfileTAs.FirstOrDefault(s => s.Pro_ID == username);
            ViewBag.role = da.Accounts.FirstOrDefault(s => s.Username == username);
            
         
            return View();
        }


    }
}
