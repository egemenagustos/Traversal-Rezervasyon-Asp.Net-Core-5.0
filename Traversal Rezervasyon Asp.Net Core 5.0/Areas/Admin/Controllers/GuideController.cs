using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
	{
		private readonly IGuideService _guideService;

		public GuideController(IGuideService guideService)
		{
			_guideService = guideService;
		}

		public IActionResult Index()
		{
			var values = _guideService.GetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddGuide()
		{
			return View();
		}

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
			GuideValidator gv = new GuideValidator();
			ValidationResult result = gv.Validate(guide);
			if(result.IsValid)
			{
                guide.Status = true;
                _guideService.TAdd(guide);
                return RedirectToAction("Index", "Guide", new { area = "Admin" });
            }
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
			
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
			var values = _guideService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
			guide.Status = true;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

		public IActionResult ChangeToTrue(int id)
		{
			_guideService.TChangeToTrue(id);
            return RedirectToAction("Index", "Guide", new {area = "Admin"});
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalse(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
