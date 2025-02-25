using System.Security.Principal;
using ControllersAndActionAss.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionAss.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Transaction()
        {
            var customers = new List<CustomerTransaction>();
            customers.Add(new CustomerTransaction(1, "venkat", "Mdu",50000));
            customers.Add(new CustomerTransaction(2, "Sachin", "Mdu", 50000));
            customers.Add(new CustomerTransaction(3, "Prem", "Mdu", 50000));
            customers.Add(new CustomerTransaction(4, "Akhil", "Mdu", 50000));


            return View(customers);
        }
    }
}
