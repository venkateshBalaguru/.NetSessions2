using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using SimpleFormApp.DTos;

namespace SimpleFormApp.Controllers
{
    public class CustomerV2Controller : Controller
    {
            public IActionResult Register()
            {
                //dto is also known as ViewModel
                var dto = new RegistrationDTO();
                dto.FirstName = "Testfirstname";
                dto.LastName = "TestLastName";

                return View(dto);
            }

            [HttpPost]
            public IActionResult Register(RegistrationDTO dto)
            {
                //dto is also known as ViewModel
                //validation dto object

                return View(dto);
            }
        }
    }