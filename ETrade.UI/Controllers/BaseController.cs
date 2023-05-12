using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class BaseController : Controller
    {
        public  readonly IUow uow;

        public BaseController(IUow uow)
        {
            this.uow = uow;
        }
    }
}
