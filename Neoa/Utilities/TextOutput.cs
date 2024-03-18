namespace Neoa.Utilities;

public class TextOutput()
{
    public static void DisplayLine(ConsoleColor textColor, string name, string text, int speed = 120)
    {
        Console.ForegroundColor = textColor;

        if (name == "narrator")
        {
            Console.Write("[ ");
        }
        else if (name != null)
        {
            Console.Write($"{name}: ");
        }

        foreach (char c in text)
        {
            Console.Write(c);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Thread.Sleep(speed / 4);
                }
            }
            else
            {
                Thread.Sleep(speed);
            }
        }

        if (name == "narrator") Console.Write(" ]");
        if (text != "") Console.Write("\n");
    }
}
