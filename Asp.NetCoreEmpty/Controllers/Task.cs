using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreEmpty.Controllers
{
    public class Task : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
