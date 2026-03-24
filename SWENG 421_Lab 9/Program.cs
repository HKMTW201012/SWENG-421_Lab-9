using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;

namespace CoffeeMachineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drink 1: Mocha + Cream + Vanilla");

            CMM machine1 = new CMM();

            CoffeeIF drink1 =
                new Vanilla(
                    new Cream(
                        new MochaCoffee()
                    )
                );

            machine1.setCoffee(drink1);
            machine1.setProgram(1);
            machine1.runProgram();
            Console.WriteLine("Sale price: $" + machine1.computePrice().ToString("F2"));
            Console.WriteLine();

            Console.WriteLine("Drink 2: Espresso + Cream + Vanilla + Chocolate x2");

            CMM machine2 = new CMM();

            CoffeeIF drink2 =
                new Chocolate(
                    new Chocolate(
                        new Vanilla(
                            new Cream(
                                new EspressoCoffee()
                            )
                        )
                    )
                );

            machine2.setCoffee(drink2);
            machine2.setProgram("Espresso");
            machine2.runProgram();
            Console.WriteLine("Sale price: $" + machine2.computePrice().ToString("F2"));
        }
    }
}