using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20191910WeekendTask.DAL;
using _20191910WeekendTask.Areas.Admin.Models;
using System.Web.Helpers;

namespace _20191910WeekendTask.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        _Context db = new _Context();
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Login()
        {
            if (Session["Login"] != null && (bool)Session["Login"] == true)
            {
                return RedirectToAction("Index", "Home");
            }
           
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Admin admin) {
           
            if (string.IsNullOrEmpty(admin.Username) || string.IsNullOrEmpty(admin.Password))
            {
                
                Session["LoginError"] = "Fill the banks";
                return View();

            }
            Models.Admin loginedAdmin = db.Admins.FirstOrDefault(a => a.Username == admin.Username);
            if (loginedAdmin == null)
            {
                
                Session["LoginError"] = "Not Found";
                return View();
            }
            if (loginedAdmin.Password != admin.Password)
            {
                
                Session["LoginError"] = "Incorrect username or password";
                return View();
            }
            Session["Login"] = true;

            return RedirectToAction("Index", "Home");
                
        }

        public ActionResult Logout()
        {
            Session["Login"] = null;
            return RedirectToAction("Login", "Login");
        }

    }
}