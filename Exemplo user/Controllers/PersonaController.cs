using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using ProjetoDDD2PiP2.Application.Interface;
using Portal2pip2.MVC.ViewModels;

namespace ProjetoDDD2PiP2.MVC.Controllers
{
    [Authorize]
    public class PersonaController : Controller
    {
        private readonly IPersonaAppService _personaApp;
        public PersonaController(IPersonaAppService personaApp)
        {
            _personaApp = personaApp;
        }

        // GET: Persona
        public ActionResult Index()
        {
            var personaViewModel = Mapper.Map<IEnumerable<Persona>, IEnumerable<PersonaViewModel>>(_personaApp.GetAll());
            return View(personaViewModel);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(PersonaViewModel persona)
        {
            if (ModelState.IsValid)
            {
                var personaDomain = Mapper.Map<PersonaViewModel, Persona>(persona);
                _personaApp.Add(personaDomain);
                return RedirectToAction("Index");
            }
            return View(persona);
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
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
