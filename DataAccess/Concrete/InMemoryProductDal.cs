using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { BrandId = 1,CarId = 1,ColorId = 1,DailyPrice = 850,ModelYear = "2005" , Description = "Bmw m3",},
                new Product { BrandId = 1,CarId = 2,ColorId = 1,DailyPrice = 1350,ModelYear = "2012" , Description = "Bmw m5",},
                new Product { BrandId = 2,CarId = 3,ColorId = 3,DailyPrice = 3000,ModelYear = "2010" , Description = "Porsche Cayman",},
                new Product { BrandId = 2,CarId = 4,ColorId = 4,DailyPrice = 2850,ModelYear = "2011" , Description = "Porsche 911",},
                new Product { BrandId = 3,CarId = 5,ColorId = 3,DailyPrice = 500,ModelYear = "2016" , Description = "Siat Ibiza",},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete;
            productToDelete = _products.SingleOrDefault(c => c.CarId == product.CarId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(Product product)
        {
            return _products.Where(c => c.CarId == product.CarId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(c => c.CarId == product.CarId);
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }
    }
}
