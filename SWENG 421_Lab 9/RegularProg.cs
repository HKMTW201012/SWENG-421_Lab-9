using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class RegularProg : AbstractProgram
    {
        public override string GetName()
        {
            return "Regular";
        }

        public override void Run()
        {
            GetEnvironment().setLEDNum(0);
            GetEnvironment().setGrindingTime(6);
            GetEnvironment().setTemperature(140);
            GetEnvironment().setLEDNum(-1);
        }
    }
}
