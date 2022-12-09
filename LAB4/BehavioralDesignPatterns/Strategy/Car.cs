using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.TemplateMethod;

namespace BehavioralDesignPatterns.Strategy
{
     class Car : DriveExperience
    {
        //iterator
        public string Name { get; set; }
        //strategy
        protected int passengers; 
        protected string model;

        public Car()
        {
            
        }


        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
            
        }

        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }

        //TemplateMethod
        public override void CompetentAge()
        {
            Console.WriteLine("Implinim 18 ani");
        }
        
        public override void GetDrivingLicense()
        {
            Console.WriteLine("Primim permisul de conducere B");
        }
    }
}
