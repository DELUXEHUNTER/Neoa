using static Neoa.Utilities.TextOutput;

namespace Neoa.Scenes;

public class Epilogue()
{
    public static void DisplayCreditScreen()
    {
        Console.WriteLine(@"
    ███        ▄█    █▄       ▄████████ ███▄▄▄▄      ▄█   ▄█▄      ▄██   ▄    ▄██████▄  ███    █▄  
▀█████████▄   ███    ███     ███    ███ ███▀▀▀██▄   ███ ▄███▀      ███   ██▄ ███    ███ ███    ███ 
   ▀███▀▀██   ███    ███     ███    ███ ███   ███   ███▐██▀        ███▄▄▄███ ███    ███ ███    ███ 
    ███   ▀  ▄███▄▄▄▄███▄▄   ███    ███ ███   ███  ▄█████▀         ▀▀▀▀▀▀███ ███    ███ ███    ███ 
    ███     ▀▀███▀▀▀▀███▀  ▀███████████ ███   ███ ▀▀█████▄         ▄██   ███ ███    ███ ███    ███ 
    ███       ███    ███     ███    ███ ███   ███   ███▐██▄        ███   ███ ███    ███ ███    ███ 
    ███       ███    ███     ███    ███ ███   ███   ███ ▀███▄      ███   ███ ███    ███ ███    ███ 
   ▄████▀     ███    █▀      ███    █▀   ▀█   █▀    ███   ▀█▀       ▀█████▀   ▀██████▀  ████████▀   
");
        DisplayLine(ConsoleColor.Red, null, "So, you've reached a point that the game ended sadly");
        DisplayLine(ConsoleColor.Red, null, "In the future there will be more. For now enjoy these credits");
        Console.WriteLine(@"
    __________________   __________________
.-/|     Code/Lore    \ /Honorable Mentions|\-.
||||   Deacon Hunter   |    [Characters]   ||||
||||      Fuinny       |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||__________________ | __________________||||
||/===================\|/===================\||
`--------------------~___~-------------------''
");
    }
}
