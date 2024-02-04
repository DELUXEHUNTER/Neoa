using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neoa
{
    class Program
    {
        public static void Main(string[] args)
        {
        //Start Screen;
         
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         πππ       πππ    πππππππππππ       πππππππ             ");
            Console.WriteLine("         ππππ      πππ    πππππππππππ     ππππ  πππππ           ");
            Console.WriteLine("         πππππ     πππ    πππ            πππ       πππ          ");
            Console.WriteLine("         ππππππ    πππ    πππ           πππ         πππ         ");
            Console.WriteLine("         πππ ππππ  πππ    ππππππππππ   πππ          πππ         ");
            Console.WriteLine("         πππ  ππππ πππ    ππππππππππ   πππ          πππ         ");
            Console.WriteLine("         πππ    ππ πππ    πππ           πππ         πππ         ");
            Console.WriteLine("         πππ    ππππππ    πππ           ππππ       ππππ         ");
            Console.WriteLine("         πππ     πππππ    πππ            ππππ    πππππ          ");
            Console.WriteLine("         πππ       πππ    πππππππππππ      πππππππππ            ");
            Console.WriteLine("   ..... System initializing");
            Console.WriteLine("         ......... Initialization complete");
            Console.WriteLine("                      Enter operator first name.");
            //Naming.
            string firstname = Console.ReadLine();
            Console.WriteLine("last name.. ");
            Console.WriteLine("All character creation past this is currently except for ")
            string lastname = Console.ReadLine();


           // reset color command Console.ResetColor();

            Console.Clear();


            //Ints
            int correct = 0;

            //strings
            string Gender; 
            string Species;
            string Ethnicity;
            string Faction;


            //Gender selection
            do {
                Console.Clear();
                Console.WriteLine("Operator.. Gender input");
                Console.WriteLine("Male, Female.");
                Gender = Console.ReadLine();
                if (Gender == "Male")
                {
                    correct = 1;
                }
                if (Gender == "Male")
                {
                    correct = 1;
                }
                else {Console.WriteLine("Operator input invalid... retry input"); Console.ReadLine();}
            } while(correct == 0);
            correct = 0;


        //Species selection
            do {
                Console.Clear();
                Console.WriteLine("Specify species");
                Console.WriteLine("Human, Robot.");
                Species = Console.ReadLine();
                if (Species == "Human")
                {
                    correct = 1;
                }
                if (Species == "Robot")
                {
                    correct = 1;
                }
                else {Console.WriteLine("Operator input species invalid... retry input"); Console.ReadLine();}
            }while(correct == 0);
            correct = 0;
            
            //Ethnicity 
            do { 
                Console.Clear();
                Console.WriteLine("Ethnicity");
                Console.WriteLine("Neoan.");
                Console.WriteLine("Axian.");
                Console.WriteLine("Aurelian.");
                Ethnicity = Console.ReadLine();
                if (Ethnicity == "Neoan");
                {
                correct = 1;
                }
                if (Ethnicity == "Axian");
                {
                    correct = 1;
                }
                if (Ethnicity == "Aurelian");
                {
                    correct = 1;
                }
          } while(correct == 0);
            correct = 0;
          

            




           
















            Console.WriteLine(firstname " " + lastname );
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}

/* NEOA  TITLE SCREEN

            Console.WriteLine("         πππ       πππ    πππππππππππ       πππππππ           πππ               ");
            Console.WriteLine("         ππππ      πππ    πππππππππππ     ππππ  πππππ        πππππ              ");
            Console.WriteLine("         πππππ     πππ    πππ            πππ       πππ      πππ πππ             ");
            Console.WriteLine("         ππππππ    πππ    πππ           πππ         πππ     πππ πππ             ");
            Console.WriteLine("         πππ ππππ  πππ    ππππππππππ   πππ          πππ    πππ   πππ            ");
            Console.WriteLine("         πππ  ππππ πππ    ππππππππππ   πππ          πππ   πππ    ππππ           ");
            Console.WriteLine("         πππ    ππ πππ    πππ           πππ         πππ   πππππππππππ           ");
            Console.WriteLine("         πππ    ππππππ    πππ           ππππ       ππππ  πππ      ππππ          ");
            Console.WriteLine("         πππ     πππππ    πππ            ππππ    πππππ   πππ       πππ          ");
            Console.WriteLine("         πππ       πππ    πππππππππππ      πππππππππ    πππ         πππ         ");
  
*/
            