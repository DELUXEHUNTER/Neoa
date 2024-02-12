namespace Neoa;

public class Program
{
    public static Player Player = new();

    public static void Main()
    {
        if (OperatingSystem.IsWindows())
        {
            Console.SetWindowSize(155, 55);
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Black;

        TitleScreen();
        Prologue();
        Credit();
    }

    public static void TitleScreen()
    {
        // Note from Fuinny: we need to add ability to choose character's gender and age.
        // Narrator replicas.
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
╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
");
        DisplayLine(ConsoleColor.White, "narrator", "You find yourself... nowhere.");
        DisplayLine(ConsoleColor.White, "narrator", "You cannot see, smell, or touch anything...");
        DisplayLine(ConsoleColor.White, "narrator", "There is only eternal darkness before you.");
        DisplayLine(ConsoleColor.White, "narrator", "Suddenly, the silence is broken by a loud, deep, echoing voice.");
        DisplayLine(ConsoleColor.White, "narrator", "It seems that the voice is speaking to you. You cannot see anyone, but you feel the presence of others.");

        Console.WriteLine();

        // Ask player's name.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "The land of Neoa awaits, are you prepared for your fate?");
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Whoever you are...");
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Tell us your name...");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Player.Name = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Player.Name))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "It is not even a name!\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Player.Name = Console.ReadLine();
        }

        Console.WriteLine();

        // Ask player's gender
        DisplayLine(Console.Color.Read, "The Mystical Voice", $"What is your gender, {Player.Name}?:);
        Console.WriteLine("{Possible answers: Male, Female}");

        Console.WriteLine();
                    
        DisplayLine(ConsoleColor.Green, "You","", 0);
        Player.Gender = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Player.Gender) || (Player.Gender != "Male" && Player.Gender != "Female"))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That isn't a real gender\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Player.Gender = Console.ReadLine();
        }
        Console.WriteLine();

        // Ask player's ethnicity.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"Where are you from, {Player.Name}?");
        Console.WriteLine("{Possible answers: Neoan, Anaxian}");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Player.Ethnicity = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Player.Ethnicity) || (Player.Ethnicity != "Neoan" && Player.Ethnicity != "Anaxian"))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That isn't a real place, or ethnicity within this realm!\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Player.Ethnicity = Console.ReadLine();
        }

        Console.WriteLine();

        // Ask player's species.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"What are you, {Player.Name}?");
        Console.WriteLine("{Possible answers: Human, Undead, Demonic}");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Player.Species = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Player.Species) && Player.Species != "Human" && Player.Species != "Undead" && Player.Species != "Demonic" && Player.Species != "Angelic")
        {
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That's not a real species type within this realm! Are you sure you didn't mean a subspecies type?");
            Player.Species = Console.ReadLine();
        }

        Console.WriteLine();

        // Ask player's subspecies.
        if (Player.Species != "Human")
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"And now in more detail... Your subspecies, {Player.Name}.");
            Console.WriteLine("{Possible answers: Vampire, Zombie, Revenant, Demon}");

            Console.WriteLine();
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Player.Subspecies = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Player.Subspecies) && Player.Subspecies != "Human" && Player.Species != "Undead" && Player.Species != "Demonic" && Player.Species != "Angelic")
            {
                Console.WriteLine("Thats not a real subspecies type within this realm!");
                DisplayLine(ConsoleColor.Green, "You", "", 0);
                Player.Species = Console.ReadLine();
            }

            Console.WriteLine();
        }

        // Ask player's ancestor.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"Who is your ancestor, {Player.Name}?");
        Console.WriteLine("{Possible answers: Avalon, Iedelan, Tau-an}");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Player.Ancestor = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Player.Ancestor) && Player.Ancestor != "Avalon" && Player.Ancestor != "Iedelan" && Player.Ancestor != "Tau-an")
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That is not a real ancestor!");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Player.Ancestor = Console.ReadLine();
        }
    }

    public static void Prologue()
    {
        Console.Clear();

        DisplayLine(ConsoleColor.White, "narrator", "You awaken in a dark cell, with no memory of anything from your past...");
        DisplayLine(ConsoleColor.White, "narrator", $"The only thing you remember is your name - {Player.Name}.");
        DisplayLine(ConsoleColor.White, "narrator", $"You hear a muffled voice from outside your door you could only make out a few words \"and... a few days away from... execution\"");
        DisplayLine(ConsoleColor.White, "narrator", "The knob on the door begins to turn...");
        DisplayLine(ConsoleColor.White, "narrator", "A guard in steel armor with a sword enters the door, on his armor is the emblem of the Neoa royal family.");
        DisplayLine(ConsoleColor.White, "narrator", "He pulls you up and tells you to follow him.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", "Come on, get up! His Majesty does not like to wait.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guard leads you to the entrance where you see someone who looked like royalty. He stood calm, with purpose and pride.");
        DisplayLine(ConsoleColor.White, "narrator", "You stop in front of him. The guardian bent the knee.");
        DisplayLine(ConsoleColor.White, "narrator", "The guard begins to speak. Loudly and with respect.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", "Your Majesty, this is the person you were talking about.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "You look up and it comes to us. The King of Neoa himself stands before you!");
    }

    // Note from Fuinny: we can actually add parameter to this method in the future and the output will change depending on way of death.
    // Temporary death, death screen will change depending on way of death, who or what killed you and will show you your players information
    public static void Death()
    {
        Console.Clear();

        DisplayLine(ConsoleColor.White,"narrator","A tall black figure appears before you...");
        DisplayLine(ConsoleColor.White, "narrator", "The figure looks at you for a few seconds and begins to speak...");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkRed,"Death",$"...{Player.Name}... Did you expect this?");

        Console.WriteLine();

        Console.WriteLine("THE END");

        Console.WriteLine("Info");
        Console.WriteLine($"Name: {Player.Name}");
        Console.WriteLine($"Species: {Player.Species}/{Player.Subspecies}");
        Console.WriteLine($"Ethnicity: {Player.Ethnicity}");
        Console.WriteLine($"Ancestor: {Player.Ancestor}");

        Console.WriteLine("Stats");
        Console.WriteLine($"Sanity: {Player.Sanity}");
        Console.WriteLine($"Divine & Ancestral Favor: {Player.DivineFavor}, {Player.AncestralFavor}");

        Console.ReadKey();
        
    }

    public static void Credit()
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
            Thread.Sleep(speed);
        }

        if (name == "narrator") Console.Write(" ]");
        if (text != "") Console.Write("\n");
    }
}
