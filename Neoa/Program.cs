/*
OWNER: 
DEACON HUNTER

CONTRIBUTERS:
DEACON HUNTER


DATE CREATED: 
FEBRUARY 1ST 2024

INDIRECT CONTRIBUTERS/CONTRIBUTION/CREDIT:
1. TUTORIAL USED I FORGOT THE NAME


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neoa
{
    public class Program
    {
        Random rand = new Random();
        public static Player CNAME = new Player();
        static void Main(string[] args)
        {
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
      
      Encounters.FirstEncounter();
       
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

 