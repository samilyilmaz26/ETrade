using ETrade.Ent;
using ETrade.UI.Models;
using ETrade.UI.Session;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETrade.UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly Users user;

        public HomeController(ILogger<HomeController> logger, Users user )
		{
			_logger = logger;
            this.user = user;
        }
		public IActionResult Index()
		{

				//Session.SessionHelper.LoginUser   = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
			//Session.SessionHelper.LoginUser = user;
			//if (Session.SessionHelper.LoginUser.isAdmin == true)
			//{
			//	return RedirectToAction("Admin", "Admin");
			//}
            return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}