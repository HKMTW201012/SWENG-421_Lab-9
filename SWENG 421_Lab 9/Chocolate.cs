using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class Chocolate : AbstractCondimentDecorator, CondimentIF
    {
        private readonly double basePrice = 1.00;

        public Chocolate(CoffeeIF wrappee) : base(wrappee)
        {
        }

        public override double ComputePrice()
        {
            return GetWrappee().ComputePrice() + basePrice;
        }

        public override string GetDescription()
        {
            return GetWrappee().GetDescription() + ", Chocolate";
        }
    }
}