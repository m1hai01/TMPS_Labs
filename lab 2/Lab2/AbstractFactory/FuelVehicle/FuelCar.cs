using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.AbstractFactory.Interfaces;

namespace Lab2.AbstractFactory
{
    public class FuelCar : IAbstractCar
    {
        public string DriveComfort()
        {
            return "Drive comfort and free with fuel car";
        }
    }
}
