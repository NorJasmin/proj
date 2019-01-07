﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proj;

namespace proj.Controllers
{
    public class FathersController : Controller
    {
        private Entities4 db = new Entities4();

        // GET: Fathers
        public ActionResult Index()
        {
            return View(db.Fathers.ToList());
        }

        // GET: Fathers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Father father = db.Fathers.Find(id);
            if (father == null)
            {
                return HttpNotFound();
            }
            return View(father);
        }

        // GET: Fathers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fathers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Contact,Address,Occupation,Salary")] Father father)
        {
            if (ModelState.IsValid)
            {
                db.Fathers.Add(father);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(father);
        }

        // GET: Fathers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Father father = db.Fathers.Find(id);
            if (father == null)
            {
                return HttpNotFound();
            }
            return View(father);
        }

        // POST: Fathers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Contact,Address,Occupation,Salary")] Father father)
        {
            if (ModelState.IsValid)
            {
                db.Entry(father).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(father);
        }

        // GET: Fathers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Father father = db.Fathers.Find(id);
            if (father == null)
            {
                return HttpNotFound();
            }
            return View(father);
        }

        // POST: Fathers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Father father = db.Fathers.Find(id);
            db.Fathers.Remove(father);
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
