using Microsoft.AspNetCore.Mvc;

namespace RegistrationFormValidationUsingJQuery.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(string username, string pass)
        //{

        //    if (username == null || pass == null)
        //    {
        //        ViewBag.Message = "Registration Failed..All fields required";  //server side validation
        //    }
        //    else
        //    {
        //        ViewBag.Message = $"Hi {username}!.. Registration Sucessfull, Soon we will get back to you";
        //    }
        //    return View();
        //}
    }

}
