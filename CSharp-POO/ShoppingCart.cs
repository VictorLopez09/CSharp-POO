using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_POO
{
    class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowCart()
        {
            double total = 0;

            Console.WriteLine("\n Products in the cart:");
            foreach (var p in products)
            {
                p.ShowInfo();
                total += p.CalculateFinalPrice();
            }

            Console.WriteLine($"\n Total to pay: ${total}");
        }
    }
}
