using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());

        ReservationManager rm = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = rm.GetListReservationByAccepted(values.Id);
            return View(valueList);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = rm.GetListReservationByPrevious(values.Id);
            return View(valueList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = rm.GetListReservationByWaitApproval(values.Id);
            return View(valueList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in dm.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()

                                           }).ToList();
            ViewBag.Values = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1;
            p.Status = "Onay Bekliyor";
            rm.TAdd(p);
            return RedirectToAction("NewReservation");    
        }
    }
}
