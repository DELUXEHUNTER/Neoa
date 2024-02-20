using Neoa.Scenes;

namespace Neoa;

public class Program
{
    public static Player Character = new();

    public static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Black;

        if (OperatingSystem.IsWindows())
        {
            Console.SetWindowSize(155, 55);
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        Prologue.DisplayTitleScreen();
        Prologue.DisplayCharacterSetupScreen();
        Prologue.DisplayPrologueScreen();

        Chapter1.DisplayPart1();

        Epilogue.DisplayCreditScreen();
    }
}