using BusinessLayer.Concrete;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreDemo.Controllers
{
    [Authorize(Roles = "Writer")]

    public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());
        [AllowAnonymous]
        [HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
        [AllowAnonymous]
        [HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter p)
		{
			bool isDuplicate = nm.GetList().Any(x => x.Mail == p.Mail && x.MailStatus == true);
			if (isDuplicate)
			{
				// swal kütüphanesini kullanarak hata mesajı göster
				string message = "Bu e-posta adresi zaten kayıtlı.";
				string title = "Hata";
				string icon = "error";
				string script = $"swal('{title}', '{message}', '{icon}');";
				ViewBag.Script = script;
			}
			else
			{
				p.MailStatus = true;
				nm.TAdd(p);
			}
			return PartialView();
		}

        public IActionResult AllSubscribers()
        {
            var values = nm.GetList();
            return View(values);

        }
		public IActionResult DeleteNewsLetter(int id)
		{
			var newslettervalue = nm.TGetById(id);
			nm.TDelete(newslettervalue);
			return RedirectToAction("AllSubscribers");

		}
		
	}
}
