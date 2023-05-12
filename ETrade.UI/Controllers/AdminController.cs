using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
