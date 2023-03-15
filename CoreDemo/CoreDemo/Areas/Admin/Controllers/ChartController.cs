using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass>list=new List<CategoryClass>(); 

            list.Add(new CategoryClass
            { 
                categoryname="Teknoloji",
                categorycount=10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Bilim",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "E-Ticaret",
                categorycount = 5
            });
            return Json(new { jsonlist = list });
        }
    }
}
