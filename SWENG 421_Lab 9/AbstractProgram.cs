using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    public abstract class AbstractProgram : ProgramIF
    {
        private CMMEnvironmentIF env;

        public void SetEnvironment(CMMEnvironmentIF env)
        {
            this.env = env;
        }

        protected CMMEnvironmentIF GetEnvironment()
        {
            return env;
        }

        public abstract void Run();
        public abstract string GetName();
    }
}