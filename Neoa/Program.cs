﻿/* Add your name for credit[I'll auto add if you've directly talked to me]
OWNER: 
@DELUXEHUNTER

CONTRIBUTERS:
@DELUXEHUNTER
@Fuinny

DATE CREATED: 
FEBRUARY 1ST 2024

INDIRECT CONTRIBUTERS/CONTRIBUTION/CREDIT:
1. TUTORIAL USED I FORGOT THE NAME */

namespace Neoa
{
    public class Program
    {
        public static Player Player = new();

        public bool DLC1 = false;
        public bool DLC2 = false;

        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(155, 45);
                Console.BufferWidth = Console.WindowWidth;
                Console.BufferHeight = Console.WindowHeight;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        
            TitleScreen();

            //if (player.Species != "Human")
            //PrologueType2();
            //else
            PrologueType1();
            Credits();
            
        }

        static void TitleScreen()
        {
            Console.WriteLine(@"
╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
║000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000║
║000000███00000000▄█0000█▄0000000▄████████0000000▄█000▄█▄00▄█00███▄▄▄▄000000▄██████▄00████████▄000▄██████▄0000▄▄▄▄███▄▄▄▄0000000▄██████▄00000▄████████0000║
║00▀█████████▄000███0000███00000███0000███000000███0▄███▀0███00███▀▀▀██▄000███0000███0███000▀███0███0000███0▄██▀▀▀███▀▀▀██▄0000███0000███000███0000███0000║
║00000▀███▀▀██000███0000███00000███0000█▀0000000███▐██▀000███▌0███000███000███0000█▀00███0000███0███0000███0███000███000███0000███0000███000███0000█▀00000║
║000000███000▀00▄███▄▄▄▄███▄▄00▄███▄▄▄000000000▄█████▀0000███▌0███000███00▄███00000000███0000███0███0000███0███000███000███0000███0000███00▄███▄▄▄00000000║
║000000███00000▀▀███▀▀▀▀███▀00▀▀███▀▀▀00000000▀▀█████▄0000███▌0███000███0▀▀███0████▄00███0000███0███0000███0███000███000███0000███0000███0▀▀███▀▀▀00000000║
║000000███0000000███0000███00000███0000█▄0000000███▐██▄000███00███000███000███0000███0███0000███0███0000███0███000███000███0000███0000███000███00000000000║
║000000███0000000███0000███00000███0000███000000███0▀███▄0███00███000███000███0000███0███000▄███0███0000███0███000███000███0000███0000███000███00000000000║
║00000▄████▀00000███0000█▀000000██████████000000███000▀█▀0█▀0000▀█000█▀0000████████▀00████████▀000▀██████▀000▀█000███000█▀000000▀██████▀0000███00000000000║
║00000000000000000000000000000000000000000000000▀000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███▄▄▄▄000000▄████████00▄██████▄00000▄████████00000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███▀▀▀██▄000███0000███0███0000███000███0000███00000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███000███000███0000█▀00███0000███000███0000███00000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███000███00▄███▄▄▄00000███0000███000███0000███00000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███000███0▀▀███▀▀▀00000███0000███0▀███████████00000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███000███000███0000█▄00███0000███000███0000███00000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000███000███000███0000███0███0000███000███0000███00000000000000000000000000000000000000000000000000000000║
║0000000000000000000000000000000000000000000000000000▀█000█▀0000██████████00▀██████▀0000███0000█▀000000000000000000000000000000000000000000000000000000000║
║000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000║
╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            DisplayLine("The land of Neoa awaits, are you prepared for your fate...");
            DisplayLine("...Whoever you are?");
            DisplayLine("Tell us your name.");

            Player.Name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Player.Name))
            {
                Console.WriteLine("It's not even a name!\n");
                Player.Name = Console.ReadLine();
            }

            while (true)
            {
                DisplayLine($"\nWhere are you from {Player.Name}");
                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║          Neoan          ║");
                Console.WriteLine("║         Anaxian         ║");
                Console.WriteLine("╚═════════════════════════╝");

                Player.Ethnicity = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(Player.Ethnicity) && Player.Ethnicity != "Neoan" && Player.Ethnicity != "Anaxian")
                {
                    Console.WriteLine("That isn't a real place, or ethnicity within this realm!");
                    Player.Ethnicity = Console.ReadLine();
                }

                DisplayLine($"Are you sure this is what you want? Your current ethnicity is {Player.Ethnicity}");
                if (Player.Ethnicity == "Neoan")
                {
                    Console.WriteLine("Selecting Neoan is the most basic option you can pick during these stages");
                    Console.WriteLine("Anaxians have more dialog. Are you sure you want to pick this? you may only turn back if you reset");
                }
                else if (Player.Ethnicity == "Anaxian")
                {
                    Console.WriteLine("Selecting Anaxian gives you many more options at this stage in the games development.");
                }

