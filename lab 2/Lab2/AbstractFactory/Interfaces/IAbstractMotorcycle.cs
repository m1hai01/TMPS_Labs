using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.AbstractFactory.Interfaces
{
    public interface IAbstractMotorcycle
    {
        // Here's the the base interface of another product. All products can
        // interact with each other, but proper interaction is possible only between
        // products of the same concrete variant.
        string DriveFast();
    }
}
