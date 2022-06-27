using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal product)
        {
            _productDal = product;
        }
       
        public List<Product> GetAll()
        {
            //İş kodları
            //Geldik Fasulyenin Faydalarına
        
            return _productDal.GetAll();
        }
    }
}
