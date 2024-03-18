using static Neoa.Program;
using static Neoa.Utilities.TextOutput;

namespace Neoa.Scenes;

public class Chapter1()
{
    public static void DisplayPart1()
    {
//I don't know where to put choices and decisions but if you want add them anywhere 
//New Code:
        DisplayLine(ConsoleColor.White, "narrator", "You both arrive at a decrepit building with nothing outside but an odd looking coffin decorated with the word \"DESMOND\"");
        DisplayLine(ConsoleColor.White, "narrator", "it could be a name or clue.. but you decide to just disregard it as it might just be something that was placed there after.");
        DisplayLine(ConsoleColor.White, "narrator", "The captain taps on your shoulder.");
        
        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", "Before we get too far into this case, I think I should have given this to you");
        DisplayLine(ConsoleColor.White, "narrator", "he hands you a piece of paper, it contains:");
        Console.WriteLine();
        //I want the case file to be written in more detail and stuff but I don't have ideas or know how to describe so this case is just the temporary one
        Console.WriteLine("Title:");
        Console.WriteLine("Desmond Morai - Case File");
        Console.WriteLine("Text:");
        Console.WriteLine("Desmond Morai, Age 24,");
        Console.WriteLine($"Assigned to case: Kain Sovin, {Character.Name}");
        Console.WriteLine("was killed by unknown causes but it is suspected that some kind of magic was involved, causing him to have a heart attack");
        Console.WriteLine("No one was at the scene of the crime but there were many people who reported hearing cries and screams of terror aswell as a demonic voice");
        Console.WriteLine("all of the surrounding witnesses also reported their animals would begin to shake and screech.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", "Have you read it, anyways I forgot to tell you, my name is...");
        DisplayLine(ConsoleColor.White, "narrator", "he pauses for a moment..");
        DisplayLine(ConsoleColor.DarkMagenta, "Kain", "Kain Sovin, now that thats out of the way we should get started with the investigation, I'll be out here while you do whatever");
        
        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "You enter the building and immedietely you see blood, covering everything in the room.. ");
        DisplayLine(ConsoleColor.White, "narrator", "The house is decrepit with rats scurrying all over the place gnawing on things.. its tight, there is not enough space to move around.");
        DisplayLine(ConsoleColor.White, "narrator", "..as you walk into the kitchen there is a creak behind you...");
        /

    }

}