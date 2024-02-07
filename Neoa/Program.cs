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
        Prologue();





        Credits();
        
        
        }

    static void Prologue()
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
      WriteLine("Tell us your name.");
      string CNAME = Console.ReadLine();
      bool correct = false;

    //Strings
    string Ethnicity;
    string Faction; 
    string ANC; 
    do {  
      WriteLine("Where are you from "+CNAME);
      Console.WriteLine("+=============+");
      Console.WriteLine("|Neoan        |");
      Console.WriteLine("|Anaxian      |");
      Console.WriteLine("|Null         |");
//      if(CNAME == "Deacon" || CNAME == "Aaron")
      Console.WriteLine("+=============+");
      Ethnicity = Console.ReadLine();
      correct = true;
      if (Ethnicity == "Neoan")
      {
        correct = true;
      }
      else if (Ethnicity == "Anaxian" )
      {
        correct = true;
      }
      else if (Ethnicity == "Null" )
      {
        correct = false;
        Console.WriteLine("You really thought this did something did you? Not yet at least");

      }
      else 
      {
        WriteLine("The schizophrenic voices kick in "+CNAME+".");
        Console.WriteLine("That isn't a real place, or ethnicity within this realm");
        WriteLine("[Make sure to use proper capitalization]");
        correct = false;
        Console.ReadKey();
        Console.Clear();
      }
      if(correct == true)
      {
        WriteLine("Are you sure this is what you want? Your current ethnicity is "+Ethnicity);
        if(Ethnicity == "Neoan")
        {
          Console.WriteLine("Selecting Neoan is the most basic option you can pick during these stages");
          Console.WriteLine("Anaxians have more dialog. Are you sure you want to pick this? you may only turn back if you reset");
        }
        else if(Ethnicity == "Anaxian")
        {
          Console.WriteLine("Selecting Anaxian gives you many more options at this stage in the games development.");
        }
        Console.WriteLine("Y/N");
        string input = Console.ReadLine();
        if(input.ToLower() == "y")
        {
            correct = true;
        }
        else if (input.ToLower() == "n")
        {
            correct = false;
        }
        
      }
      
    } 
    while(correct == false);
    
    do {
      WriteLine("Ancient Ancestor");
      Console.WriteLine("+=========================+");
      Console.WriteLine("|Avalon                   |");
      Console.WriteLine("|Iedelan                  |");
      Console.WriteLine("|Tau-an                   |");
      Console.WriteLine("|Null                     |");
      Console.WriteLine("+=========================+");
      ANC = Console.ReadLine();
      if(ANC == "Avalon")
      {
        correct = true;
      }
      else if(ANC ==  "Iedelan")
      {
        correct = true;
      }
      else if(ANC == "Tau-an")
      {
        correct = true;
      }
      else
      {
        Console.WriteLine("The schizophrenic voices.... "+CNAME);
        Console.WriteLine("That is not a real ancestor");
      }
      
    }while(correct == false);



      Console.Clear();
      WriteLine("...You awaken in a dark cell, with no memory of anything from your past..");
      WriteLine("");
      if (CNAME == "")
        WriteLine("Not even your name.. as you begin to think..");
      else 
      WriteLine("The only thing you remember is your name " + CNAME);
      WriteLine("The knob on the door begins to turn.. a guard walks through the door");
      WriteLine("he pulls you up and tells you to follow him.");

      if (Ethnicity == "Anaxian")
      Encounters.PrisonFirstEncounter();

      WriteLine("\""+CNAME+"you've got some friends in high places, the king has ordered your release\"" );  
      WriteLine("after leading you to the entrance of the prison the guard leads you to the prison");
       
      }

    static void NewBeginnings()
    {
      Console.WriteLine("Wombad");
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

  static void Credits()
  {
    WriteLine("So, you've reached a point that the game ended sadly");
    WriteLine("In the future there will be more. For now enjoy these credits");
    Console.WriteLine(@"   
  ____________________________________________________________________________________________
  |              Code/Lore                      |              Honorable Mention              |          
  |               Creator:                      |                                             |
  |             Deacon Hunter                   |                                             |
  |                                             |                                             |
  |                                             |                                             |
  |                                             |                                             |
  |                                             |                                             |
  |                                             |                                             |
  /\____________________________________________/\____________________________________________/\
          
          
          ");
  WriteLine("Press enter to clear.");
  Console.ReadKey();
  Console.Clear();

  }
  }  

}