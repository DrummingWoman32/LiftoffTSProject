using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldLiftoff.Controllers
{
    public class HelloLiftoffController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
