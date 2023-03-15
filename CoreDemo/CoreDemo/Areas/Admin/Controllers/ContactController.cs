using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
       
       
            ContactManager cm = new ContactManager(new EFContactRepository());
            public IActionResult Index(int page = 1)
            {
                var values = cm.GetList().ToPagedList(page, 10);
                return View(values);
            }

            [HttpGet]
            public IActionResult AddContact()
            {
                return View();
            }
            public IActionResult ContactDelete(int id)
            {
                var value = cm.TGetById(id);
                cm.TDelete(value);
                return RedirectToAction("Index");
            }
        
    }
}
