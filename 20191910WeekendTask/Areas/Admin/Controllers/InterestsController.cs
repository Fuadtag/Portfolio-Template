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
    public class InterestsController : Controller
    {
        private _Context db = new _Context();

        // GET: Admin/Interests
        public ActionResult Index()
        {
            return View(db.Interests.ToList());
        }

        // GET: Admin/Interests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interests interests = db.Interests.Find(id);
            if (interests == null)
            {
                return HttpNotFound();
            }
            return View(interests);
        }

        // GET: Admin/Interests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Interests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] Interests interests)
        {
            if (ModelState.IsValid)
            {
                db.Interests.Add(interests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interests);
        }

        // GET: Admin/Interests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interests interests = db.Interests.Find(id);
            if (interests == null)
            {
                return HttpNotFound();
            }
            return View(interests);
        }

        // POST: Admin/Interests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description")] Interests interests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interests);
        }

        // GET: Admin/Interests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interests interests = db.Interests.Find(id);
            if (interests == null)
            {
                return HttpNotFound();
            }
            return View(interests);
        }

        // POST: Admin/Interests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Interests interests = db.Interests.Find(id);
            db.Interests.Remove(interests);
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
