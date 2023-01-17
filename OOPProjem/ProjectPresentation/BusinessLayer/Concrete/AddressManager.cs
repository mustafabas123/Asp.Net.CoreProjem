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
    public class AddressManager : IAddressService
    {
        private readonly IAddressDAL _addressDAL;
        public AddressManager(IAddressDAL addressDAL)
        {
            _addressDAL= addressDAL;
        }

        public void Delete(Address t)
        {
            _addressDAL.Delete(t);
        }

        public List<Address> GetAll()
        {
            return _addressDAL.GetAll();
        }

        public Address GetById(int id)
        {
            return _addressDAL.GetById(id);
        }

        public void Insert(Address t)
        {
            _addressDAL.Insert(t);
        }

        public void Update(Address t)
        {
           _addressDAL.Update(t);
        }
    }
}
