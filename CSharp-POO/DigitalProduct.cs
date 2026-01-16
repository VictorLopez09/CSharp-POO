using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_POO
{
    class DigitalProduct : Product
    {
        public override double CalculateFinalPrice()
        {
            // No shipping cost
            return Price;
        }
                                         
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} (Digital) - Price: ${CalculateFinalPrice()}");
        }
    }             

}

