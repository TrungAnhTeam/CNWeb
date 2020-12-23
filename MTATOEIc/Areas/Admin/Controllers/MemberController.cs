using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTATOEIc.Models.EF;

namespace MTATOEIc.Areas.Admin.Controllers
{
    public class MemberController : Controller
    {
        // GET: Admin/Member
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Member()
        {
            DATABASE da = new DATABASE();
            ViewBag.member = da.Accounts.ToList();
            
            return View();
        }
        public ActionResult chitietMb(string username)
        {

            DATABASE da = new DATABASE();
            ViewBag.ct = da.ProfileTAs.FirstOrDefault(s => s.Pro_ID == username);
            ViewBag.role = da.Accounts.FirstOrDefault(s => s.Username == username);


            return View();
        }
        public ActionResult quantrivien()
        {
            return View();
        }


      
    }
}
