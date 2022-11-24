using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("ItalianPizza")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
}
