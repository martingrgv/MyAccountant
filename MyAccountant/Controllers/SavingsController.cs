using Microsoft.AspNetCore.Mvc;

namespace MyAccountant.Controllers
{
    public class SavingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
