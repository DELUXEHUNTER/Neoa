using static Neoa.Program;
using static Neoa.Utilities.TextOutput;

namespace Neoa.Scenes;

public class Death()
{
    public static void DisplayDeathScreen()
    {
        Console.Clear();

        DisplayLine(ConsoleColor.White, "narrator", "A tall black figure appears before you.. you begin to shake..");
        DisplayLine(ConsoleColor.White, "narrator", "The figure looks at you... staring into your eyes for a moment. Then it speaks with a calm tone..");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkRed, "Death", $"..{Character.Name}. Did you expect this...? Could you have expected this...");
        DisplayLine(ConsoleColor.DarkRed, "Death", $"Use your last few moments alive to reflect on the life you have lived. {Character.Name}");

        Console.WriteLine();

        Console.WriteLine("Reflection");
        Console.WriteLine($"Name: {Character.Name}");
        Console.WriteLine($"Species: {Character.Species}/{Character.Subspecies}");
        Console.WriteLine($"Ethnicity: {Character.Ethnicity}");
        Console.WriteLine($"Ancestor: {Character.Ancestor}");

        Console.WriteLine();

        Console.WriteLine("Stats");
        Console.WriteLine($"Sanity: {Character.Sanity}");
        Console.WriteLine($"Divine & Ancestral Favor: {Character.DivineFavor}, {Character.AncestralFavor}");

        Console.ReadKey();

        DisplayLine(ConsoleColor.White, "narrator", "Death looks into your eyes again. Noticing you shaking.. it speaks once more.");
        
        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkRed, "Death", $"{Character.Name}, It is time... time to move on.. don't be afraid... its okay.");

        Console.WriteLine();

        Console.WriteLine("THE END...");


        Console.ReadKey();
    }


 
}