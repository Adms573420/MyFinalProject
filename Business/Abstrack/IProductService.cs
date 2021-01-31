using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
