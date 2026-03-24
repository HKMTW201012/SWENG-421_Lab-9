using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class RegularCoffee : CoffeeIF
    {
        private readonly double basePrice = 2.00;

        public double ComputePrice()
        {
            return basePrice;
        }

        public string GetDescription()
        {
            return "Regular";
        }
    }
}
