using Microsoft.AspNetCore.Mvc;
using ViewBagExercise.Models;

namespace ViewBagExercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult UserName(string userName = "Venkat")
        {
            MasterUser userMaster = new MasterUser();
            AppUser appUser = userMaster.GetUser(userName);
            ViewBag.AppUser = appUser;
            ViewBag.Header = "User Detail";
            return View();
        }
    }
}