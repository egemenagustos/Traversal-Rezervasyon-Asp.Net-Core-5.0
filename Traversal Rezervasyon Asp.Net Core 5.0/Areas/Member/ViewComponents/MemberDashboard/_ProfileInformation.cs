using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Member.ViewComponents.MemberDashboard
{
    public class _ProfileInformation : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
