using BehavioralDesignPatterns.Iterator;
using BehavioralDesignPatterns.State;
using BehavioralDesignPatterns.Strategy;
using BehavioralDesignPatterns.TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        //strategy
        Car auto = new Car(4, "Volvo", new PetrolMove());
        auto.Move();
        auto.Movable = new ElectricMove();
        auto.Move();

        Console.ReadLine();
        

        //TemplateMethod

        Motorcycle motorcycle = new Motorcycle();

        motorcycle.Start();
        auto.Start();
        Console.ReadLine();

        //Iterator
        CarShowroom carShowroom = new CarShowroom();
        Client client = new Client();
        client.SeeCars(carShowroom);
        Console.ReadLine();

        //state
        Water water = new Water(WaterState.LIQUID);
        water.Heat();
        water.Frost();
        water.Frost();

        Console.Read();


    }
}