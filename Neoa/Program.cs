/*
Add your name

OWNER: 
DEACON HUNTER

CONTRIBUTERS:
DEACON HUNTER


DATE CREATED: 
FEBRUARY 1ST 2024

INDIRECT CONTRIBUTERS/CONTRIBUTION/CREDIT:
1. TUTORIAL USED I FORGOT THE NAME
*/

using System.Xml.Linq;

namespace Neoa
{
    public class Program
    {
        public static Player player = new();

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

            Prologue();
            Credits();
        }

        static void Prologue()
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

            player.Name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("It's not even a name!\n");
                player.Name = Console.ReadLine();
            }

            while (true)
            {
                DisplayLine($"\nWhere are you from {player.Name}");
                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║          Neoan          ║");
                Console.WriteLine("║         Anaxian         ║");
                Console.WriteLine("╚═════════════════════════╝");

                player.Ethnicity = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(player.Ethnicity) && player.Ethnicity != "Neoan" && player.Ethnicity != "Anaxian")
                {
                    Console.WriteLine("That isn't a real place, or ethnicity within this realm!");
                    player.Ethnicity = Console.ReadLine();
                }

                DisplayLine($"Are you sure this is what you want? Your current ethnicity is {player.Ethnicity}");
                if (player.Ethnicity == "Neoan")
                {
                    Console.WriteLine("Selecting Neoan is the most basic option you can pick during these stages");
                    Console.WriteLine("Anaxians have more dialog. Are you sure you want to pick this? you may only turn back if you reset");
                }
                else if (player.Ethnicity == "Anaxian")
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

            while (true)
            {
                DisplayLine("Ancient Ancestor");
                Console.WriteLine("╔═════════════════════════╗");
                Console.WriteLine("║          Avalon         ║");
                Console.WriteLine("║         Iedelan         ║");
                Console.WriteLine("║          Tau-an         ║");
                Console.WriteLine("╚═════════════════════════╝");

                player.Ancestor = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(player.Ancestor) && player.Ancestor != "Avalon" && player.Ancestor != "Iedelan" && player.Ancestor != "Tau-an")
                {
                    Console.WriteLine("That is not a real ancestor!");
                    player.Ancestor = Console.ReadLine();
                }


                Console.WriteLine($"Current Ancient Ancestor {player.Ancestor}");
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

            Console.Clear();
            DisplayLine("...You awaken in a dark cell, with no memory of anything from your past...\n");
            DisplayLine($"The only thing you remember is your name {player.Name}");
            DisplayLine("The knob on the door begins to turn.. a guard walks through the door...");
            DisplayLine("...he pulls you up and tells you to follow him.");

            //if (Ethnicity == "Anaxian") Encounters.PrisonFirstEncounter();

            DisplayLine($"\"{player.Name}you've got some friends in high places, the king has ordered your release\"");
            DisplayLine("after leading you to the entrance of the prison the guard tells you one thing before letting you leave");
            DisplayLine("\"be careful with what you do out there, you aren't going to like what they think of you");
        }

        static void NewBeginnings()
        {
            //Temp name
            Console.WriteLine("Wombat");
        }

        static void Credits()
        {
            DisplayLine("So, you've reached a point that the game ended sadly");
            DisplayLine("In the future there will be more. For now enjoy these credits");
            Console.WriteLine(@"   
  ____________________________________________________________________________________________
  |              Code/Lore                      |     Honorable Mention[Characters]           |          
  |             Deacon Hunter                   |             Neoan King                      |
  |                                             |                                             |
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

        public static void DisplayLine(string text, int speed = 60)
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