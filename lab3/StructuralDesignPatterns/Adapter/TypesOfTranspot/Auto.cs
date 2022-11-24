using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Adapter.Interfaces;

namespace StructuralDesignPatterns.Adapter.TypesOfTranspot
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Masina merge bine pe trasa :)");
        }
    }
}
