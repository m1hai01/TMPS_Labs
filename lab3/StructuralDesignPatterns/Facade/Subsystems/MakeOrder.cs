using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Subsystems
{
    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class MakeOrder
    {
        public string operation1()
        {
            return "MakeOrder: Order Complete!\n";
        }

        public string operation2()
        {
            return "MakeOrder: Kitchen receive your order!\n";
        }
    }
}
