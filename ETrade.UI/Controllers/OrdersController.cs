using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrdersController : BaseController
    {
        public OrdersController(IUow uow) : base(uow)
        {
        }

        public IActionResult List()
        {
            return View(uow.ordersRepos.List());
        }
    }
}
