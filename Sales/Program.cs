using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller e1 = new Seller();
            e1.Name = "Juan";
            e1.Age = 25;

            Product product1 = new Product();
            product1.Name = "Iphone";
            product1.Price = 1000000d;

            Product product2 = new Product();
            product2.Name = "Samsung";
            product2.Price = 500000d;

            Product product3 = new Product();
            product3.Name = "Huawei";
            product3.Price = 250000d;

           

            Sale V1 = new Sale();
            V1.Product = product1;
            V1.Seller = e1;
            V1.Comments = "New client";

            Sale V2 = new Sale();
            V2.Product = product2;
            V2.Seller = e1;
            V2.Comments = "Regular client";

            Sale V3 = new Sale();
            V3.Product = product3;
            V3.Seller = e1;
            V3.Comments = "New client";

           
            double  count = V1.Product.Price + V2.Product.Price + V3.Product.Price;

            System.Console.WriteLine("Sales total amount: " + count );








        }
    }
}
