using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class receptaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /recepta/
        public ActionResult Index()
        {
            return View(db.recepty.ToList());
        }

        // GET: /recepta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recepta recepta = db.recepty.Find(id);
            if (recepta == null)
            {
                return HttpNotFound();
            }
            return View(recepta);
        }

        // GET: /recepta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /recepta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="receptaId,Pacjent,NazwaLeku,IloscOpakowanOrazTalbetek,WaznoscRecepty")] recepta recepta)
        {
            if (ModelState.IsValid)
            {
                db.recepty.Add(recepta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recepta);
        }

        // GET: /recepta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recepta recepta = db.recepty.Find(id);
            if (recepta == null)
            {
                return HttpNotFound();
            }
            return View(recepta);
        }

        // POST: /recepta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="receptaId,Pacjent,NazwaLeku,IloscOpakowanOrazTalbetek,WaznoscRecepty")] recepta recepta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recepta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recepta);
        }

        // GET: /recepta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recepta recepta = db.recepty.Find(id);
            if (recepta == null)
            {
                return HttpNotFound();
            }
            return View(recepta);
        }

        // POST: /recepta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recepta recepta = db.recepty.Find(id);
            db.recepty.Remove(recepta);
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
