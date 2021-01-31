using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstrack;
using DataAccess.Abstrack;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
           return  _ProductDal.GetAll();
        }
    }
}
