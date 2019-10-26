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
    public class SkillsController : Controller
    {
        private _Context db = new _Context();

        // GET: Admin/Skills
        public ActionResult Index()
        {
            return View(db.Skills.ToList());
        }

        // GET: Admin/Skills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skills skills = db.Skills.Find(id);
            if (skills == null)
            {
                return HttpNotFound();
            }
            return View(skills);
        }

        // GET: Admin/Skills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Skills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Skills skills)
        {
            if (ModelState.IsValid)
            {
                db.Skills.Add(skills);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skills);
        }

        // GET: Admin/Skills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skills skills = db.Skills.Find(id);
            if (skills == null)
            {
                return HttpNotFound();
            }
            return View(skills);
        }

        // POST: Admin/Skills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Skills skills)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skills).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skills);
        }

        // GET: Admin/Skills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skills skills = db.Skills.Find(id);
            if (skills == null)
            {
                return HttpNotFound();
            }
            return View(skills);
        }

        // POST: Admin/Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skills skills = db.Skills.Find(id);
            db.Skills.Remove(skills);
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
