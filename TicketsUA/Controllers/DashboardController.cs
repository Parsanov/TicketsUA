using Microsoft.AspNetCore.Mvc;

namespace TicketsUA.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
