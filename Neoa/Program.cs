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
            
            WriteLine("....GALACTIC YEAR:2200",110);
            WriteLine("System Operator... status: Deceased. ")
            WriteLine("Motion sensor: Motion Detected")
            

//Rest of the game



            WriteLine("..... System initializing",95);
            WriteLine("            ..Initialization partially.. complete",95);
            WriteLine("                .....Enter operator first name.",95);

            string firstname = Console.ReadLine();
            WriteLine("..Input last name ",95);
            string lastname = Console.ReadLine();
            WriteLine("Continuing Initilization process",95);
            WriteLine();




           // reset color command Console.ResetColor();

            Console.Clear();


            //Ints
            //int correct = 0;

            //strings
            string Gender; 
            string Species = "Human";
            string Ethnicity = "Axian";
            string Faction = "Exeon";


            WriteLine("Initialization complete",80);
            Console.WriteLine("[Clear console. Press Enter.]");
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Introduction:");
            WriteLine("Initialization complete welcome, " + firstname + " " + lastname + " to the Neoan Exeon corporate system..", 95);
            WriteLine("Employee record not found ",95);
            WriteLine("...Searching community records... New Employee File being created",80 );
            WriteLine("|==============================================|",80);
           // WriteLine("|Name:"+firstname+" "+lastname+"                                     |",90);
            WriteLine("|Gender:Male                                   |",80);
            WriteLine("|Age:25                                        |",80);
            WriteLine("|Ethnicity:Axian                               |",80);
            WriteLine("|==============================================|",80);
            WriteLine("Employee File Created..."+firstname+" "+lastname,95);
            WriteLine("Complete system access given operator X998. Welcome "+firstname+" "+lastname+". System restore.. Success. ",95);
            WriteLine("Level 1 Exeon base employee acess given",95);
            WriteLine("Welcome to the system, would you like an explanation of your mission?");
            Console.WriteLine();
            WriteLine(firstname+" "+lastname":");
            
            if (Console.ReadLine(); = Y)
             
        }
        public static void WriteLine(string text, int speed = 60)
        {
            foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(95);
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