using Azure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Azure.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult ImagesView()
        {
            return View();
        }
        public IActionResult ImagesViewTo()
        {
            return View();
        }
        public IActionResult ImagesRobot()
        {
            return View();
        }
    }
}