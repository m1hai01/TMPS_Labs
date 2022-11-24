using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy
{
    // The Subject abstract class declares common operations for both RealSubject and
    // the Proxy. As long as the client works with RealSubject using this
    // abstract class, you'll be able to pass it a proxy instead of a real subject.
    public abstract class Payment
    {
        public abstract void Request();
    }
}
