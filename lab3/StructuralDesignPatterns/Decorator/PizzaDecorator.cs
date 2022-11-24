﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }
}
