using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Subsystems
{
    // Some facades can work with multiple subsystems at the same time.
    public class PreparingFood
    {
        public string operation1()
        {
            return "PreparingFood: The food is being prepared!\n";
        }

        public string operation2()
        {
            return "PreparingFood: Food is ready!\n";
        }
    }
}
