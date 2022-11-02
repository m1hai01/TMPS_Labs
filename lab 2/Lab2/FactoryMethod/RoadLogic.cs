using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FactoryMethod
{
    class RoadLogic : Logic
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Logic can stay independent of concrete product
        // classes.
        public override ITransport FactoryMethod()
        {
            return new Truck();
        }
    }
}
