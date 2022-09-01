using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetById(Product product);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
