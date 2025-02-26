using Microsoft.AspNetCore.Mvc;
using SimpleFormApp.DTos;

namespace SimpleFormApp.Controllers
{
    public class CustomerV2Controller : Controller
    {
        public IActionResult Register()
        {
            //dto is also know as view model
            var dto = new RegistrationDTO();
            return View();
        }
    }
}
