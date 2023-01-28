using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager sm = new SubAboutManager(new EfSubAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = sm.GetAll();
            return View(values);
        }
    }
}
