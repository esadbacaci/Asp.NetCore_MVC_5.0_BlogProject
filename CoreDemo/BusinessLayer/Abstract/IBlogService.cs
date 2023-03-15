using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService:IGenericService<Blog>
	{
		//yarım kaldı
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListByWriter(int id);//by değil with di sonradan değişmiş galiba bir şey denedin
	}
}
