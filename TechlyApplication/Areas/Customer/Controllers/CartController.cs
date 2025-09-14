using Microsoft.AspNetCore.Mvc;

namespace Techly.Presentation.Areas.Customer.Controllers
{
        [Area("customer")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
