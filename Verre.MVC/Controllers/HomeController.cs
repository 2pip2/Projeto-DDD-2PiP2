using System.Web.Mvc;
using Verre.MVC.Filters;
using System.Security.Claims;

namespace Verre.MVC.Controllers
{
    [Authorize]    
    public class HomeController : Controller
    {
       [ClaimsAuthorize("Empresa","2pip2")]

        public ActionResult Index()
        {   
            return View();
        }
        

    }
}