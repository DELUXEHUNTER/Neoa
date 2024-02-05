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
            
            WriteLine("....GALACTIC YEAR:2200..MONTH:SEPTEMBER..DAY: 1",110);
            WriteLine("OPERATOR... STATUS: Deceased. ",110);
            WriteLine("MOTIONSENSOR: Motion Detected",110);
            WriteLine("DFG: Rising",110);
            WriteLine("..... System re-initializing",95);
            WriteLine("New operator detected.....",95);
            WriteLine("                .....Enter operator first name.",95);

            string firstname = Console.ReadLine();
            WriteLine("..Input last name ",95);
            string lastname = Console.ReadLine();
            WriteLine("Continuing Initilization process",95);
    
            Console.WriteLine("[In the case you haven't read the readme, press enter anytime nothing happens");
            Console.WriteLine("if this does not work send a screenshot of where you are.");
            Console.WriteLine("Typically this marks a Console.Clear command or a temporary pause to read.]");
            Console.ReadLine();

                     

        
            

//Rest of the game





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
            WriteLine("Searching for Record..",95);
            WriteLine("Employee record not found ",95);
            WriteLine("...Searching community records... New Employee File being created",80 );
            WriteLine("|==============================================|",80);
           // WriteLine("|Name:"+firstname+" "+lastname+"                                     |",90);
            WriteLine("|Name:Classified                               |",80);
            WriteLine("|Gender:Male                                   |",80);
            WriteLine("|Age:25                                        |",80);
            WriteLine("|Ethnicity:Axian                               |",80);
            WriteLine("|==============================================|",80);
            WriteLine("Employee File Created..."+firstname+" "+lastname,95);
            WriteLine("Complete system access given operator X998. Welcome "+firstname+" "+lastname+". System restore.. Success. ",95);
            WriteLine("Base employee access given",95);
            WriteLine("Initilization complete.")

            WriteLine(firstname+" "+lastname+":");
            WriteLine("F");
    
             
        }
        public static void WriteLine(string text, int speed = 60)
        {
            foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(98);
        }
        Console.WriteLine();
        } 
    }

 }

      