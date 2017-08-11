using System.Web;
using System.Web.Mvc;

namespace ProjetoDDD2PiP2.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
