using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.MVC.ViewModels;
using ProjetoDDD2PiP2.Application.Interface;

namespace ProjetoDDD2PiP2.MVC.Controllers
{
    [Authorize]
    public class EntidadeController : Controller
    {
        // GET: Entidade

        private readonly IEntidadeAppService _entidadeapp;
        public EntidadeController(IEntidadeAppService entidadeApp)
        {
            _entidadeapp = entidadeApp;
        }

        public ActionResult Index()
        {
            var entidadeViewModel = Mapper.Map<IEnumerable<Entidade>, IEnumerable<EntidadeViewModel>>(_entidadeapp.GetAll());

            return View(entidadeViewModel);            
        }

        // GET: Entidade/Details/5
        public ActionResult Details(string id)
        {
            var entidade = _entidadeapp.GetById(id);
            var entidadeViewModel = Mapper.Map<Entidade, EntidadeViewModel>(entidade);
            return View(entidadeViewModel);           
        }

        // GET: Entidade/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: Entidade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntidadeViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                var entidadeDomain = Mapper.Map<EntidadeViewModel, Entidade>(entidade);
                _entidadeapp.Add(entidadeDomain);
                return RedirectToAction("Index");
            }
            return View(entidade);
        }

        // GET: Entidade/Edit/5
        public ActionResult Edit(string id)
        {
            var entidade = _entidadeapp.GetById(id);
            var entidadeViewModel = Mapper.Map<Entidade, EntidadeViewModel>(entidade);
            return View(entidadeViewModel);
        }

        // POST: Entidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EntidadeViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                var entidadeDomain = Mapper.Map<EntidadeViewModel, Entidade>(entidade);
                _entidadeapp.Update(entidadeDomain);
                return RedirectToAction("Index");
            }
            return View(entidade);
        }

        // GET: Entidade/Delete/5
        public ActionResult Delete(string id)
        {
            var entidade = _entidadeapp.GetById(id);
            var entidadeViewModel = Mapper.Map<Entidade, EntidadeViewModel>(entidade);
            return View(entidadeViewModel);
        }

        // POST: Entidade/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var entidade = _entidadeapp.GetById(id);
            _entidadeapp.Remove(entidade);
            return RedirectToAction("Index");
        }
    }
}
