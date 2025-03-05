using Microsoft.AspNetCore.Mvc;

namespace TagHelpersAndSessionApp.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            const string COUNTER = "counter";
            //null means first time visit to server
            if (HttpContext.Session.GetInt32(COUNTER) == null)
            {
                HttpContext.Session.SetInt32(COUNTER, 0);
            }
                int newcounter = (int)(HttpContext.Session.GetInt32(COUNTER))+1;
                HttpContext.Session.SetInt32(COUNTER, newcounter);
            
            return View();
        }
    }
}
