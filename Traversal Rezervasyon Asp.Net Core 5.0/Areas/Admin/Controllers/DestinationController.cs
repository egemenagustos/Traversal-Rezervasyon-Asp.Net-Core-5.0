using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    public class DestinationController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
