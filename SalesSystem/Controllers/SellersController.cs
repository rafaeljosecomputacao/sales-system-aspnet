using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
