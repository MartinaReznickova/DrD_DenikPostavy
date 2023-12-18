using DrD_DenikPostavy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DrD_DenikPostavy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginClick()
        {
            
            return View("~/Views/Account/Login.cshtml");
        }

        public IActionResult SignInClick()
        {
            return View("~/Views/Account/Register.cshtml");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
