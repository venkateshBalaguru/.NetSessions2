﻿using Microsoft.AspNetCore.Mvc;

namespace LoginValidationAttributesApp.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
