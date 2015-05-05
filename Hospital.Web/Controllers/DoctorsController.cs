using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hospital.Core.Entities;
using Hospital.Infrastructure;
using Hospital.Core.Interface;

namespace Hospital.Web.Controllers
{
    public class DoctorsController : Controller
    {
        private IDoctorRepository db;
        public DoctorsController(IDoctorRepository db)
        {
            this.db = db; 
        }

        // GET: Doctors
        public ActionResult Index()
        {
            return View(db.GetDoctors().ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.FindById(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DoctorID,Name,PhoneNumber")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Add(doctor);
               // db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.FindById(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DoctorID,Name,PhoneNumber")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(doctor).State = EntityState.Modified;
                db.Edit(doctor);

                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.FindById(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Doctor doctor = db.FindById(id);
            db.Remove(doctor.DoctorID);
            return RedirectToAction("Index");
        }

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
