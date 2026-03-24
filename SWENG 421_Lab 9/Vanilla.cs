using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class Vanilla : AbstractCondimentDecorator, CondimentIF
    {
        private readonly double basePrice = 0.50;

        public Vanilla(CoffeeIF wrappee) : base(wrappee)
        {
        }

        public override double ComputePrice()
        {
            return GetWrappee().ComputePrice() + basePrice;
        }

        public override string GetDescription()
        {
            return GetWrappee().GetDescription() + ", Vanilla";
        }
    }
}
