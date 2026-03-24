using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public abstract class AbstractCondimentDecorator : CoffeeIF
    {
        private CoffeeIF wrappee;

        protected AbstractCondimentDecorator(CoffeeIF wrappee)
        {
            this.wrappee = wrappee;
        }

        protected CoffeeIF GetWrappee()
        {
            return wrappee;
        }

        public abstract double ComputePrice();
        public abstract string GetDescription();
    }
}