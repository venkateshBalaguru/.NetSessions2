using ControllerStronglyTypedViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerStronglyTypedViews.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerDetails()
        {
            var customers = new List<CustomerDetails>
            {
                new CustomerDetails{
                Id = 1,
                Name = "Venkat",
                Email = "venkat@gmail.com",
                Phone = "9999999",
                Addresses = new List<CustomerAddress>
                {
                    new CustomerAddress{Address1="South",Address2="Madurai",Pincode="625001",ID=1},
                    new CustomerAddress {Address1="North",Address2="Chennai",Pincode="625001",ID=2}
                }},
                new CustomerDetails{
                Id = 2,
                Name = "Bala",
                Email = "venkat@gmail.com",
                Phone = "9999999",
                Addresses = new List<CustomerAddress>
                {
                    new CustomerAddress{Address1="South",Address2="Madurai",Pincode="625001",ID=1},
                    new CustomerAddress {Address1="North",Address2="Chennai",Pincode="625001",ID=2}
                }}

             };
            return View(customers);
        }
    }
}