using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _20191910WeekendTask.DAL;
using _20191910WeekendTask.Models;

namespace _20191910WeekendTask.Areas.Admin.Controllers
{
    public class AwardsController : Controller
    {
        private _Context db = new _Context();

        // GET: Admin/Awards
	
        
        public ActionResult Index()
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            return View(db.Awards.ToList());
        }

        // GET: Admin/Awards/Details/5
        public ActionResult Details(int? id)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Award award = db.Awards.Find(id);
            if (award == null)
            {
                return HttpNotFound();
            }
            return View(award);
        }

        // GET: Admin/Awards/Create
        public ActionResult Create()
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            return View();
        }

        // POST: Admin/Awards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] Award award)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            if (ModelState.IsValid)
            {

                db.Awards.Add(award);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(award);
        }

        // GET: Admin/Awards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Award award = db.Awards.Find(id);
            if (award == null)
            {
                return HttpNotFound();
            }
            return View(award);
        }

        // POST: Admin/Awards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description")] Award award)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            if (ModelState.IsValid)
            {
                db.Entry(award).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(award);
        }

        // GET: Admin/Awards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Award award = db.Awards.Find(id);
            if (award == null)
            {
                return HttpNotFound();
            }
            return View(award);
        }

        // POST: Admin/Awards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "Login");
            };
            Award award = db.Awards.Find(id);
            db.Awards.Remove(award);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
