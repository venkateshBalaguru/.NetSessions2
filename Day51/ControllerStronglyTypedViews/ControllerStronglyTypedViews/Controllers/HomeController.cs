using Microsoft.AspNetCore.Mvc;

namespace ControllerStronglyTypedViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
