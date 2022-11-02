﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FactoryMethod
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface ITransport
    {
        string Deliver();
    }
}
