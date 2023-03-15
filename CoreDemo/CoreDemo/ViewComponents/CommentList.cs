using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					Username="Esad"
				},
				new UserComment
				{
					ID= 2,
					Username="Bacacı"
				},

			};

			return View(commentvalues);
		}
	}
}
