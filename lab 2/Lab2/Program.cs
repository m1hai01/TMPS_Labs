using Lab2.AbstractFactory;
using Lab2.FactoryMethod;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Factory Method
        Console.Write("---Factory Method--- \n");
        
        new Client().Main();

        Console.WriteLine();

        //Abstract Factory method
        Console.Write("--- Abstract Factory Method--- \n ");
        new Client1().Main();
    }
}