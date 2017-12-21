using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RajvinderYogi_Assignment1_COMP2084.Models;

namespace RajvinderYogi_Assignment1_COMP2084.Controllers
{
    public class ClassicCarsController : Controller
    {
        //VintageCarsModel db = new VintageCarsModel();
        private InterfaceClassicCarsRepository db;

        //if no mock data, use live database
        public ClassicCarsController()
        {
            this.db = new EFClassicCarsRepository();
        }

        // use mock data while testing
        public ClassicCarsController(InterfaceClassicCarsRepository db)
        {
            this.db = db;
        }

        // GET: ClassicCars
        public ActionResult Index()
        {
            return View(db.ClassicCars.ToList());
        }

        //// GET: ClassicCars/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ClassicCar classicCar = db.ClassicCars.Find(id);
        //    if (classicCar == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(classicCar);
        //}
        //[Authorize]
        //// GET: ClassicCars/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ClassicCars/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "CarId,CarName,MakeYear,Country")] ClassicCar classicCar)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ClassicCars.Add(classicCar);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(classicCar);
        //}
        //[Authorize]
        //// GET: ClassicCars/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ClassicCar classicCar = db.ClassicCars.Find(id);
        //    if (classicCar == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(classicCar);
        //}

        //// POST: ClassicCars/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "CarId,CarName,MakeYear,Country")] ClassicCar classicCar)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(classicCar).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(classicCar);
        //}
        //[Authorize]
        //// GET: ClassicCars/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ClassicCar classicCar = db.ClassicCars.Find(id);
        //    if (classicCar == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(classicCar);
        //}

        //// POST: ClassicCars/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    ClassicCar classicCar = db.ClassicCars.Find(id);
        //    db.ClassicCars.Remove(classicCar);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
