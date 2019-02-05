using HelloWorldLiftoff.Data;
using HelloWorldLiftoff.Models;
using HelloWorldLiftoff.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        //[HttpGet]
        public IActionResult Index()
        {


            /*LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);*/

            //so the models for this app would be the user, the tracking sheets, the folders for the 
            //tracking sheets (?), the actual accounts of users

            //the controllers are actually named and organized by whatever model they are about

            return View();
  
        }

        //[HttpGet]
        //public IActionResult Index(AccountViewModel avm)
        
        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            AccountModel am = new AccountModel();

            /*if ((string.IsNullOrEmpty(loginViewModel.Username) && string.IsNullOrEmpty(loginViewModel.Password))
                || (!string.IsNullOrEmpty(loginViewModel.Username) && string.IsNullOrEmpty(loginViewModel.Password)
                || (string.IsNullOrEmpty(loginViewModel.Username) && (!string.IsNullOrEmpty(loginViewModel.Password)))))*/

            /*if (string.IsNullOrEmpty(avm.Account.username) || string.IsNullOrEmpty(avm.Account.password)
                || am.login(avm.Account.username, avm.Account.password) == null)*/

            if (string.IsNullOrEmpty(loginViewModel.Username) || string.IsNullOrEmpty(loginViewModel.Password)
                || am.login(loginViewModel.Username, loginViewModel.Password) == null)
            {
                return View(loginViewModel);

                //using ViewBag just for now...
                //ViewBag.Error = "Account isn't valid";
                //return View("Index");
            }

          

            //if user logged in correctly
            if (ModelState.IsValid)
            {
                User loggedInUser = new User
                {
                    username = loginViewModel.Username,
                    password = loginViewModel.Password
                    
                };

                return Redirect("/User/UserHomePage/" + loggedInUser.UserID);
            }

            
            return View(loginViewModel);
            
            //the error messages are supposed to show when user doesn't log in correctly
           
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
                    areaCode = createAccountViewModel.areaCode,
                    sourceCode = createAccountViewModel.sourceCode,
                    trackingSheets = new List<TrackingSheet>()
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
        public IActionResult UserHomePage(User loggedInUser)
        {
            return View(loggedInUser);
        }
    }
}
