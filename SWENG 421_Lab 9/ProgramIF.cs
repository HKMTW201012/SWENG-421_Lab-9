using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public interface ProgramIF
    {
        void SetEnvironment(CMMEnvironmentIF env);
        void Run();
        string GetName();
    }
}
