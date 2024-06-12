using Microsoft.AspNetCore.Mvc;

namespace MyAccountant.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
