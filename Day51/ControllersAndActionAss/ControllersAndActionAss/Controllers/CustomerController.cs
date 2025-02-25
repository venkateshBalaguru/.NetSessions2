using ControllersAndActionAss.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Display()
        //{
        //    var c1 = new Customer
        //    {
        //        City = "Chennai",
        //        Id = 1,
        //        Name = "Venkat",
        //    };
        //    return View(c1);
        //}
        public IActionResult Display()
        {
            var customers = new List<Customer>
            {
                new Customer{City="Madurai",Address={"address1" ,"address2"},Id=1,Name="Venkat"},
                new Customer{City="Chennai",Address={"address1" ,"address2","address3"},Id=2,Name="Sachin"},
                new Customer{City="Chennai",Address={"address1" ,"address2"},Id=3,Name="Prem"},

            };

            return View(customers);
        }
        public IActionResult UsesofViewBag()
        {
            ViewBag.Messages = "Hi Welcome to ViewBag";
            ViewBag.UserNames = new List<string> {
                                    "Venkat",
                                    "Sachin",
                                    "Akhilesh",
                                    "Prem"};
            return View();
        }
    }
}
