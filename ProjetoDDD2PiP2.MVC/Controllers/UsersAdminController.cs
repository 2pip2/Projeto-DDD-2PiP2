using Portal.Infra.CrossCutting.Identity.Configuration;
using ProjetoDDD2PiP2.MVC.Filters;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjetoDDD2PiP2.MVC.Controllers
{
    [ClaimsAuthorize("AdmUsers", "True")]
    public class UsersAdminController : Controller
    {
        private readonly ApplicationRoleManager _roleManager;
        private ApplicationUserManager _userManager;

        public UsersAdminController(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<ActionResult> Index()
        {
            return View(await _userManager.Users.ToListAsync());
        }
    }
}