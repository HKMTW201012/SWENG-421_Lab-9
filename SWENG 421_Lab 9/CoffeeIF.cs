using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public interface CoffeeIF
    {
        double ComputePrice();
        string GetDescription();
    }
}