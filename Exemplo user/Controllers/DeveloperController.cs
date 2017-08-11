using AutoMapper;
using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Portal2pip2.MVC.Controllers
{
    [Authorize]
    public class DeveloperController : Controller
    {
        private readonly IDeveloperAppService _developerApp;
        // GET: Developer
        public DeveloperController( IDeveloperAppService developerApp)
        {
            _developerApp = developerApp;
        }
        public ActionResult Index()
        {
            var developerViewModel = Mapper.Map<IEnumerable<Developers>, IEnumerable<DeveloperViewModel>>(_developerApp.GetAll());
            return View(developerViewModel);
        }

        // GET: Developer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Developer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Developer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DeveloperViewModel developer)
        {
            if (ModelState.IsValid)
            {
                var developerDomain = Mapper.Map<DeveloperViewModel, Developers>(developer);
                _developerApp.Add(developerDomain);
                return RedirectToAction("Index");
            }
            return View(developer);
        }

        // GET: Developer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Developer/Edit/5
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

        // GET: Developer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Developer/Delete/5
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
