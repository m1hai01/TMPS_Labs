using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Iterator.Interfaces;
using BehavioralDesignPatterns.Strategy;

namespace BehavioralDesignPatterns.Iterator
{
     class CarShowroomNumerator : ICarIterator
    {
        //2.Concrete Iterators implement specific
        //algorithms for traversing a collection. 
        ICarNumerable aggregate;
         int index = 0;
         public CarShowroomNumerator(ICarNumerable a)
         {
             aggregate = a;
         }
         public bool HasNext()
         {
             return index < aggregate.Count;
         }

         public Car Next()
         {
             return aggregate[index++];
         }
    }
}
