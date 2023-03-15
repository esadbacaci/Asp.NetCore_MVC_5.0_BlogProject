using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X.PagedList;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        Context c = new Context();
        public IActionResult Index()
        {
			var values = bm.GetBlogListWithCategory();
			var category = cm.GetList();
			var model2 = new EntityLayer.Concrete.Category();
			var viewModel = new MyViewModel
			{
				Blogs = values,
				Category = model2,
                Categories = category
			};
			
            return View(viewModel);
        }
		public IActionResult Home(int page = 1)
		{
			var values = bm.GetBlogListWithCategory().ToPagedList(page,3);
		
			return View(values);
		}
		public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;    
            var values = bm.GetBlogById(id);//getbloglistwithcategories
            return View(values);
        }
        public  IActionResult BlogListByWriter() 
        
        {
      
            var usermail = User.Identity.Name;
            var writerID=c.Writers.Where(x=>x.WriterMail==
            usermail).Select(y=>y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBm(writerID);
            return View(values); 
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
          
            List<SelectListItem> categoryvalues = (from x in cm.GetList()select new SelectListItem{Text = x.CategoryName,Value = x.CategoryID.ToString()}).ToList();
            ViewBag.cv=categoryvalues;
            return View();
        }

        [HttpPost]  
        public IActionResult BlogAdd(Blog p, IFormFile BlogImage)
        {
			if (BlogImage != null && BlogImage.Length > 0)
			{
				// dosya adı ve uzantısı
				var fileName = Path.GetFileName(BlogImage.FileName);
				var fileExtension = Path.GetExtension(fileName);

				// dosya adı değiştirme
				var newFileName = Guid.NewGuid() + fileExtension;

				// dosya kaydedilme yolu
				var location = Directory.GetCurrentDirectory();
				var path = Path.Combine(location, "wwwroot/images/", newFileName);

				// dosyayı kaydetme
				using (var stream = new FileStream(path, FileMode.Create))
				{
					BlogImage.CopyTo(stream);
				}

				// veritabanına kaydetme
				p.BlogImage = "/images/" + newFileName;
			}

			var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail ==usermail).Select(y => y.WriterID).FirstOrDefault();

            BlogValidator bv= new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                //bloğun durumunu false yaparak admine onaylatılabilir
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = writerID;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
			return RedirectToAction("BlogListByWriter", "Blog");		
        
		}




        public IActionResult DeleteBlog(int id)
        {
            var blogvalue=bm.TGetById(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)

        {

            var blogvalue = bm.TGetById(id);
            List<SelectListItem> categoryvalues = (from x in cm.GetList()select new SelectListItem{Text = x.CategoryName,Value = x.CategoryID.ToString()}).ToList();
            ViewBag.cv = categoryvalues;
         
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p,IFormFile BlogImage)
        {
			

			if (BlogImage != null && BlogImage.Length > 0)
			{
				// dosya adı ve uzantısı
				var fileName = Path.GetFileName(BlogImage.FileName);
				var fileExtension = Path.GetExtension(fileName);

				// dosya adı değiştirme
				var newFileName = Guid.NewGuid() + fileExtension;

				// dosya kaydedilme yolu
				var location = Directory.GetCurrentDirectory();
				var path = Path.Combine(location, "wwwroot/images/", newFileName);

				// dosyayı kaydetme
				using (var stream = new FileStream(path, FileMode.Create))
				{
					BlogImage.CopyTo(stream);
				}

				// veritabanına kaydetme
				p.BlogImage = "/images/" + newFileName;
			}

			var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();
            p.WriterID = writerID;
            p.BlogCreateDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }

	}
}
