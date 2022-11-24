using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Subsystems
{
    public class Delivery
    {
        public string operation1()
        {
            return "Delivery: The courier takes the order!\n";
        }

        public string operation2()
        {
            return "Delivery: The courier deliver the order!\n";
        }
    }
}
