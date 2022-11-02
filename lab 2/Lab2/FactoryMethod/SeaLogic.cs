using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FactoryMethod
{
    // Concrete Logics override the factory method in order to change the
    // resulting product's type.
    class SeaLogic : Logic
    {
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }
}
