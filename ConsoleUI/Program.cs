using Bussiness.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger product = new ProductManeger(new InMemoryProductDal());
            Console.WriteLine(product.ProductName);
        }
    }
}
