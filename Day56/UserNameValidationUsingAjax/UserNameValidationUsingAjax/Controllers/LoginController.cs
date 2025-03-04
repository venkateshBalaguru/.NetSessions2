using Microsoft.AspNetCore.Mvc;

namespace UserNameValidationUsingAjax.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
