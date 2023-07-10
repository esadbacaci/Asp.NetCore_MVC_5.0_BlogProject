using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
  
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class WriterController : Controller
    {
      
        WriterManager cm = new WriterManager(new EFWriterRepository());
        
        public IActionResult Index(int page = 1)
		{
			var values = cm.GetList().ToPagedList(page, 8);
			return View(values);
		}
		public IActionResult WriterDelete(int id)
		{
			var value = cm.TGetById(id);
			cm.TDelete(value);
			return RedirectToAction("Index");
		}
     
        [HttpGet]
        public IActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(Writer writer)
        {
            if (ModelState.IsValid)
            {
                Context context = new Context();
                context.Writers.Add(writer);
                context.SaveChanges();
                return RedirectToAction("Index", "Widget");
            }
            return View();
        }



    }
}

//      public IActionResult WriterList()
//      {
//          var jsonWriters = JsonConvert.SerializeObject(writers);
//          return Json(jsonWriters);
//      }

//      public IActionResult GetWriterByID(int writerid)
//      {
//          var findWriter=writers.FirstOrDefault(x=>x.ID== writerid);
//          var jsonWriters=JsonConvert.SerializeObject(findWriter);
//          return Json(jsonWriters);    
//      }

//[HttpPost]
//public IActionResult AddWriter(WriterClass w)
//{
//	writers.Add(w);
//	var jsonWriters = JsonConvert.SerializeObject(w);
//	return Json(jsonWriters);

//}
//      public IActionResult DeleteWriter(int id)
//      {
//          var writer = writers.FirstOrDefault(x => x.ID == id);
//          writers.Remove(writer);
//          return Json(writer);

//      }
//        public IActionResult UpdateWriter(WriterClass w)
//      {
//          var writer = writers.FirstOrDefault(x => x.ID == w.ID);
//          writer.Name=w.Name;
//          var jsonWriter=JsonConvert.SerializeObject(w);
//          return Json(jsonWriter);

//      }

//public static List<WriterClass> writers = new List<WriterClass>
//      {
//          new WriterClass()
//          {
//              ID= 1,
//              Name="Ayşe",

//          },
//          new WriterClass()
//          {
//              ID= 2,
//              Name="Mehmet",

//          }
//      };