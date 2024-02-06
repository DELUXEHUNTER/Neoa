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

namespace Neoa
{
    class Program
    {
            public static Player CNAME = new Player();
            static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                Encounters.FirstEncounter();
        

            }
    static void Start()
    {
      WriteLine("The KINGDOM OF NEOA:");
      WriteLine("Enter your name.");
      string CNAME = Console.ReadLine();
      Console.Clear();
      WriteLine("You awake in a dark cell, with no memory of anything from your past..");
        if (CNAME == "")
            WriteLine("Not even your name..");
        else 
            WriteLine("The only thing you remember is your name " + CNAME);
      Console.ReadKey();

      WriteLine("The knob on the door begins to turn.. Another prisoner walks through..");
      WriteLine("\"So "+CNAME+"you think your a big shot, how about you back that up with a fight");
      
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




    class Encounters
    {
        static Random rand = new Random();
        //Encounters
        public static void FirstEncounter()
        {
            WriteLine("\"So you think your a big shot, how about you back that up with a fight\"");
            Console.ReadKey();
            Combat(false, "Prisoner",1,5);
        

        }
        public static void BasicFightEncounter()
        {
            WriteLine("Hi");
            Console.ReadKey();
            Combat(true, "",0,0);

        }


        //Encounter Tools 
        public static void Combat(bool random, string name, int power, int health )
        {
            string n = "";
            int p = 0;
            int h = 0; 
            if (random)
            {
                n = GetName();
                p = rand.Next(1,8);
                h = rand.Next(1,13);

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("Health: "+h);
                Console.WriteLine("Strength: "+p);
                Console.WriteLine("======================");
                Console.WriteLine("| (A)ttack (D)efend  |");
                Console.WriteLine("|  (R)un    (H)eal   |");
                Console.WriteLine("======================");
                Console.WriteLine(" Potions: "+Program.CNAME.potion+" Health: "+Program.CNAME.health);
                string input = Console.ReadLine();
                if(input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    WriteLine("With a quick thrust towards the "+n+" as you thrust towards the "+n+" strikes you");
                    int damage = p - Program.CNAME.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.CNAME.weaponValue) + rand.Next(1,4);
                    WriteLine("You lose "+ damage + "health and deal "+attack+" damage");
                    Program.CNAME.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    WriteLine("As the "+n+" prepares to strike, you ready your sword in a defensive stane");
                    int damage = (p/4) - Program.CNAME.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.CNAME.weaponValue)/2;
                    
                    WriteLine("You lose "+ damage + "health and deal "+attack+" damage");
                    Program.CNAME.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if(rand.Next(0,2) == 0)
                    {
                        WriteLine("As you sprint away the "+n+" strikes you in the back, sending you sprawling");
                        int damage = p -  Program.CNAME.armorValue;
                        if (damage < 0)
                            damage = 0;
                        WriteLine("You lose "+damage+" health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        WriteLine("You use your agility to escape from the "+n+" and you successfullY escape!");
                        Console.ReadKey();
                        //Go to store

                    }
                }
                else if(input.ToLower() == "h" || input.ToLower() == "Heal")
                {
                    //Heal
                    WriteLine("");
                    if (Program.CNAME.potion==0)
                    {
                    WriteLine("You deprately grasp for a potion in your bag but all you can feel are empty flasks");
                    int damage = p - Program.CNAME.armorValue;
                    if (damage < 0)
                        damage = 0;
                    WriteLine("The "+n+" stikes you with a sword and you lose "+damage+" health!");
                    }
                    else
                    {
                        WriteLine("You reach into your bag and drink the liquid in the vial");
                        int potionV = 5;
                        WriteLine("You gain "+ potionV + " health");
                        Program.CNAME.health += potionV;

                    }
                    Console.ReadKey();
                }
                if (Program.CNAME.health<0)
                {
                    //Death 
                    Console.WriteLine("As the "+n+" stands high it "+n+" has slain you" );
                }
                Console.ReadKey();

            }
            int c = rand.Next(1,15);
            Console.WriteLine("You stand victorious over "+n+" and gain "+c+" Neoan Marks");
            Program.CNAME.NeoanMarks +=c;
            Console.ReadKey();
            }

            public static string GetName()
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        return "Keeper";
                    case  1:
                        return "Guardian";
                    case 2:
                        return "Human Cultist";
                }
                return "Escaped Prisoner";

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


//Player
        class Player
        {
            public string CNAME;
            public int NeoanMarks = 0;
            //marks are coins
            public int health = 10;
            public int damage = 1;
            public int armorValue = 0;
            public int potion = 5;
            public int weaponValue;
        }
        



   
//Namespace-End  
}

      
