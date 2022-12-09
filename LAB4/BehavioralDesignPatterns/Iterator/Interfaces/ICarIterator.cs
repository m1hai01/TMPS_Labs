using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Strategy;

namespace BehavioralDesignPatterns.Iterator
{
     interface ICarIterator
     {
        //1.The Iterator interface declares the operations required for traversing a collection: fetching the next
        //element, retrieving the current position, restarting iteration, etc.
        bool HasNext();
         Car Next();
     }
}
