using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    
        /*class Tadjik
        {
            public string Name { get; set; }
            public Tadjik(string name)
            {
                this.Name = name;
            }

            public void MakeKebab()
            {
                Console.WriteLine("Cut the chicken breast into small pieces and fry.");
                Console.WriteLine("We cut vegetables.");
                Console.WriteLine("We're preparing the sauce.");
                Console.WriteLine("We spread chicken meat and prepared vegetables on pita bread.");
                Console.WriteLine("Quickly fry the shawarma on a grill pan that is hot to the maximum on both sides.");
            }
        }
    }
    */

        public class Tadjik
        {
            public string Name { get; set; }

            
            public Tadjik(string name)
            {
                this.Name = name;
            }

            public void Make(IMake typeOfFood)
            {
                typeOfFood.Make();
            }
        }

        public interface IMake
        {
            void Make();
        }

        public class MakeKebab : IMake
        {
            public void Make()
            {
                Console.WriteLine("Cut the chicken breast into small pieces and fry.");
                Console.WriteLine("We cut vegetables.");
                Console.WriteLine("We're preparing the sauce.");
                Console.WriteLine("We spread chicken meat and prepared vegetables on pita bread.");
                Console.WriteLine("Quickly fry the shawarma on a grill pan that is hot to the maximum on both sides.");
                Console.WriteLine("Kebab is ready.");
            }

        }
        public class MakePizza : IMake
        {
            public void Make()
            {
                Console.WriteLine("You cook the dough.");
                Console.WriteLine("Put the cheese.");
                Console.WriteLine("Put the sauce.");
                Console.WriteLine("Put the pizza in the oven.");
                Console.WriteLine("After 40 minutes, the pizza is ready.");
            }
        }

}
