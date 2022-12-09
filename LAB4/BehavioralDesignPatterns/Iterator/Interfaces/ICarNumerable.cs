using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Strategy;

namespace BehavioralDesignPatterns.Iterator.Interfaces
{
     interface ICarNumerable
     {
        //3.The Collection interface declares one or multiple methods for getting
        //iterators compatible with the collection.
        ICarIterator CreateNumerator();
         int Count { get; }
         Car this[int index] { get; }
    }
}
