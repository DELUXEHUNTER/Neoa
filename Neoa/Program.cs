﻿/*
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

    Console.WriteLine(@"
+=====================================================================================================================================================+
|00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|00000███00000000▄█0000█▄0000000▄████████0000000▄█000▄█▄00▄█00███▄▄▄▄000000▄██████▄00████████▄000▄██████▄0000▄▄▄▄███▄▄▄▄0000000▄██████▄00000▄████████0|
|0▀█████████▄000███0000███00000███0000███000000███0▄███▀0███00███▀▀▀██▄000███0000███0███000▀███0███0000███0▄██▀▀▀███▀▀▀██▄0000███0000███000███0000███0|
|0000▀███▀▀██000███0000███00000███0000█▀0000000███▐██▀000███▌0███000███000███0000█▀00███0000███0███0000███0███000███000███0000███0000███000███0000█▀00|
|00000███000▀00▄███▄▄▄▄███▄▄00▄███▄▄▄000000000▄█████▀0000███▌0███000███00▄███00000000███0000███0███0000███0███000███000███0000███0000███00▄███▄▄▄00000|
|00000███00000▀▀███▀▀▀▀███▀00▀▀███▀▀▀00000000▀▀█████▄0000███▌0███000███0▀▀███0████▄00███0000███0███0000███0███000███000███0000███0000███0▀▀███▀▀▀00000|
|00000███0000000███0000███00000███0000█▄0000000███▐██▄000███00███000███000███0000███0███0000███0███0000███0███000███000███0000███0000███000███00000000|
|00000███0000000███0000███00000███0000███000000███0▀███▄0███00███000███000███0000███0███000▄███0███0000███0███000███000███0000███0000███000███00000000|
|0000▄████▀00000███0000█▀000000██████████000000███000▀█▀0█▀0000▀█000█▀0000████████▀00████████▀000▀██████▀000▀█000███000█▀000000▀██████▀0000███00000000|
|0000000000000000000000000000000000000000000000▀000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███▄▄▄▄000000▄████████00▄██████▄00000▄████████000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███▀▀▀██▄000███0000███0███0000███000███0000███000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███000███000███0000█▀00███0000███000███0000███000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███000███00▄███▄▄▄00000███0000███000███0000███000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███000███0▀▀███▀▀▀00000███0000███0▀███████████000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███000███000███0000█▄00███0000███000███0000███000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|0███000███000███0000███0███0000███000███0000███000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|00▀█000█▀0000██████████00▀██████▀0000███0000█▀0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
|00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000|
+=====================================================================================================================================================+");
      WriteLine("The land of Neoa awaits, are you prepared for your fate....");
      WriteLine("..Whoever you are..?");
      WriteLine("Tell us your name");
      string CNAME = Console.ReadLine();

      WriteLine("Where are you from?");
      Console.WriteLine("===============");
      Console.WriteLine("|(N)eoa       |");
      Console.WriteLine("|(A)naxes     |");
      if(CNAME == "Deacon" || CNAME == "Aaron")
      Console.WriteLine("|(T)raveller  |"); 
      Console.WriteLine("===============");
      Console.ReadKey();
      string input = Console.ReadKey();
      if (input.ToLower() == "n")
      {
        string Ethnicity = "Neoan";
      }
      if (input.ToLower() == "a" )
      {
        string Ethnicity = "Anaxian"
      }
      if (input.ToLower() == "t")
      {
        string Ethnicity = "Traveling Trader"
      }
      else 
      {
        Console.WriteLine("Those are not real ethnicities?")
      }
      Console.ReadKey();


      Console.Clear();
      WriteLine("");
      WriteLine("...You awake in a dark cell, with no memory of anything from your past..");
      WriteLine("");
        if (CNAME == "")
         WriteLine("Not even your name.. as you begin to think..");
        else 
      WriteLine("The only thing you remember is your name " + CNAME);
      Console.ReadKey();
      WriteLine("The knob on the door begins to turn.. a guard walks through the door");
      WriteLine("he pulls you up and tells you to follow him.");
      WriteLine("\""+CNAME+"you've got some friends in high places, the king has ordered your release\"" );  
      WriteLine("after leading you to the entrance of the prison the guard tells you one thing before releasing you");
      WriteLine("");
      
      Encounters.FirstEncounter();
       
    }



    public static void WriteLine(string text, int speed = 60)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(110);
        }
        Console.WriteLine();
    } 
 }  

}

 