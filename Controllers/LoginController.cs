using Data.Base;
using Data.DTOs;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text.Json;

namespace TechOilFrontEnd.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public LoginController(IHttpClientFactory httpClient) 
        {
            _httpClient = httpClient;
        }
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Ingresar(LoginDTO login)
        {
            var baseApi = new BaseApi(_httpClient);
            var token = await baseApi.PostToApi("Login", login);
            var resultadoLogin = token as OkObjectResult;
            var resultadoObjeto = JsonConvert.DeserializeObject<Models.Login>(resultadoLogin.Value.ToString());

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);



            return View("~/Views/Home/Index.cshtml", resultadoObjeto);
        }


    }
}
