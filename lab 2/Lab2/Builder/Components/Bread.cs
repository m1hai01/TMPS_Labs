﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Builder.Components
{
     class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Flour != null)
                sb.Append(Flour.Sort + "\n");
            if (Salt != null)
                sb.Append("Salt \n");
            if (Additives != null)
                sb.Append("Additives: " + Additives.Name + " \n");
            return sb.ToString();
        }
    }
}
