using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List","Task"); 
        }
    }
}
