using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Facade.Subsystems;

namespace StructuralDesignPatterns.Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class PizzaOrderSystem
    {
        protected MakeOrder _makeOrder;

        protected PaymentProcessing _payment;

        protected PreparingFood _preparingFood;

        protected Delivery _delivery;

        

        public PizzaOrderSystem(MakeOrder makeOrder,PaymentProcessing paymentProcessing, PreparingFood preparingFood, Delivery delivery)
        {
            this._makeOrder = makeOrder;
            this._payment = paymentProcessing;
            this._preparingFood = preparingFood;
            this._delivery = delivery;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "First step:\n";
            result += this._makeOrder.operation1();
            result += this._makeOrder.operation2();

            result += "Second step:\n";
            result += this._payment.operation1();
            result += this._payment.operation2();

            result += "Third step:\n";
            result += this._preparingFood.operation1();
            result += this._preparingFood.operation2();

            result += "Fourth step:\n";
            result += this._delivery.operation1();
            result += this._delivery.operation2();

            return result;
        }
    }
}
