﻿using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfProductDal
    {
        public class EfProductDal : IProductDal
        {
            public void Add(Product product)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product product)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAllByCategory(int categoryId)
            {
                throw new NotImplementedException();
            }

            public void Update(Product product)
            {
                throw new NotImplementedException();
            }
        }
    }
}