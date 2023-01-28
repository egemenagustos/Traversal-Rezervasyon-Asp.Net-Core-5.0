using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.TGetDestinationById(id);
            return View(values);
        }
 
   }
}