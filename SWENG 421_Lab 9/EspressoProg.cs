using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class EspressoProg : AbstractProgram
    {
        public override string GetName()
        {
            return "Espresso";
        }

        public override void Run()
        {
            GetEnvironment().setLEDNum(3);
            GetEnvironment().setGrindingTime(5);
            GetEnvironment().setTemperature(200);
            GetEnvironment().setLEDNum(-1);
        }
    }
}