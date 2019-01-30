using HelloWorldLiftoff.Data;
using HelloWorldLiftoff.Models;
using HelloWorldLiftoff.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldLiftoff.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext context;

        public UserController(UserDbContext dbContext)
        {
            context = dbContext;
        }
        

  
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

        public IActionResult CreateAccount()
        {
            CreateAccountViewModel createAccountViewModel = new CreateAccountViewModel();

            return View();
        }

        //this is for actually processing the new user and his/her account
        [HttpGet]
        public IActionResult CreateAccount(CreateAccountViewModel createAccountViewModel)
        {
            //int zipcode = context.Zipcodes.Single(z => ....
            //I'm gonna need to know how exactly to fetch the zipcode here

            //hey, i know! i'll see examples of other LC101 students' previous liftoff projects and then that might help!

            if (ModelState.IsValid)
            {
                //create new user who just signed up
                User newUser = new User
                {
                    username = createAccountViewModel.Username,
                    password = createAccountViewModel.Password,
                    areaCode = createAccountViewModel.areaCode
                };

                //save to the database, when it exists
                context.Users.Add(newUser);
                context.SaveChanges();

                //return Redirect("/Dashboard");
                return Redirect("/User/AccountConfirmation"); //this is just for now, while this part is still in development
                
            }

            return View(createAccountViewModel);
        }

        //this is for login confirmation
        //[HttpPost]
        public IActionResult AccountConfirmation()
        {
            return View();
        }

        //this is for user page when user first logs in or registers
        public IActionResult UserHomePage()
        {
            return View();
        }
    }
}
