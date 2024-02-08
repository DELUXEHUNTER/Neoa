using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Neoa
{
    public class Encounters
    {
        public static Random rand = new Random();
        //Encounters
        public static void PrisonFirstEncounter()
        {
            enviro = "FirstEnc";
            WriteLine("After walking a short distance from your cell a prisoner comes up to you..");
            WriteLine("..\"Anaxians are all the same I'm tired of you all\"");
            WriteLine("The deranged man begins to attempt to attack you using a rusty sword");
            WriteLine("Right before the man can attack you the guard quickly tosses you his sword");
            Console.ReadKey();
            Combat(false, "deranged prisoner",1,2);
            WriteLine("The guard takes back his sword and tells you to continue on");
            WriteLine("\"So back to what we were taking about, \"");
            WriteLine(".... he takes a short pause");
            Console.WriteLine("Save game? Y/n");
            Console.ReadKey();
            WriteLine("Did you actually think I made a save game yet? Not yet, you can tell I got bored doing this.");
        }

         public static void FirstEncounter()
        {
            enviro = "FirstEnc";
            Console.ReadKey();
            Combat(false, "Escaped Prisoner ",1,2);
        

        }

        public static void BasicFightEncounter()
        {   
            WriteLine("Hi");
            Console.ReadKey();
            Combat(true, "",0,0);

        }
    
        //Encounter Tools 

        public static void RandomEncounter()
        {
            enviro = "RandomEnc";
            switch(rand.Next(0,2))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                


            }
        }
        public static void Combat(bool random, string name, int power, int health )
        {
            string n = "";
            int p = 0;
            int h = 0; 
            if (random)
            {
                n = GetName();
                p = Program.CNAME.GetPower()+1;
                h = Program.CNAME.GetHealth()+1;

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
                    WriteLine("A quick thrust towards the "+n+" as you thrust the "+n+" strikes you");
                    int damage = p - Program.CNAME.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.CNAME.weaponValue) + rand.Next(1,5);
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
                    WriteLine("As the "+n+" stands high it "+n+" has slain you");
                    Console.ReadKey();
                
                }
                Console.ReadKey();
            }
             //The Enviro string is used to tell apart the rewards from random and first encounter, without rewriting the entire combat multiple times
            if (enviro == "RandomEnc")
            {
            int c = rand.Next(1,15);
            Console.WriteLine("You stand victorious over "+n+" and gain "+c+" Neoan Marks");
            Program.CNAME.NeoanMark +=c;
            Console.ReadKey();
            }
            if (enviro == "FirstEnc")
            {
            int c = rand.Next(0,5);
            Console.WriteLine("You stand victorious over "+n+" and gain "+c+" Neoan Marks");
            Program.CNAME.NeoanMark +=c;
            Console.ReadKey();
            }

        
        }

//These are just temporary and the only one that will remain is Escaped Prisoner
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




//Type speed
        public static void WriteLine(string text, int speed = 70)
        {   
        foreach (char c in text)
            {
            Console.Write(c);
            System.Threading.Thread.Sleep(98);
            }
        Console.WriteLine();
        } 

        public static string enviro = "";

    }

}