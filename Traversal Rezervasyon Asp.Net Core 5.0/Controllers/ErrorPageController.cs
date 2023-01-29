using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
