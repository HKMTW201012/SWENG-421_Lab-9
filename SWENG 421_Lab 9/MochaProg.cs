using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public class MochaProg : AbstractProgram
    {
        public override string GetName()
        {
            return "Mocha";
        }

        public override void Run()
        {
            GetEnvironment().setLEDNum(1);
            GetEnvironment().setGrindingTime(8);
            GetEnvironment().setTemperature(150);
            GetEnvironment().setLEDNum(-1);
        }
    }
}