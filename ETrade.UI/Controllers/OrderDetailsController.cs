using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrderDetails : BaseController
    {
        public IActionResult List(Guid Id)
        {
            return View();
        }
    }
}
