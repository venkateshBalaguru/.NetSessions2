using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("<h1>Hello this is Index Content</h1>"); 
        }
        public IActionResult Nature()
        {
            return File("/images/nature.jpg","image/jpg");
        }
        public IActionResult About(string myid = "101") //we setting the id as default no.101 we can change the number in the url
        {

            return Content($"<h1>Id you passed is  {myid} ,getting details</h1>", "text/html");

        }

        public IActionResult Greet(string userName = "sachin")
        {

            return Content($"<h1> Welcome back {userName} !!!</h1>", "text/html");

        }

        public IActionResult Payment()
        {

            return Redirect("https://rrd.com");

        }

        public IActionResult Random()
        {
            var random = new Random();
            var result = random.Next(1, 10);
            if (result %2 == 0)
                return RedirectToAction("About");

            return RedirectToAction("Greet");
        }


    }
}
