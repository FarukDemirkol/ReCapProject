using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                System.Console.WriteLine(product.CarId + " " + product.Description + "\t\t" + product.ModelYear + "\t" + product.DailyPrice);
            }
            
            
            
            System.Console.WriteLine("----------------------------------");
            InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            inMemoryProductDal.Add(new Product { BrandId = 4, CarId = 6, ColorId = 2, DailyPrice = 800, ModelYear = "2017", Description = "Honda Civic", });
            inMemoryProductDal.Add(new Product { BrandId = 1, CarId = 7, ColorId = 1, DailyPrice = 1700, ModelYear = "2019", Description = "Bmw m7", });



            System.Console.WriteLine("----------------------------------");
            foreach (var product in inMemoryProductDal.GetAll())
            {
                System.Console.WriteLine(product.CarId + " " + product.Description + "\t\t" + product.ModelYear + "\t" + product.DailyPrice + " tl");
            }
        }
    }
}