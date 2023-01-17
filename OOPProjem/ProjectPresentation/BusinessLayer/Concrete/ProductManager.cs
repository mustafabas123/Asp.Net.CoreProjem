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
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL= productDAL;
        }
        public void Delete(Product t)
        {
            _productDAL.Delete(t);
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public void Insert(Product t)
        {
            _productDAL.Insert(t);
        }

        public void Update(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
