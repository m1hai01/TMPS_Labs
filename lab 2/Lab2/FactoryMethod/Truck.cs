using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FactoryMethod
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class Truck : ITransport
    {
        public string Deliver()
        {
            return "{Truck deliver by land in a box;}";
        }
    }
}
