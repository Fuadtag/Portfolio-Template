using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20191910WeekendTask.Models;
using _20191910WeekendTask.DAL;

namespace _20191910WeekendTask.Controllers
{
    public class HomeController : Controller
    {
        BaseModel BaseModel;
        

        public ActionResult Index()
        {
            _Context db = new _Context();
            BaseModel baseModel = new BaseModel() {
                Skills = db.Skills.ToList(),
                Awards = db.Awards.ToList(),
                Educations = db.Educations.ToList(),
                Experiences = db.Experiences.ToList(),
                Interests = db.Interests.ToList(),
                Contact = db.Contacts.FirstOrDefault(),

                

            };

            return View(baseModel);
        }

      
    }
}