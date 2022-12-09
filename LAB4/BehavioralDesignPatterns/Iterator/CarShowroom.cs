using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Iterator.Interfaces;
using BehavioralDesignPatterns.Strategy;

namespace BehavioralDesignPatterns.Iterator
{
    class CarShowroom : ICarNumerable

    {
        //Concrete Collections return new instances of
        //a particular concrete iterator class each time the client requests one. 

        private Car[] cars;

        public CarShowroom()
        {
            cars = new Car[]
            {
                new Car{Name = "Audi RSQ8"},
                new Car{Name = "Audi e-tron gt"},
                new Car{Name = "Audi A7"}
            };
        }

        public int Count
        {
            get { return cars.Length; }
        }

        public Car this[int index]
        {
            get { return cars[index]; }
        }
        public ICarIterator CreateNumerator()
        {
            return new CarShowroomNumerator(this);
        }
    }
}
