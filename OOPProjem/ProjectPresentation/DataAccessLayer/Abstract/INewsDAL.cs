using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INewsDAL:IGenericDAL<News>
    {
        void NewsStatusToTrue(int id);
        void NewsStatusToFalse(int id);
    }
}
