using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.Models;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index sayfası çağırıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d = DateTime.Parse(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d + "Privacy sayfası çağırıldı");
            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfası çağırıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
