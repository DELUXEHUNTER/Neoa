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


        
            Console.WriteLine("Initialization complete");
            Console.WriteLine("[Clear console. Press Enter.]");
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Introduction:");
            {
            WriteLine("Initialization complete welcome, " + firstname + " " + lastname + " to the Neoan Exeon corporation system.. Employee record not found ",80);
            WriteLine("...Searching community records... New Employee File being created",80 );
            WriteLine("|=========================================================|",90);
            WriteLine("|Name:"+firstname+" "+lastname+"                                       |",90);
            WriteLine("|Gender:Male                                             |",90);
            WriteLine("|Age:25                                                   |",90);
            WriteLine("|Ethnicity:Axian                                          |",90);
            WriteLine("|=========================================================|",90);
            WriteLine("Employee File Created...",90);
            WriteLine("Operator system access given. Welcome "+firstname+" "+lastname+". The first of the Exeon corporation to be born you are ",80);
            WriteLine("",80);
                
            }

        }
        public static void WriteLine(string text, int speed)
        {
            foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(80);
        }
        Console.WriteLine();
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