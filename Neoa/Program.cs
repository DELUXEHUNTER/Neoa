/*
OWNER: DEACON HUNTER
CONTRIBUTERS:
DATE CREATED: FEBRUARY 1ST 2024


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
        {
            static void Main()
            {
                Start();

            }

            static void Start()
            {

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
            WriteLine("Your name is " + CNAME);
      Console.ReadKey();

      WriteLine("The knob on the door begins to turn.. A guard walks through..");
      WriteLine("\"Come with me "+CNAME " you have been released on order from the king\"");
      WriteLine("He takes you to the entrance.. ")
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
    class Game
    {
        
    
    
    }

   
    }

    class Item
    {

    }
   

 }

      
