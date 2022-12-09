using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy
{
     class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Masina merge pe electricitate");
        }
    }
}
