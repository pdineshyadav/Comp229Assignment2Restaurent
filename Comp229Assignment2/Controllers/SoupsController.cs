using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp229Assignment2.Models;

namespace Comp229Assignment2.Controllers
{
    public class SoupsController : Controller
    {
        private MenuContext db = new MenuContext();

        // GET: Soups
        public ActionResult Index()
        {
            return View(db.Soups.ToList());
        }

        // GET: Soups/Admin
        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View(db.Soups.ToList());
        }

        // GET: Soups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
               // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soup Soup = db.Soups.Find(id);
            if (Soup == null)
            {
                return HttpNotFound();
            }
            return View(Soup);
        }

        // GET: Soups/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Soups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoupId,SoupName,SoupshortDescription,SoupLongDescription,SoupPrice,SoupImage")] Soup Soup)
        {
            if (ModelState.IsValid)
            {
                db.Soups.Add(Soup);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(Soup);
        }

        // GET: Soups/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
               // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soup Soup = db.Soups.Find(id);
            if (Soup == null)
            {
                return HttpNotFound();
            }
            return View(Soup);
        }

        // POST: Soups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoupId,SoupName,SoupshortDescription,SoupLongDescription,SoupPrice,SoupImage")] Soup Soup)
        {
            if (ModelState.IsValid)
            {
               // db.Entry(Soup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(Soup);
        }

        // GET: Soups/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
              //  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soup Soup = db.Soups.Find(id);
            if (Soup == null)
            {
                return HttpNotFound();
            }
            return View(Soup);
        }

        // POST: Soups/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Soup Soup = db.Soups.Find(id);
            db.Soups.Remove(Soup);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [Authorize(Roles = "Admin")]
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