using Microsoft.AspNetCore.Mvc;

namespace SimpleFormApp.Controllers
{
    public class CustomerV2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
