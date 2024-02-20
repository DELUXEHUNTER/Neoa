using static Neoa.Program;
using static Neoa.Utilities.TextOutput;

namespace Neoa.Scenes;

public class Death()
{
    public static void DisplayDeathScreen()
    {
        Console.Clear();
        DisplayLine(ConsoleColor.White, "narrator", "A tall black figure appears before you...");
        DisplayLine(ConsoleColor.White, "narrator", "The figure looks at you for a few seconds and begins to speak...");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkRed, "Death", $"...{Character.Name}... Did you expect this? Could you have?..");
        DisplayLine(ConsoleColor.DarkRed, "Death", $"use your last few moments alive to reflect on your life. {Character.Name}");

        Console.WriteLine();

        Console.WriteLine("Info");
        Console.WriteLine($"Name: {Character.Name}");
        Console.WriteLine($"Species: {Character.Species}/{Character.Subspecies}");
        Console.WriteLine($"Ethnicity: {Character.Ethnicity}");
        Console.WriteLine($"Ancestor: {Character.Ancestor}");

        Console.WriteLine();

        Console.WriteLine("Stats");
        Console.WriteLine($"Sanity: {Character.Sanity}");
        Console.WriteLine($"Divine & Ancestral Favor: {Character.DivineFavor}, {Character.AncestralFavor}");

        Console.ReadKey();

        DisplayLine(ConsoleColor.DarkRed, "Death", $"{Character.Name}.. Its time to move on now....");

        Console.WriteLine("THE END.");
        Console.ReadKey();
    }
}