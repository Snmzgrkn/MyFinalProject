using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnıtsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnıtsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Bilgisayar",UnitPrice=3000,UnıtsInStock=2},
                new Product{ProductId=4,CategoryId=1,ProductName="Telefon",UnitPrice=8000,UnıtsInStock=6}
             };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); 
            _products.Remove(productToDelete);

             

        }

        public List<Product> GetAll()
        {
           return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p => p.CategoryId == categoryId).ToList(); //Where içindeki şarta uyan bütün elemanları yeni bir liste haline getirip onu döndürür

        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnıtsInStock = product.UnıtsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
