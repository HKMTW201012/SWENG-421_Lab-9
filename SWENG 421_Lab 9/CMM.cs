using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CoffeeMachineApp
{
    public class CMM : CMMEnvironmentIF
    {
        private CoffeeIF cif;
        private ProgramIF pif;

        public ProgramIF setProgram(int num)
        {
            switch (num)
            {
                case 0:
                    pif = new RegularProg();
                    break;
                case 1:
                    pif = new MochaProg();
                    break;
                case 2:
                    pif = new CappuccinoProg();
                    break;
                default:
                    throw new ArgumentException("Program number must be 0, 1, or 2.");
            }

            pif.SetEnvironment(this);
            Console.WriteLine("Program selected: " + pif.GetName());
            return pif;
        }

        public ProgramIF setProgram(string programName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            string fullName1 = "CoffeeMachineApp." + programName;
            string fullName2 = "CoffeeMachineApp." + programName + "Prog";

            Type t = asm.GetType(fullName1) ?? asm.GetType(fullName2);

            if (t == null)
            {
                throw new ArgumentException("Program not found: " + programName);
            }

            if (!typeof(ProgramIF).IsAssignableFrom(t))
            {
                throw new ArgumentException(programName + " does not implement ProgramIF.");
            }

            pif = (ProgramIF)Activator.CreateInstance(t);
            pif.SetEnvironment(this);

            Console.WriteLine("Program dynamically loaded: " + pif.GetName());
            return pif;
        }

        public void setGrindingTime(int secs)
        {
            Console.WriteLine("Grinding for " + secs + " seconds");
        }

        public void setTemperature(int degree)
        {
            Console.WriteLine("Heating water to " + degree + "°F");
        }

        public void setCoffee(CoffeeIF cif)
        {
            this.cif = cif;
            Console.WriteLine("Coffee set to: " + cif.GetDescription());
        }

        public void setLEDNum(int num)
        {
            if (num == -1)
            {
                Console.WriteLine("LED set to idle");
            }
            else
            {
                Console.WriteLine("LED set to " + num);
            }
        }

        public void runProgram()
        {
            if (pif == null)
            {
                Console.WriteLine("No program selected.");
                return;
            }

            Console.WriteLine("Running program: " + pif.GetName());
            pif.Run();
        }

        public double computePrice()
        {
            if (cif == null)
            {
                return 0.0;
            }

            return cif.ComputePrice();
        }
    }
}