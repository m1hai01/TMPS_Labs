using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    public class MoldavianPizza : Pizza
    {
        public MoldavianPizza()
            : base("MoldavianPizza")
        { }
        public override int GetCost()
        {
            return 100;
        }
    }
}
