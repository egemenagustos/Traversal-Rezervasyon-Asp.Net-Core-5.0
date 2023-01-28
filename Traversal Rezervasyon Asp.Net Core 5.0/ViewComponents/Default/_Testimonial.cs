using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = tm.GetAll();
            return View(values);
        }
    }
}
