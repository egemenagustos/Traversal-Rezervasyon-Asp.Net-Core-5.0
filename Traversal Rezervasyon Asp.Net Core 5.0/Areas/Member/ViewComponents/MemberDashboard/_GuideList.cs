using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Member.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuidManager gm = new GuidManager(new EfGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = gm.GetAll();
            return View(values);
        }
    }
}
