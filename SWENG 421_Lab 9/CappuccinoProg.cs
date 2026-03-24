using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class CappuccinoProg : AbstractProgram
    {
        public override string GetName()
        {
            return "Cappuccino";
        }

        public override void Run()
        {
            GetEnvironment().setLEDNum(2);
            GetEnvironment().setGrindingTime(7);
            GetEnvironment().setTemperature(160);
            GetEnvironment().setLEDNum(-1);
        }
    }
}