using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetByUnitPrice(40,100))  //Fiyatı 40 ile 100 arasında olanları filtreler.
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var product in productManager.GetAllByCategoryId(2))  //CategoryId'si 2 olan ürünleri listeler.
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var product in productManager.GetAll())  //Bütün ürünleri listeler.
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
