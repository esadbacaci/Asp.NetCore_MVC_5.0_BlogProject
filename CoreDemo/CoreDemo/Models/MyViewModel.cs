using EntityLayer.Concrete;
using System.Collections.Generic;
using System;

namespace CoreDemo.Models
{
	public class MyViewModel
	{
		public IEnumerable<Blog> Blogs { get; set; }
		public Category Category { get; set; }
		public IEnumerable<Category> Categories { get; set; }
	}
}
