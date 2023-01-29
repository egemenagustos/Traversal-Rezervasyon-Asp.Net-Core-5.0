using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
