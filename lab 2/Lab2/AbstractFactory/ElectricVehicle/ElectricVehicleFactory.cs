using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.AbstractFactory.Interfaces;

namespace Lab2.AbstractFactory
{
     class ElectricVehicleFactory : IVehicleFactory
    {
        public IAbstractCar CreateCar()
        {
            return new ElectricCar();
        }

        public IAbstractMotorcycle CreateMotorcycle()
        {
            return new ElectricMotorcycle();
        }
    }
}
