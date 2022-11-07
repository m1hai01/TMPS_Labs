using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Builder.Components;

namespace Lab2.Builder
{
    class WheatBreadBuilder : BreadBuilder

    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Flour { Sort = "Faina de grau - sort superior" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives { Name = "ameliorator de panificatie" };
        }
    }
}
