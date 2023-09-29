using Data.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace TechOilFrontEnd.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Ingresar(LoginDTO login)
        {
            return View("~/Views/Home/Index.cshtml");
        }


    }
}
