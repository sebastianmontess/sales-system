using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
           Total total = new Total();

            //sellers
            Seller e1 = new Seller();
            e1.Name = "Juan";
            e1.Age = 25;
            total.AddSeller(e1);

            Seller e2 = new Seller();
            e1.Name = "Sebastian";
            e1.Age = 35;
            total.AddSeller(e2);

            Seller e3 = new Seller();
            e1.Name = "Daniela";
            e1.Age = 20;
            total.AddSeller(e3);

            
            //products
            Product product1 = new Product();
            product1.Name = "Iphone";
            product1.Price = 300;
            total.AddProducts(product1);

            Product product2 = new Product();
            product2.Name = "Samsung";
            product2.Price = 500;
            total.AddProducts(product2);

            Product product3 = new Product();
            product3.Name = "Huawei";
            product3.Price = 100;
            total.AddProducts(product2);


            //sales
            Sale V1 = new Sale();
            V1.Product = product1;
            V1.Seller = e1;
            V1.Comments = "New client";
            total.Addsales(V1);

            Sale V2 = new Sale();
            V2.Product = product2;
            V2.Seller = e2;
            V2.Comments = "Regular client";
            total.Addsales(V2);


            Sale V3 = new Sale();
            V3.Product = product3;
            V3.Seller = e3;
            V3.Comments = "New client";
            total.Addsales(V3);



            double count = V1.Product.Price + V2.Product.Price + V3.Product.Price;

            //  System.Console.WriteLine("Sales total amount: " + count );


            //the seller who sold the cheapest product

            System.Console.WriteLine("The cheapest product was sold by " + total.seller_economic());


            //Average price

            System.Console.WriteLine(" The average value of products is " + total.Average_Products());

            //Units of product sold

            System.Console.WriteLine("The quantity of sales is " + total.salesCount);

            //most expensive product
            Console.WriteLine("The product more expensive is " + total.expensive_Product());
        }
    }
}
