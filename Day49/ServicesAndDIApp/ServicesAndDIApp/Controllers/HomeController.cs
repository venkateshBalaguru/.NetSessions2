using Microsoft.AspNetCore.Mvc;

namespace ServicesAndDIApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Console.WriteLine("Home controller created");
        }
        public string Index()  //index method is defult we dont want to enter in web address
        {
            return "Hello I am index action of home controller";
        }
        public string SayHello()
        {
            return "Hello";
        }

    }
}
