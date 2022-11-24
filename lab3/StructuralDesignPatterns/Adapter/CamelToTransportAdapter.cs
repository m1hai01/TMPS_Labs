﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Adapter.TypesOfTranspot;

namespace StructuralDesignPatterns.Adapter
{
    public class CamelToTransportAdapter : ITransport
    {
         Camel camel;

         public CamelToTransportAdapter(Camel c)
         {
             camel = c;
         }

         public void Drive()
         {
             camel.Move();
         }

    }
}
