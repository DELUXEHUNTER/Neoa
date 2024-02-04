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
            

            Console.WriteLine("..... System initializing");
            Console.WriteLine("            ..Initialization partially.. complete");
            Console.WriteLine("                .....Enter operator first name.");

            string firstname = Console.ReadLine();
            Console.WriteLine("last name input: ");
            string lastname = Console.ReadLine();


           // reset color command Console.ResetColor();

            Console.Clear();


            //Ints
            int correct = 0;

            //strings
            string Gender; 
            string Species = "Human";
            string Ethnicity = "Axian";
            string Faction = "Exeon";


            //Gender selection
            do {
                Console.Clear();
                Console.WriteLine("Operator.. Gender input");
                Console.WriteLine("Male, Female.");
                Console.WriteLine("[Its reccomended you select male until I recieve more help]");
                Gender = Console.ReadLine();
                if (Gender == "Male")
                {
                    correct = 1;
                }
                if (Gender == "Female")
                {
                    correct = 1;
                }
                else {Console.WriteLine("Operator input invalid... reattempt input"); Console.ReadLine();}
            } while(correct == 0);
            correct = 0;


        
            Console.WriteLine("Initialization complete");
            Console.WriteLine("[Clear console. Press Enter.]");
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Introduction:")
            if (Gender == "Male");
            {
            Console.WriteLine("Initialization complete welcome, " + firstname + " " + lastname + " to the Neoan Exeon corporation system.. Employee record not found ");
            Console.WriteLine("...Searching community records... New Employee File being created" );
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("|Name:"+firstname+" "+lastname+"                                       |");
            Console.WriteLine("|Gender:"+Gender+" "+"                                             |");
            Console.WriteLine("|Age:25                                                   |");
            Console.WriteLine("|Ethnicity:Axian                                          |");
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("                                          ... Employee File Created ");
            Console.WriteLine("Operator system access given. Welcome "+firstname+" "+lastname+". The first of the Exeon corporation to be born you are ");
            Console.WriteLine("");

            }
            if (Gender == "Female")
            {
            Console.WriteLine("Initialization complete welcome, " + firstname + " " + lastname + " to the Neoan Exeon corporation system.. Employee record not found ");
            Console.WriteLine("...Searching community records... New Employee File being created" );
            Console.WriteLine("|===============================================|");
            Console.WriteLine("|Name:"+firstname+" "+lastname+"                             |");
            Console.WriteLine("|Gender:"+Gender+" "+"                                   |");
            Console.WriteLine("|Age:25                                         |");
            Console.WriteLine("|Ethnicity:Axian                                |");
            Console.WriteLine("|===============================================|");

                
            }










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
  





            //Species selection
            do {
                Console.Clear();
                Console.WriteLine("Species detection.....");
                Console.WriteLine("......Detecting");
                Console.WriteLine("Failure to detect.. required manual input")
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
                else {Console.WriteLine("Operator input invalid... reattempt input"); Console.ReadLine();}
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
                if (Ethnicity == "Neoan")
                {
                correct = 1;
                }
                if (Ethnicity == "Axian")
                {
                    correct = 1;
                }
                if (Ethnicity == "Aurelian")
                {
                    correct = 1;
                }

          } while(correct == 0);
            correct = 0;

            
          */
