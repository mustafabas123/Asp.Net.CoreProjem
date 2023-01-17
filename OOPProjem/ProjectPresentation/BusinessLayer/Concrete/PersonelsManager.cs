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
    public class PersonelsManager : IPersonesService
    {
        private readonly IPersonelsDAL _personelsDAL;
        public PersonelsManager(IPersonelsDAL personelsDAL)
        {
            _personelsDAL = personelsDAL;
        }

        public void Delete(Personels t)
        {
            _personelsDAL.Delete(t);
        }

        public List<Personels> GetAll()
        {
           return _personelsDAL.GetAll();
        }

        public Personels GetById(int id)
        {
            return _personelsDAL.GetById(id);
        }

        public void Insert(Personels t)
        {
            
            _personelsDAL.Insert(t);
        }

        public void Update(Personels t)
        {
            _personelsDAL.Update(t);
        }
    }
}
