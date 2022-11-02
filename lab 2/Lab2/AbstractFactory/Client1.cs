using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.AbstractFactory
{
    public class Client1
    {
        public void Main()
        {
            // The client code works with factories and products only through abstract
            // types: AbstractFactory and AbstractProduct. This lets you pass any
            // factory or product subclass to the client code without breaking it.

            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new FuelVehicleFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ElectricVehicleFactory());
        }

        public void ClientMethod(IVehicleFactory factory)
        {
            var productA = factory.CreateCar();
            var productB = factory.CreateMotorcycle();


            Console.WriteLine(productA.DriveComfort());
            Console.WriteLine(productB.DriveFast());
           
        }
    }
}
