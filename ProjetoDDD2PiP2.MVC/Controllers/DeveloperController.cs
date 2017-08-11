using AutoMapper;
using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoDDD2PiP2.MVC.Controllers
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
        public ActionResult Details(string id)
        {
            var developer = _developerApp.GetById(id);
            var entidadeViewModel = Mapper.Map<Developers, DeveloperViewModel>(developer);
            return View(entidadeViewModel);

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
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Developer/Edit/5
        [HttpPost]
        public ActionResult Edit(DeveloperViewModel developer)
        {
            if (ModelState.IsValid)
            {
                var developerDomain = Mapper.Map<DeveloperViewModel, Developers>(developer);
                _developerApp.Update(developerDomain);
                return RedirectToAction("Index");
            }
            return View(developer);

        }

        // GET: Developer/Delete/5
        public ActionResult Delete(string id)
        {
            var developer = _developerApp.GetById(id);
            var developerViewModel = Mapper.Map<Developers, DeveloperViewModel>(developer);
            return View(developerViewModel);
        }

        // POST: Developer/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(string id)
        {
            var developer = _developerApp.GetById(id);
            _developerApp.Remove(developer);
            return RedirectToAction("Index");
        }
    }
}
