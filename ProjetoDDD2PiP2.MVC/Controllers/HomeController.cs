using System;
using System.Web.Mvc;

namespace ProjetoDDD2PiP2.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Redirecionamento()
        {
            Response.Redirect(new Uri(Request.Url, Url.Action("Index", "Home")).ToString());
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Solution()
        {
            ViewBag.Message = "Soluções";

            return View();
        }
    }
}