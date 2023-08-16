using Microsoft.AspNetCore.Mvc;

namespace PIX.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
