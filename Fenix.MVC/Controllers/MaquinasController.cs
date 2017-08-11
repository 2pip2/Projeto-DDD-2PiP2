using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fenix.MVC.Controllers
{
    public class MaquinasController : Controller
    {
        // GET: Maquinas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Maquinas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Maquinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maquinas/Create
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

        // GET: Maquinas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Maquinas/Edit/5
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

        // GET: Maquinas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Maquinas/Delete/5
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
