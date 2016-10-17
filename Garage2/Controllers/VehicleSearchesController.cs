using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage2.Models;

namespace Garage2.Controllers
{
    public class VehicleSearchesController : Controller
    {
        private Garage2Context db = new Garage2Context();

        // GET: VehicleSearches
        public ActionResult Index()
        {
            return View(db.VehicleSearches.ToList());
        }

        // GET: VehicleSearches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleSearch vehicleSearch = db.VehicleSearches.Find(id);
            if (vehicleSearch == null)
            {
                return HttpNotFound();
            }
            return View(vehicleSearch);
        }

        // GET: VehicleSearches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleSearches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Regnr,Color")] VehicleSearch vehicleSearch)
        {
            if (ModelState.IsValid)
            {
                db.VehicleSearches.Add(vehicleSearch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleSearch);
        }

        // GET: VehicleSearches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleSearch vehicleSearch = db.VehicleSearches.Find(id);
            if (vehicleSearch == null)
            {
                return HttpNotFound();
            }
            return View(vehicleSearch);
        }

        // POST: VehicleSearches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Regnr,Color")] VehicleSearch vehicleSearch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleSearch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleSearch);
        }

        // GET: VehicleSearches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleSearch vehicleSearch = db.VehicleSearches.Find(id);
            if (vehicleSearch == null)
            {
                return HttpNotFound();
            }
            return View(vehicleSearch);
        }

        // POST: VehicleSearches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleSearch vehicleSearch = db.VehicleSearches.Find(id);
            db.VehicleSearches.Remove(vehicleSearch);
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
