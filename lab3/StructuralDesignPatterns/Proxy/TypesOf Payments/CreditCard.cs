using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.TypesOf_Payments
{
    public class CreditCard : Payment
    {
        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        Cash cash;
         public override void Request()
         {
            if (cash == null)
            {
                Console.WriteLine("Cerem bani de la mama ");
                cash = new Cash();
            }
            else
            {
                Console.WriteLine("Ai bani si platesti");
                cash.Request();
            }
        }
    }
}
