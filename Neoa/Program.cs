/*
OWNER: 
DEACON HUNTER

CONTRIBUTERS:
DEACON HUNTER


DATE CREATED: 
FEBRUARY 1ST 2024

INDIRECT CONTRIBUTERS:
1. TUTORIAL USED


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Neoa
{
    public class Program
    {
            public static Player CNAME = new Player();
            static void Main(string[] args)
            {
                if(!Directory.Exists("saves"))
                {
                    Directory.CreateDirectory("saves")
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Start();
                Encounters.FirstEncounter();
        

            }
    static void Start()
    {
      WriteLine("NEOA");
      WriteLine("Enter your name.");
      string CNAME = Console.ReadLine();
      Console.Clear();
      WriteLine("You awake in a dark cell, with no memory of anything from your past..");
        if (CNAME == "")
            WriteLine("Not even your name..");
        else 
            WriteLine("The only thing you remember is your name " + CNAME);
      Console.ReadKey();
      WriteLine("The knob on the door begins to turn.. a guard walks through the door");
      WriteLine("he pulls you up and tells you to follow him.");
      WriteLine("\""+CNAME+"you've got a friend in a high place, the king has ordered your release\"" ) ;  
      WriteLine("the prison guard ");
       
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



//Program Class end
    }








    
//Player
        [Serializable]
        public class Player
        {
            Random rand;

            public string CNAME;
            public int NeoanMarks = 0;
            //Neoan marks are coins
            public int health = 10;
            public int damage = 1;
            public int armorValue = 0;
            public int potion = 5;
            public int weaponValue = 1;

            public int mods = 0;

            public int GetHealth()
            {
                int upper = (2 * mods + 7);
                int lower = (mods + 2);
                return rand.Next(lower,upper);

            }
            public int GetPower()
            {
                int upper = (2 * mods + 2);
                int lower = (mods + 2);
                return rand.Next(lower,upper);

            }
        //Player class End
        }

        



   
//Namespace-End  
}

      
