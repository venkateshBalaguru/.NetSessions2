using Microsoft.AspNetCore.Mvc;

namespace HDFC_Banking_App.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
