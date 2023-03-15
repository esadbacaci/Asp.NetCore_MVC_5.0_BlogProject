using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    [AllowAnonymous]

    public class Statistic2:ViewComponent

    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
       
          ViewBag.v1 = c.Blogs.OrderByDescending(x=>x.BlogID)
                .Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
          ViewBag.v3 = c.NewsLetters.Count();
            return View();
        }
    }
}
