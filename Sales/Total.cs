using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Total
    {
        Seller[] Sellers = new Seller[10];
        int sellerCount = 0;

        Product[] Products = new Product[30];
        public int productsCount = 0;

        Sale[] Sales = new Sale[800];
        public int salesCount = 0;


        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }


        public void AddProducts(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }


        public void Addsales(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }


        public string seller_economic()
        {
            string nameSellerProduct = "";

            double economic = Products[0].Price;
            for (int i = 0; i <= salesCount - 1; i++)
            {

                if (economic < Products[i].Price)
                {
                    economic = Products[i].Price;
                }
                else
                {
                    nameSellerProduct = Sales[i].Seller.Name;
                }
            }

            return nameSellerProduct;
        }


        public double Average_Products()
        {
            double sum = 0;

            for (int i = 0; i <= productsCount -1 ; i++)
            {
                if (Products[i].Price != 0)
                {
                   sum += Products[i].Price;
                }
            }

            sum = sum / productsCount;

            return sum;
        }


        public double ValueOfProducts()
        {
            double countValueOfProducts = 0;

            for (int i = 0; i <= productsCount - 1; i++)
            {
                if (Products[i].Price != 0)
                {
                    countValueOfProducts += Products[i].Price;
                }
            }

            return countValueOfProducts;
        }

        public string expensive_Product()
        {
            string nameProduct = "";

            double expensive = Products[0].Price;
            for (int i = 0; i <= productsCount - 1; i++)
            {

                if (expensive > Products[i].Price)
                {
                    expensive = Products[i].Price;
                }
                else
                {
                    nameProduct = Products[i].Name;
                }
            }

            return nameProduct;
        }

    }
}
