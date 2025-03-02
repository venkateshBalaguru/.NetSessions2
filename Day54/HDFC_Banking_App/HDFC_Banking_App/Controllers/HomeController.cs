using Microsoft.AspNetCore.Mvc;

namespace HDFC_Banking_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
