using System;
using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Adapter.TypesOfTranspot;
using StructuralDesignPatterns.ConcretePizzaDecorator;
using StructuralDesignPatterns.Facade;
using StructuralDesignPatterns.Facade.Subsystems;
using StructuralDesignPatterns.Proxy;
using StructuralDesignPatterns.Proxy.TypesOf_Payments;

namespace StructuralDesignPatterns 
{
    public class Program
    {
        static void Main(string[] args)

        //decorator pizza
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // italian pizza with tomato
            Console.WriteLine("Name: {0}", pizza1.Name);
            Console.WriteLine("Price: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// italian pizza with cheese
            Console.WriteLine("Name: {0}", pizza2.Name);
            Console.WriteLine("Price: {0}", pizza2.GetCost());

            Pizza pizza3 = new MoldavianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// moldavian pizza with tomato and cheese
            Console.WriteLine("Name: {0}", pizza3.Name);
            Console.WriteLine("Price: {0}", pizza3.GetCost());

            Console.ReadLine();

            //FACADE

            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            /*MakeOrder subsystem1 = new MakeOrder();
            PaymentProcessing subsystem2 = new PaymentProcessing();
            PreparingFood subsystem3 = new PreparingFood();
            Delivery subsystem4 = new Delivery();
            PizzaOrderSystem pizzaOrderSystem = new PizzaOrderSystem(subsystem1, subsystem2, subsystem3, subsystem4);
            Console.Write(pizzaOrderSystem.Operation());*/



            /*//ADAPTER
            
            Driver driver = new Driver();
            
            Auto auto = new Auto();
            
            driver.Travel(auto);
            
            Camel camel = new Camel();
            
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            
            driver.Travel(camelTransport);

            Console.Read();*/


            //PROXY
            /*Payment payment = new CreditCard();
            payment.Request();
            payment.Request();
            */
            

            /*Console.WriteLine("Incercam sa platim cu cash");
            Cash realSubject = new Cash();
            realSubject.Request();


            Console.WriteLine();

            Console.WriteLine("Incercam sa platim cu cardu");
            
            CreditCard proxy = new CreditCard();
            proxy.Request();
            Console.WriteLine("Incercam sa platim cu cardu X2");
            proxy.Request();*/


        }
    }
}