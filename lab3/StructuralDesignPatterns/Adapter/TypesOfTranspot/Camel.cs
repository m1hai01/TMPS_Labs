using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Adapter.Interfaces;

namespace StructuralDesignPatterns.Adapter.TypesOfTranspot
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camila merge bine pe nisip si nu mananca solearca");
        }
    }
}
