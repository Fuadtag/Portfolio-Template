using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _20191910WeekendTask.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
        
    }
}