using Lab2.AbstractFactory;
using Lab2.Builder;
using Lab2.Builder.Components;
using Lab2.FactoryMethod;
using Lab2.Singleton;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        /*//Factory Method
        Console.Write("---Factory Method--- \n");
        
        new Client().Main();

        Console.WriteLine();

        //Abstract Factory method
        Console.Write("--- Abstract Factory Method--- \n ");
       
        new Client1().Main();*/


        /*Console.Write("--- Builder Method--- \n ");

        Baker baker = new Baker();
        // creem obiect - paine de secara
        BreadBuilder builder = new RyeBreadBuilder();
        // coacem
        Bread ryeBread = baker.Bake(builder);
        Console.WriteLine(ryeBread.ToString());
        // paine de grau
        builder = new WheatBreadBuilder();
        Bread wheatBread = baker.Bake(builder);
        Console.WriteLine(wheatBread.ToString());

        Console.Read();*/


        Console.Write("--- Singleton Method--- \n ");
        Computer comp = new Computer();
        comp.Launch("Windows 8.1");
        Console.WriteLine(comp.OS.Name);

        // obiectu deja e creat 
        comp.OS = OS.getInstance("Windows 10");
        Console.WriteLine(comp.OS.Name);

        Console.ReadLine();

    }
}