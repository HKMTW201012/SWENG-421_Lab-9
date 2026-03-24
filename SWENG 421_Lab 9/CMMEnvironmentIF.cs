using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public interface CMMEnvironmentIF
    {
        void setGrindingTime(int secs);
        void setTemperature(int degree);
        void setLEDNum(int num);
    }
}
