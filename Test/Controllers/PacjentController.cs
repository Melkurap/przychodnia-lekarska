using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    [Authorize(Users = "test")] 
    public class PacjentController : Controller
    {
        //
        // GET: /Pacjent/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Pacjent/pacjent
        public ActionResult pacjent()
        {
            return View();
        }
        //
        // GET: /Pacjent/lekarze
        public ActionResult lekarze()
        {
            return View();
        }

        //
        // GET: /Pacjent/dostepni_lekarze
        public ActionResult dostepni_lekarze()
        {
            return View();
        }
        //
        // GET: /Pacjent/karta_pacjeta
        public ActionResult karta_pacjeta()
        {
            return View();
        }

        //
        // GET: /Pacjent/rezygnacja
        public ActionResult rezygnacja()
        {
            return View();
        }
        //
        // GET: /Pacjent/karta_badan
        public ActionResult karta_badan()
        {
            return View();
        }

        //
        // GET: /Pacjent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pacjent/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pacjent/Create
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
        // GET: /Pacjent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pacjent/Edit/5
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
        // GET: /Pacjent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pacjent/Delete/5
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
