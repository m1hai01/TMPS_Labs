using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Subsystems
{
    public class PaymentProcessing
    {
        public string operation1()
        {
            return "PaymentProcessing: Sending Money!\n";
        }

        public string operation2()
        {
            return "PaymentProcessing: Receive money!\n";
        }
    }
}
