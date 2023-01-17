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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;
        public ServiceManager(IServiceDAL serviceDAL) 
        {
            _serviceDAL = serviceDAL;
        }
        public void Delete(Service t)
        {
            _serviceDAL.Delete(t);
        }

        public List<Service> GetAll()
        {
            return _serviceDAL.GetAll();
        }

        public Service GetById(int id)
        {
            return _serviceDAL.GetById(id);
        }

        public void Insert(Service t)
        {
            _serviceDAL.Insert(t);
        }

        public void Update(Service t)
        {
            _serviceDAL.Update(t);
        }
    }
}
