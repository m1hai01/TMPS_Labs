using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.AbstractFactory.Interfaces;

namespace Lab2.AbstractFactory
{
    public class FuelMotorcycle : IAbstractMotorcycle
    {
        public string DriveFast()
        {
            return "Dreive fast and free with fuel motorcycle";
        }
    }
}
