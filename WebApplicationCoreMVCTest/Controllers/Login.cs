using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCoreMVCTest.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login_Index()
        {
            return View();
        }
    }
}
