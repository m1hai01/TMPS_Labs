using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.TypesOf_Payments
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    public class Cash : Payment
    {
        Cash cash;
        // The RealSubject contains some core business logic. Usually, RealSubjects
        // are capable of doing some useful work which may also be very slow or
        // sensitive - e.g. correcting input data. A Proxy can solve these issues
        // without any changes to the RealSubject's code.
        public override void Request()
        {
            Console.WriteLine("Cash: Request.");
        }

    }
}
