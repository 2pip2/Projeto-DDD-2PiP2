using AutoMapper;
using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using Fluentx.Mvc;
using ProjetoDDD2PiP2.Domain.Entities;

namespace ProjetoDDD2PiP2.MVC.Controllers
{
    [Authorize]
    public class SolutionController : Controller
    {
        // GET: Soluction
        private readonly ISoluctionAppService _soluctionapp;
        public SolutionController(ISoluctionAppService soluctionapp)
        {
            _soluctionapp = soluctionapp;
        }
        public ActionResult SolucaoFoco(string SolutionRegra)
        {
            var postData = new Dictionary<string, object>();
            postData.Add("Roles", string.Join(",", SolutionRegra));
            var red = new RedirectAndPostActionResult("http://verre.2pip2.com", postData);
            return red;
        }

        public ActionResult Index()
        {
            var soluctionViewModel = Mapper.Map<IEnumerable<Solutions>, IEnumerable<SoluctionViewModel>>(_soluctionapp.GetAll());
            return View(soluctionViewModel);            
        }

        // GET: Soluction/Details/5
        public ActionResult Details(string id)
        {
            var solution = _soluctionapp.GetById(id);
            var solutionViewModel = Mapper.Map<Solutions, SoluctionViewModel>(solution);
            return View(solutionViewModel);
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
                var soluctionDomain = Mapper.Map<SoluctionViewModel, Solutions>(soluction);
                _soluctionapp.Add(soluctionDomain);
                return RedirectToAction("Index");
            }
            return View(soluction);
        }

        // GET: Soluction/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Soluction/Edit/5
        [HttpPost]
        public ActionResult Edit(SoluctionViewModel solution)
        {
            if (ModelState.IsValid)
            {
                var solutionDomain = Mapper.Map<SoluctionViewModel, Solutions>(solution);
                _soluctionapp.Update(solutionDomain);
                return RedirectToAction("Index");
            }
            return View(solution);
        }

        // GET: Soluction/Delete/5
        public ActionResult Delete(string id)
        {
            var solution = _soluctionapp.GetById(id);
            var solutionViewModel = Mapper.Map<Solutions, SoluctionViewModel>(solution);
            return View(solutionViewModel);
        }

        // POST: Soluction/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(string id)
        {
            var solution = _soluctionapp.GetById(id);
            _soluctionapp.Remove(solution);
            return RedirectToAction("Index");
        }
    }
}
