using static Neoa.Program;
using static Neoa.Utilities.TextOutput;

namespace Neoa.Scenes;

public class Prologue()
{
    public static void DisplayTitleScreen()
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
╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
");
        Console.WriteLine("Press any key to continue to the game.");
        Console.ReadKey();
        Console.Clear();
    }

    public static void DisplayCharacterSetupScreen()
    {
        // Narrator replicas.
        DisplayLine(ConsoleColor.White, "narrator", "You find yourself... nowhere.");
        DisplayLine(ConsoleColor.White, "narrator", "You cannot see, smell, or touch anything...");
        DisplayLine(ConsoleColor.White, "narrator", "There is only eternal darkness before you.");
        DisplayLine(ConsoleColor.White, "narrator", "Suddenly, the silence is broken by a loud, deep, echoing voice.");
        DisplayLine(ConsoleColor.White, "narrator", "It seems that the voice is speaking to you.");

        Console.WriteLine();

        // Ask player's name.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "The land of Neoa awaits, are you prepared for your fate?");
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Whoever you are...");
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Tell us your name...");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Name = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Character.Name))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "It is not even a name!\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Name = Console.ReadLine();
        }

        Console.WriteLine();

        // Ask player's gender
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"What is your gender, {Character.Name}?:");
        Console.WriteLine("{Possible answers: Male, Female}");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Gender = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Character.Gender) || (Character.Gender != "Male" && Character.Gender != "Female"))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That isn't a real gender\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Gender = Console.ReadLine();
        }
        Console.WriteLine();

        // Ask player's ethnicity.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"Where are you from, {Character.Name}?");
        Console.WriteLine("{Possible answers: Neoan, Anaxian}");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Ethnicity = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Character.Ethnicity) || (Character.Ethnicity != "Neoan" && Character.Ethnicity != "Anaxian"))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That isn't a real place, or ethnicity within this realm!\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Ethnicity = Console.ReadLine();
        }

        Console.WriteLine();

        // Ask player's species.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"What species group are you, {Character.Name}?");
        Console.WriteLine("{Possible answers: Human, Undead, Demonic}");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Species = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Character.Species) && Character.Species != "Human" && Character.Species != "Undead" && Character.Species != "Demonic" && Character.Species != "Angelic")
        {
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That's not a real species type within this realm! Are you sure you didn't mean a subspecies type?");
            Character.Species = Console.ReadLine();
        }

        Console.WriteLine();

        // Ask player's subspecies.
        if (Character.Species != "Human")
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"And in more detail... Your subspecies, {Character.Name}.");
            if (Character.Species == "Undead")
                Console.WriteLine("{Possible answers: Vampire, Revenant.}");
            else if (Character.Species == "Demonic")
                Console.WriteLine("{Possible answers: Demon.}");

            Console.WriteLine();

            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Subspecies = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Character.Subspecies) && Character.Subspecies != "Human" && Character.Species != "Undead" && Character.Species != "Demonic" && Character.Species != "Angelic")
            {
                Console.WriteLine("Thats not a real subspecies type within this realm!");
                DisplayLine(ConsoleColor.Green, "You", "", 0);
                Character.Species = Console.ReadLine();
            }

            Console.WriteLine();
        }

        // Ask player's ancestor.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"Who is your ancestor, {Character.Name}?");
        Console.WriteLine("{Possible answers: Avalon, First King of Neoa. Iedelan, The Anaxian Hero. Tau-an, The Undead Lord.}");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Ancestor = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(Character.Ancestor) && Character.Ancestor != "Avalon" && Character.Ancestor != "Iedelan" && Character.Ancestor != "Tau-an")
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That is not a real ancestor!");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Ancestor = Console.ReadLine();
        }

        //Player Age
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"How long have you been alive {Character.Name}?");
        Console.WriteLine("{Possible Answer: An age cannot be lower than 20, or higher than 45, its recommended you stay within 20-29.}");
        Character.Age = Convert.ToInt32(Console.ReadLine());
        while (Character.Age > 45 && Character.Age < 19)
        {
            if (Character.Age > 45)
            {
                DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Your age is too high it must be below 45");
            }
            else if (Character.Age < 20)
            {
                DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Your age is too low it must be higher than 19/20");
            }
            Character.Age = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static void DisplayPrologueScreen()
    {
        Console.Clear();

        DisplayLine(ConsoleColor.White, "narrator", "You awaken in a dark cell, with no memory of anything from your past...");
        DisplayLine(ConsoleColor.White, "narrator", $"The only thing you remember is your name - {Character.Name}.");
        DisplayLine(ConsoleColor.White, "narrator", $"You hear a muffled voice from outside your door you could only make out a few words \"and... a few days away from... execution\"");
        DisplayLine(ConsoleColor.White, "narrator", "The knob on the door begins to turn...");
        DisplayLine(ConsoleColor.White, "narrator", "A guard in steel armor with a sword enters the door, on his armor is the emblem of the Neoa royal family.");
        DisplayLine(ConsoleColor.White, "narrator", "He pulls you up and tells you to follow him.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", "Come on, get up! His Majesty does not like to wait.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guard leads you to the entrance where you see someone who looked like royalty. standing calm, with purpose and proud of himself.");
        DisplayLine(ConsoleColor.White, "narrator", "You stop in front of him. The guard bent the knee.");
        DisplayLine(ConsoleColor.White, "narrator", "The guard begins to speak. Loudly and with respect.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", "Your Majesty, this is the person you were talking about.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "You look up and it comes to you. The King of Neoa himself stands before you!");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Yellow, "Neoan King", $"Ahh I've been waiting for you {Character.Name}. I hope you find your release enjoyable.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guard leans in to speak to the king in a quiet tone, you can only make out a few words from the guard while the king speaks clearly.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", "Are you sure ....trust them?..");
        DisplayLine(ConsoleColor.Yellow, "Neoan King", "I'm quite sure we can");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The king looks back towards you to continue his conversation with you.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Yellow, "Neoan King", "So, where was I. Ahhh yes the reason I've freed you..");
        DisplayLine(ConsoleColor.Yellow, "Neoan King", "I honestly don't even know why, I didn't think about it.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "You don't... know?..");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Yellow, "Neoan King", "Yes I don't know, I heard about your imprisonment through the newspapers, and decided I would meet you.");
        DisplayLine(ConsoleColor.Yellow, "Neoan King", "I'm tired of this dull place, I think it is time we relocate.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "the king tells you to follow him and begin traveling to the Aedonian Castle..");
        if (Character.Ancestor == "Avalon")
        {
            DisplayLine(ConsoleColor.White, "narrator", "Arriving at the castle you are taken in by its size and beauty, you recognize statues of Avalon, the first Neoan king");

            Console.WriteLine();

            if (Character.Ethnicity != "Neoan")
                DisplayLine(ConsoleColor.Yellow, "Neoan King", "I see your admiring the statue of the first king I'm suprised you know who he is");
            else
                DisplayLine(ConsoleColor.Yellow, "Neoan King", "That statue has been here since after his death, Avalon is still prominent today. Many of my family members have hoped I'd live up to his legacy");
        }

        else if (Character.Ancestor != "Avalon")
        {
            DisplayLine(ConsoleColor.White, "narrator", "Arriving at the castle you are taken in by its size and beauty. You see unrecognizeable statues of a glorified man... \"who is that?\" you think to yourself");

            Console.WriteLine();

            DisplayLine(ConsoleColor.Yellow, "Neoan King", "Do you know who that is? Thats Avalon the very first Neoan King. He built this very city with his own hands.");
        }

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "Entering the castle.. you are greeted by several people wanting to shake your hand");
        DisplayLine(ConsoleColor.White, "narrator", "..to get to know you, but the king quickly tells you to follow him..");
        DisplayLine(ConsoleColor.White, "narrator", "you follow him down stairs.. he leads you to a room at the very end of a damp hallway");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Yellow, "Neoan King", "This is where you'll be sleeping not many places are  going to be better than this.. especially for you.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The king leaves the room.. The room he has left you in seems as horrid as the cell you woke up in");
        DisplayLine(ConsoleColor.White, "narrator", "it was damp, and dark with only a single candle for light.. The bed was made completely of wood with no cloth or linen on it... water dripped from the ceilling ");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "looking around the room you inspect it closer noticing a misplaced dresser with its drawer partially open");
        DisplayLine(ConsoleColor.White, "narrator", "you have multiple options... you could sleep or you could inspect the dresser and fix it?");
        Console.WriteLine("{Possible Choices: (S)leep, (I)nspect}");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "", 0);
        string input = Console.ReadLine();
        while (input.ToLower() != "s" && input.ToLower() != "i")
        {
            DisplayLine(ConsoleColor.White, "narrator", $"{Character.Name} just stands there doing nothing");
            Console.WriteLine("{Possible Choicees: (S)leep, (I)nspect");
        }
        if (input.ToLower() == "i")
        {
            //NeoanExchange Papers are used to give a certain amount of Marks when turned in at a bank or some stores that will appear in the future
            //Int still needs to be added
            Character.NeoanExchange += 1;
            DisplayLine(ConsoleColor.White, "narrator", "searching through the drawers you find a piece of paper with a royal signature, for now you decide to put the paper back not knowing what to do with it");
            DisplayLine(ConsoleColor.White, "narrator", "..you then decide to go to sleep");
        }
        else if (input.ToLower() == "s")
        {
            DisplayLine(ConsoleColor.White, "narrator", "you decide its best you sleep now and worry about your room later on.. laying in the bed you find it hard to sleep until eventually you find a comfortable spot in your bed");
        }

        // YourHome.Intro();
    }
}