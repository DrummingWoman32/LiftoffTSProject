using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HelloWorldLiftoff.ViewModels;
using HelloWorldLiftoff.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace HelloWorldLiftoff.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountViewModel avm)
        {
            AccountModel am = new AccountModel();
            if(string.IsNullOrEmpty(avm.Account.username) || string.IsNullOrEmpty(avm.Account.password) 
                || am.login(avm.Account.username, avm.Account.password) == null)
            {
                //using ViewBag just for now...
                ViewBag.Error = "Account isn't valid";
                return View("Index");
            }
            return View("/User/UserHomePage/");
        }
    }
}
