using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_POO
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        // Método polimórfico
        public abstract double CalculateFinalPrice();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} - Base price: ${Price}");
        }
    }
}
