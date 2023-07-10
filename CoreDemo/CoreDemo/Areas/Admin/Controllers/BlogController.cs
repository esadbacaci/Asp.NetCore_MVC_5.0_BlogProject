using BusinessLayer.Concrete;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
  
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class BlogController : Controller
    {

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("BlogListesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformatas-officedocument.spreadsheethtml.sheet", "BlogList.xlsx");
                }
            }
        }
        public  List<BlogModel2>BlogTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using (var c = new Context())
            {
                bm=c.Blogs.Select(x=>new BlogModel2
                {
                    ID=x.BlogID,
                    BlogName=x.BlogTitle

                }).ToList();
            }
            return bm;
        }
        public  IActionResult BlogTitleListExcel()
        {
            return View();  
        }

        BlogManager bm = new BlogManager(new EFBlogRepository());

        public IActionResult Index(int page = 1)
		{
			var values = bm.GetList().OrderByDescending(x => x.BlogID).ToPagedList(page, 2);
			return View(values);
		}
		public IActionResult DeleteBlog(int id)
		{
			var value = bm.TGetById(id);
			bm.TDelete(value);
			return RedirectToAction("Index");
		}
     
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                Context context = new Context();
                context.Blogs.Add(blog);
                context.SaveChanges();
                return RedirectToAction("Index", "Widget");
            }
            return View();
        }



    }
}
