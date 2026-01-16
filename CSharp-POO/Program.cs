using CSharp_POO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        // Available products
        List<Product> catalog = new List<Product>
        {
            new DigitalProduct { Name = "C# Course", Price = 500 },
            new DigitalProduct { Name = "E-book Programming", Price = 300 },
            new PhysicalProduct { Name = "Gaming Mouse", Price = 800, ShippingCost = 100 },
            new PhysicalProduct { Name = "Mechanical Keyboard", Price = 1500, ShippingCost = 150 }
        };

        int option;

        do
        {
            Console.WriteLine("\n===== ONLINE STORE =====");
            Console.WriteLine("1. View products");
            Console.WriteLine("2. Add product to cart");
            Console.WriteLine("3. View cart");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ShowCatalog(catalog);
                    break;

                case 2:
                    ShowCatalog(catalog);
                    Console.Write("Enter product number: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice > 0 && choice <= catalog.Count)
                    {
                        cart.AddProduct(catalog[choice - 1]);
                        Console.WriteLine("✔ Product added to cart");
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid option");
                    }
                    break;

                case 3:
                    cart.ShowCart();
                    break;
            }

        } while (option != 0);

        Console.WriteLine("Thank you for shopping!");
    }

    static void ShowCatalog(List<Product> catalog)
    {
        Console.WriteLine("\n📦 Available products:");
        for (int i = 0; i < catalog.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            catalog[i].ShowInfo();
        }
    }
}
