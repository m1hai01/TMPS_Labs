using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.AbstractFactory.Interfaces;

namespace Lab2.AbstractFactory
{
    public class ElectricCar : IAbstractCar
    {
        public string DriveComfort()
        {
            return "Drive comfort and econom with electric car";
        }
    }
}
