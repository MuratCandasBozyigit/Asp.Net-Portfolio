using Microsoft.AspNetCore.Mvc;

namespace PortfolioAsp.Net.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
