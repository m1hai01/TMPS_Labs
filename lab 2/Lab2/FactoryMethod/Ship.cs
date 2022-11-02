using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FactoryMethod
{
    class Ship : ITransport
    {
        public string Deliver()
        {
            return "{Ship deliver by sea in container }";
        }
    }
}
