using EyCms.CORE.Models;
using EyCms.CORE.Repositories;
using EyCms.CORE.Services;
using EyCms.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EyCms.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<Slider> _service;
        //private readonly IServiceRepository;

        public HomeController(IService<Slider> service)
        {
            _service = service;

        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    var test = _service.GetAllAsync();
        //    _logger = logger;
        //}

        public async Task<IActionResult> Index()
        {
            var test =await  _service.GetAllAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}