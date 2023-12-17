using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
