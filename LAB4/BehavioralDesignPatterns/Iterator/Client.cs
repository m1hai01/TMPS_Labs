using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Strategy;

namespace BehavioralDesignPatterns.Iterator
{
     class Client
    {
        public void SeeCars(CarShowroom carShowroom)
        {
            ICarIterator iterator = carShowroom.CreateNumerator();
            while (iterator.HasNext())
            {
                Car car = iterator.Next();
                Console.WriteLine(car.Name);
            }
        }
    }
}
