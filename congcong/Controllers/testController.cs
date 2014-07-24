using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using congcong.Models;

namespace congcong.Controllers
{
    public class testController : Controller
    {
        private congcongEntities db = new congcongEntities();

        //
        // GET: /test/

        public ActionResult Index()
        {
            return View(db.ExtraUserInformation.ToList());
        }

        //
        // GET: /test/Details/5

        public ActionResult Details(int id = 0)
        {
            ExtraUserInformation extrauserinformation = db.ExtraUserInformation.Find(id);
            if (extrauserinformation == null)
            {
                return HttpNotFound();
            }
            return View(extrauserinformation);
        }

        //
        // GET: /test/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /test/Create

        [HttpPost]
        public ActionResult Create(ExtraUserInformation extrauserinformation)
        {
            if (ModelState.IsValid)
            {
                db.ExtraUserInformation.Add(extrauserinformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(extrauserinformation);
        }

        //
        // GET: /test/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ExtraUserInformation extrauserinformation = db.ExtraUserInformation.Find(id);
            if (extrauserinformation == null)
            {
                return HttpNotFound();
            }
            return View(extrauserinformation);
        }

        //
        // POST: /test/Edit/5

        [HttpPost]
        public ActionResult Edit(ExtraUserInformation extrauserinformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(extrauserinformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(extrauserinformation);
        }

        //
        // GET: /test/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ExtraUserInformation extrauserinformation = db.ExtraUserInformation.Find(id);
            if (extrauserinformation == null)
            {
                return HttpNotFound();
            }
            return View(extrauserinformation);
        }

        //
        // POST: /test/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ExtraUserInformation extrauserinformation = db.ExtraUserInformation.Find(id);
            db.ExtraUserInformation.Remove(extrauserinformation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}