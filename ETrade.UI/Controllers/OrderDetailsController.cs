using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrderDetailsController : BaseController
    {
        public OrderDetailsController(IUow uow) : base(uow)
        {
        }

        public IActionResult List(Guid Id)
        {
            return View();
        }
    }
}
