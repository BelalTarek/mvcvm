using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RCS.Models;
using Microsoft.AspNet.Identity;
using System.Collections;

namespace RCS.Controllers
{
    
    public class CarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            var cars = db.Cars.Include(c => c.user);
         
            return View(cars.ToList());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Admin")]

        public ActionResult Create
        ([Bind(Include = "Id,UserId,Name,Model,Type,color,NumberOfChairs,RentAmount,isAvailable")]
         Car car)
        {
      
            if (ModelState.IsValid)
            {
                car.UserId = User.Identity.GetUserId();
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        public JsonResult GetType(string SearchTerm)
        {
            var dataList = db.Cars.ToList();
            if (SearchTerm != null)
            {
                 dataList = db.Cars.Where(x => x.Type.Contains(SearchTerm)).ToList();
            }
            var modifiedData = dataList.Select(x => new {
                id = x.Id,
                text = x.Type
            });
            return Json(modifiedData,JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save (string data)
        {
            return Json(0, JsonRequestBehavior.AllowGet);
        }


        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "Id,UserId,Name,Model,Type,color,NumberOfChairs,RentAmount,isAvailable")] Car car)
        {
            if (ModelState.IsValid)
            {
                car.UserId = User.Identity.GetUserId();
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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
