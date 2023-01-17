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
    public class NewsManager : INewsService
    {
        private readonly INewsDAL _newsDAL;

        public NewsManager(INewsDAL newsDAL)
        {
            _newsDAL = newsDAL;
        }

        public void Delete(News t)
        {
            
            _newsDAL.Delete(t);
        }

        public List<News> GetAll()
        {
            return _newsDAL.GetAll();
        }

        public News GetById(int id)
        {
            return _newsDAL.GetById(id);
        }

        public void Insert(News t)
        {
            _newsDAL.Insert(t);
        }

        public void NewsStatusToFalse(int id)
        {
            _newsDAL.NewsStatusToFalse(id);
        }

        public void NewsStatusToTrue(int id)
        {
            _newsDAL.NewsStatusToTrue(id);
        }

        public void Update(News t)
        {
            _newsDAL.Update(t);
        }
    }
}
