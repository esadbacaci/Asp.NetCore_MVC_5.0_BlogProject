using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsletterDal;

		public NewsLetterManager(INewsLetterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}

        public List<NewsLetter> GetList()
        {
          return _newsletterDal.GetListAll();
        }

        public void TAdd(NewsLetter t)
        {
           _newsletterDal.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            _newsletterDal.Delete(t);
        }

        public NewsLetter TGetById(int id)
        {
            return _newsletterDal.GetByID(id);
        }

        public void TUpdate(NewsLetter t)
        {
            _newsletterDal.Update(t); 
        }

        //public void AddNewsLetter(NewsLetter newsletter)
        //{
        //	_newsletterDal.Insert(newsletter);
        //}
    }
	
}
