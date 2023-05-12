using ETrade.Ent;
using ETrade.UI.Session;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETrade.UI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly Users user;

        public AuthController(IUow uow, Users user) : base(uow)
        {
            this.user = user;
        }

        public IActionResult Register()
        {

            return View(user);
        }
        [HttpPost]
        public IActionResult Register(Users u)
        {
            uow.usersRepos.Register(u);
            uow.Commit();
            //   
            //  u  = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");


            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {

            return View(user);
        }
        [HttpPost]
        public IActionResult Login(Users u)
        {
            var loginuser = uow.usersRepos.Login(u);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", loginuser);
            Data.LoginUser = loginuser;
            if (Data.LoginUser.isAdmin == true)
            {
                return RedirectToAction("Admin", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }



        }
    }
}
