using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.AbstractFactory.Interfaces;

namespace Lab2.AbstractFactory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
     class FuelVehicleFactory : IVehicleFactory
    {
        public IAbstractCar CreateCar()
        {
            return new FuelCar();
        }

        public IAbstractMotorcycle CreateMotorcycle()
        {
            return new FuelMotorcycle();
        }
    }
}
