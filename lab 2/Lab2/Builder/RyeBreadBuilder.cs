using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Builder.Components;

namespace Lab2.Builder
{
    class RyeBreadBuilder : BreadBuilder

    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Flour { Sort = "Faina de secara sort prim" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            
        }
    }
}
