using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin", AuthenticationSchemes = "AdminScheme")]
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EFAboutRepository());
        public IActionResult AboutAdd(int id)
        {
            var value = am.TGetById(id);
            am.TAdd(value);
            return RedirectToAction("Admin");
        }
           
        
    }
}
