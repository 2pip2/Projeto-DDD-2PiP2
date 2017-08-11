using AutoMapper;
using ProjetoDDD2PiP2.Application.Interface;
using Portal2pip2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoDDD2PiP2.MVC.Controllers
{
    [Authorize]
    public class SoluctionController : Controller
    {
        // GET: Soluction
        private readonly ISoluctionAppService _soluctionapp;
        public SoluctionController(ISoluctionAppService soluctionapp)
        {
            _soluctionapp = soluctionapp;
        }


        public ActionResult Index()
        {
            var soluctionViewModel = Mapper.Map<IEnumerable<Soluctions>, IEnumerable<SoluctionViewModel>>(_soluctionapp.GetAll());
            return View(soluctionViewModel);            
        }

        // GET: Soluction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Soluction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Soluction/Create
        [HttpPost]
        public ActionResult Create(SoluctionViewModel soluction)
        {
            if (ModelState.IsValid)
            {
                var soluctionDomain = Mapper.Map<SoluctionViewModel, Soluctions>(soluction);
                _soluctionapp.Add(soluctionDomain);
                return RedirectToAction("Index");
            }
            return View(soluction);
        }

        // GET: Soluction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Soluction/Edit/5
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

        // GET: Soluction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Soluction/Delete/5
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
