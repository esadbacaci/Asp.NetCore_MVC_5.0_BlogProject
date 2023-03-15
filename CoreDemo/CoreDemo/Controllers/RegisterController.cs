using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]

    public class RegisterController : Controller
	{
		WriterManager wm=new WriterManager(new EFWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index (Writer p)
		{
			WriterValidator wv=new WriterValidator();
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme Test";//???
				wm.TAdd(p);
				Thread.Sleep(5000);
                return RedirectToAction("Index", "Blog");//registera tıklandıktan sonra gideceği yer
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}

			}
			return View();
			
		}
	}
}
