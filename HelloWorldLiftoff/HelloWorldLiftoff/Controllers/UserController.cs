using HelloWorldLiftoff.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldLiftoff.Controllers
{
    public class UserController : Controller
    {
        /*private readonly TrackingSheetContext context;

        public LoginController(TrackingSheetContext dbContext)
        {
            context = dbContext;
        }
        */

        //[HttpGet]
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            //now to actually code the login stuff...
            LoginViewModel loginViewModel = new LoginViewModel();

            /* 
             okay, i could use a little help. Let me check previous projects...

            i need to check the password, the username, say the password and username reqs
            what i'm coding now is the welcome page.
             */

            //so the models for this app would be the user, the tracking sheets, the folders for the 
            //tracking sheets (?)

            //the controllers are actually named and organized by whatever model they are dealing with


            return View();
        }
    }
}
