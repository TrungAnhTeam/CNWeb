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
    
    public class LoginController : Controller
    {
        // GET: Login
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Account model)
        {
            var result = new AccountLogin().Login(model.Username, model.Password);
            if(result && ModelState.IsValid)
            {
                Sessionhelper.SetSession(new UsernameSession() { Username = model.Username });
                return RedirectToAction("Trangchu", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Ten hoac mat khau khong dung");
            }
            
            
            return View(model);
        }
        
    }
}