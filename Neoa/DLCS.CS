// This is a future CS File that will remain mostly unused until the entire game is complete or  most of the game//the part that completes it. For now this has no use, not really DLC's because you don't have to download them
namespace Neoa
{
    public class YourHome
    {
        public bool Dreams = false;
        public bool DreamEnd = false;
        //name
        string Dreamer;
        public static void Intro()
        {
            Program.DisplayLine("..What is this.....?");
            Program.DisplayLine("Who are you....");
            Dreamer = Console.ReadLine();

            if(Dreamer = Program.Player.Name)
            {
            Program.DisplayLine("");
            }
            else 
            {

            }
            
        } 

    
    }

// The kings court is a DLC that is completely seperate from the base game.

    public class TKC
    {
    public bool KCourt = false;

    public static void TKCIntro()
    {
        while(TKC = true)
        {

        }

        }

    }
}