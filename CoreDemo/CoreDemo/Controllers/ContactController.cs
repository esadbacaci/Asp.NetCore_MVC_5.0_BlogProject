using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace CoreDemo.Controllers
{


    public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EFContactRepository());
        [AllowAnonymous]
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

        [AllowAnonymous]
        [HttpPost]
		public IActionResult Index(Contact p)
		{
			p.ContactDate=DateTime.Now;
			p.ContectStatus = true;
			cm.TAdd(p);
		
			return RedirectToAction("Index","Blog");
		}

        [Authorize(Roles = "Writer")]

        public IActionResult ContactMessages()
        {
            var values = cm.GetList();
            return View(values);

        }

        [HttpGet]
        public IActionResult ContactMessagesDetails(int id)
        {
            var values = cm.TGetById(id);
            return View(values);

        }

    }
}