                Console.WriteLine("Y/N");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            while(true)
            {
                DisplayLine("Species-type");
                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║         Human           ║");
                Console.WriteLine("║         Undead          ║");
                Console.WriteLine("║         Demonic         ║");
                Console.WriteLine("╚═════════════════════════╝");
                
                Player.Species = Console.ReadLine();
                while(string.IsNullOrWhiteSpace(Player.Species) && Player.Species != "Human" && Player.Species != "Undead" && Player.Species != "Demonic" && Player.Species != "Angelic")
                {
                    Console.WriteLine("Thats not a real species type within this realm, the species you are looking for may be found within a subspecies.");
                    Player.Species = Console.ReadLine();
                }

                if (Player.Species != "Human")
                {
                DisplayLine("Now your subspecies");
                if (Player.Species == "Undead")
                {
                DisplayLine("Typically these are evil but not in this case, Dhampir is not considered a ");
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine("║        Vampire       ║");
                Console.WriteLine("║         Zombie       ║");
                Console.WriteLine("║        Revenant      ║");
                Console.WriteLine("╚══════════════════════╝");
                Player.Subspecies = Console.ReadLine();
                while(string.IsNullOrWhiteSpace(Player.Subspecies) && Player.Subspecies != "Human" && Player.Species != "Undead" && Player.Species != "Demonic" && Player.Species != "Angelic")
                {
                    Console.WriteLine("Thats not a real species type within this realm, the species you are looking for may be found within a subspecies.");
                    Player.Species = Console.ReadLine();
                }

                }
                else if (Player.Species == "Demonic")
                {
                DisplayLine("These beings are typically evil");
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine("║         Demon        ║");                             
                Console.WriteLine("╚══════════════════════╝");                
                }
                //Demon is the only demonic race for now
                }

                DisplayLine($"Are you sure you want this. Your current species is {Player.Species}, while your sub species is {Player.Subspecies}");
                Console.WriteLine("Y/N");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            while (true)
            {
                DisplayLine("Ancient Ancestor");
                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║          Avalon         ║");
                Console.WriteLine("║         Iedelan         ║");
                Console.WriteLine("║          Tau-an         ║");
                Console.WriteLine("╚═════════════════════════╝");

                Player.Ancestor = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(Player.Ancestor) && Player.Ancestor != "Avalon" && Player.Ancestor != "Iedelan" && Player.Ancestor != "Tau-an")
                {
                    Console.WriteLine("That is not a real ancestor!");
                    Player.Ancestor = Console.ReadLine();
                }

                Console.WriteLine($"Current Ancient Ancestor {Player.Ancestor}");
                DisplayLine("Are you sure this is what you want your decision to be? You cannot change this.");
                Console.WriteLine("Y/N");

                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        static void PrologueType1()
        {

            Console.Clear();
            DisplayLine("...You awaken in a dark cell, with no memory of anything from your past...\n");
            DisplayLine($"The only thing you remember is your name {Player.Name}");
            DisplayLine("you hear a muffled voice from outside your door you could only make out a few words \"and..a few days away from.. execution\"");
            DisplayLine("The knob on the door begins to turn.. a guard walks through the door...");
            DisplayLine("...he pulls you up and tells you to follow him.");

            if (Player.Ethnicity == "Anaxian") Encounters.PrisonFirstEncounter();

            DisplayLine("the guard leads you to the entrance where you see someone who looked like royalty he stood calm with purpose and pride");
            DisplayLine("speaking to you the guard tells you \"thats the royal who begged us to release you\"");
            DisplayLine($"So, your {Player.Name}.");
        }

        public static void Death()
        {
            //Temporary death, death screen will change depending on way of death
            while(true)
            {
                Console.Clear();
                DisplayLine("The realm of the dead claims your soul.");

                DisplayLine("Info");
                DisplayLine($"Name: {Player.Name}");
                DisplayLine($"Species: {Player.Species}/{Player.Subspecies}");
                DisplayLine($"Ethnicity: {Player.Ethnicity}");
                DisplayLine($"Ancestor: {Player.Ancestor}");

                Console.WriteLine("Stats");
                DisplayLine($"Sanity {Player.Sanity}");
                DisplayLine($"Divine & Ancestral Favor: {Player.DivineFavor}, {Player.AncestralFavor}");
            }
            Console.ReadKey();
        }

        static void Credits()
        {
            DisplayLine("So, you've reached a point that the game ended sadly");
            DisplayLine("In the future there will be more. For now enjoy these credits");
            Console.WriteLine(@"   
  ____________________________________________________________________________________________
  |              Code/Lore                      |        Honorable Mention[Characters]        |          
  |             Deacon Hunter                   |                                             |
  |               Fuinny                        |                                             |
  |                                             |                                             |
  |                                             |                                             |
  |                                             |                                             |
  |                                             |                                             |
  |                                             |                                             |
  /\____________________________________________/\____________________________________________/\
          
          
          ");
            DisplayLine("Press enter to clear.");
            Console.ReadKey();
            Console.Clear();

        }

        public static void DisplayLine(string text, int speed = 70)
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