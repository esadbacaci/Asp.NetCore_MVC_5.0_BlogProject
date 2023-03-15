using Microsoft.AspNetCore.Mvc;
using CoreDemo.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccessLayer.EntityFramework;
using BusinessLayer.Concrete;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = cm.GetList(id);
			return View(values);	
		}

	}
}
