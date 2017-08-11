using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.MVC.ViewModels;
using ProjetoDDD2PiP2.Application.Interface;
using System.Threading.Tasks;

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

        public ActionResult Index()
        {
            var personaViewModel = Mapper.Map<IEnumerable<Persona>, IEnumerable<PersonaViewModel>>(_personaApp.GetAll());
            return View(personaViewModel);
        }
        
        // GET: Persona/Details/5
        public ActionResult Details(string id)
        {
            var persona = _personaApp.GetById(id);
            var personaViewModel = Mapper.Map<Persona, PersonaViewModel>(persona);
            return View(personaViewModel);
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
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(PersonaViewModel persona)
        {
            if (ModelState.IsValid)
            {
                var personaDomain = Mapper.Map<PersonaViewModel, Persona>(persona);
                _personaApp.Update(personaDomain);
                return RedirectToAction("Index");
            }
            return View(persona);
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(string id)
        {
            var persona = _personaApp.GetById(id);
            var personaViewModel = Mapper.Map<Persona, PersonaViewModel>(persona);
            return View(personaViewModel);
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(string id)
        {
            var persona = _personaApp.GetById(id);
            _personaApp.Remove(persona);
            return RedirectToAction("Index");
            
        }
    }
}
