using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_POO
{
    class PhysicalProduct : Product
    {
        public double ShippingCost { get; set; }

        public override double CalculateFinalPrice()
        {
            return Price + ShippingCost;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} (Physical) - Final price: ${CalculateFinalPrice()}");
        }
    }

}
