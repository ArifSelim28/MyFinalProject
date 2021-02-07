using Bussiness.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManeger categoryManeger = new CategoryManeger(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManeger productManeger = new ProductManeger(new InMemoryProductDal());
            foreach (var product in productManeger.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
