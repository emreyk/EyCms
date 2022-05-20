using AutoMapper;
using EyCms.CORE.DTOs;
using EyCms.CORE.Models;
using EyCms.CORE.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EyCms.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IService<User> _service;
      
        public LoginController(IService<User> service)
        {
            _service = service;
           
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> Login(LoginDto model)
        {
            var user = await _service.AnyAsync(x => x.Name == model.Name && x.Password == model.Password);
            if (user  == true)
            {
                var claims = new List<Claim>
                {
                  new Claim(ClaimTypes.Name, model.Name),
                  new Claim(ClaimTypes.Role, "Admin"),
                };

                var claimsIdentity = new ClaimsIdentity(
                     claims, CookieAuthenticationDefaults.AuthenticationScheme);


                await HttpContext.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      new ClaimsPrincipal(claimsIdentity));

                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
    }
}
