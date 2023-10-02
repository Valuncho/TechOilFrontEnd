using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TechOilFrontEnd.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        public IActionResult Usuarios()
        {
            return View();
        }
    }
}
