using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
    
        public IActionResult Index()
        {
            Context c = new Context();

            ViewBag.v1=c.Blogs.Count().ToString();
            ViewBag.v2=c.Comments.Count().ToString();
            ViewBag.v3 = c.Categories.Count();
            ViewBag.v4=c.Contacts.Count().ToString();
            ViewBag.v5=c.NewsLetters.Count().ToString();
            ViewBag.v6=c.Writers.Count().ToString();

            //ViewBag.v2 = c.Blogs.Where(x=>x.WriterID==1).Count();//?
          
            return View();
        }
    }
}
