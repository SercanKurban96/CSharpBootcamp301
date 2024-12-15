using CSharpBootcamp301.DataAccessLayer.Abstract;
using CSharpBootcamp301.DataAccessLayer.Context;
using CSharpBootcamp301.DataAccessLayer.Repositories;
using CSharpBootcamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products
                .Select(x => new
            {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
            }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
