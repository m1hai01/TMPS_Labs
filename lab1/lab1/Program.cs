using System.Runtime.InteropServices;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Report a = new Report();
            a.GoToFirstPage();
            a.GoToLastPage();
            a.GoToPage(10);
            //a.Print();

            Printer p = new Printer();
            p.PrintReport(a);
            //2
            Tadjik djumshut = new Tadjik("Djumshut");
            djumshut.Make(new MakeKebab());

            Console.WriteLine();
            djumshut.Make(new MakePizza());
        }


        
    }

}

    
 


    
