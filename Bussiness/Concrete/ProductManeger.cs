using Bussiness.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class ProductManeger : IProductService
    {
        IProductDal _productDal;
        private EfProductDal efProductDal;

        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductManeger(EfProductDal efProductDal)
        {
            this.efProductDal = efProductDal;
        }

        public bool ProductName { get; set; }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
