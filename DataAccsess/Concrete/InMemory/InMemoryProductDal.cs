using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        private Product productToDelete;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
               new Product{ProductId=1,CategoryId=1,ProductName="IMAC",UnitPrice=12000,UnitInStock=100},
               new Product{ProductId=2,CategoryId=1,ProductName="IPHONE",UnitPrice=13000,UnitInStock=300},
               new Product{ProductId=3,CategoryId=2,ProductName="WEBCAM",UnitPrice=740,UnitInStock=200},
               new Product{ProductId=4,CategoryId=2,ProductName="GAMİNG KEYBOARD",UnitPrice=750,UnitInStock=400},
               new Product{ProductId=5,CategoryId=2,ProductName="GAMİNG MAUSE",UnitPrice=430,UnitInStock=500}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}

