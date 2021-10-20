using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    [Authorize(Users = "test")] 
    public class LekarzController : Controller
    {
        //
        // GET: /Lekarz/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Lekarz/wizyta
        public ActionResult wizyta()
        {
            return View();
        }
        //
        // GET: /Lekarz/choroby_pacjenta
        public ActionResult choroby_pacjenta()
        {
            return View();
        }

        //
        // GET: /Lekarz/termin_wizyty
        public ActionResult termin_wizyty()
        {
            return View();
        }
      
        //
        // GET: /Lekarz/historia_pacjenta
        public ActionResult historia_pacjenta()
        {
            return View();
        }

        //
        // GET: /Lekarz/recepta
        public ActionResult recepta()
        {
            return View();

        }
        
        [HttpPost]
        public ActionResult dodajrecepte(recepta recepta)
        {
            if (!ModelState.IsValid)
                return View("Index", recepta);
            else
            {
                ApplicationDbContext db = new ApplicationDbContext();
                db.recepty.Add(recepta);
                db.SaveChanges();
                return View("wyslane");
            }
        }

        //
        // GET: /Lekarz/skierowanie
        public ActionResult skierowanie()
        {
            return View();
        }

        //
        // GET: /Lekarz/zwolnienia_lekarskie
        public ActionResult zwolnienia_lekarskie()
        {
            return View();
        }

        //
        // GET: /Lekarz/urlop
        public ActionResult urlop()
        {
            return View();
        }

        //
        // GET: /Lekarz/wyszukaj_pacjenta
        public ActionResult wyszukaj_pacjenta()
        {
            return View();
        }
  
        //
        // GET: /Lekarz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Lekarz/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Lekarz/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Lekarz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Lekarz/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Lekarz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Lekarz/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
