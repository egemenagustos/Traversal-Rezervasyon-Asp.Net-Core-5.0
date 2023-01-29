using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetAll();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetById(id);
            _appUserService.TRemove(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var values = _appUserService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.GetAll();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListReservationByAccepted(id);
            return View(values);
        }
    }
}
