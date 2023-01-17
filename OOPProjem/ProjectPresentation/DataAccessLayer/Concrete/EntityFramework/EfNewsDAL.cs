using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfNewsDAL : GenericRepository<News>, INewsDAL
    {
        public void NewsStatusToFalse(int id)
        {
            using var context = new ProjeContext();//haberlerin durumnu false yapma komutu
            News value= context.News.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void NewsStatusToTrue(int id)
        {
            using var context = new ProjeContext();//haberlerin komutunu true yapma komutu
            News value=context.News.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
