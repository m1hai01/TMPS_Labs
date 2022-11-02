using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FactoryMethod;

// The Logic class declares the factory method that is supposed to return
// an object of a Product class. The Logic's subclasses usually provide
// the implementation of this method.
abstract class Logic
{
    // Note that the Logic may also provide some default implementation of
    // the factory method.
    public abstract ITransport FactoryMethod();

    // Also note that, despite its name, the Logic's primary
    // responsibility is not creating products. Usually, it contains some
    // core business logic that relies on Product objects, returned by the
    // factory method. Subclasses can indirectly change that business logic
    // by overriding the factory method and returning a different type of
    // product from it.
    public string createTransport()
    {
        // Call the factory method to create a Product object.
        var product = FactoryMethod();
        // Now, use the product.
        var result = "Logic: The same logic's code has just worked with "
                     + product.Deliver();

        return result;
    }
}
