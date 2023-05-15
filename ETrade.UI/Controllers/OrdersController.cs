using ETrade.Ent;
using ETrade.UI.Session;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly Orders orders;

        public OrdersController(IUow uow ,Orders orders) : base(uow)
        {
            this.orders = orders;
        }

        public IActionResult List()
        {
            Data.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            return View(uow.ordersRepos.GetOrders(Data.LoginUser.UserId));
        }
        public IActionResult New ()
        {

            orders.isDelivered = false;
            orders.CreatedDate = DateTime.Now;
            orders.TotalPrice = 0;
            orders.LastUpdated = DateTime.Now;
            Data.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            orders.UserId = Data.LoginUser.UserId;
            orders.ShippingAddress = Data.LoginUser.ShipAddress;
            uow.ordersRepos.Add(orders);
            uow.Commit();
            return  RedirectToAction("List", "OrderDetails", new {Id = orders.OrderId});
        }
    }
}
