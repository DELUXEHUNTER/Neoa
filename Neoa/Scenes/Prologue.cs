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
        Console.WriteLine("Press enter to begin your journey into Neoa.");
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
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Tell us your name...\n");
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

        // Ask player's gender.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"What is your gender, {Character.Name}?:");
        Console.WriteLine("{Possible answers: Male, Female}\n");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Gender = Console.ReadLine().ToLower();
        while (string.IsNullOrWhiteSpace(Character.Gender) || (Character.Gender != "male" && Character.Gender != "female"))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That isn't a real gender!\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Gender = Console.ReadLine().ToLower();
        }
        Console.WriteLine();

        // Ask player's age.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"How long have you been alive {Character.Name}?");
        Console.WriteLine("{Note: An age cannot be lower than 20, or higher than 45, its recommended you stay within 20-29.}\n");
        Character.Age = Convert.ToInt32(Console.ReadLine());
        while (!int.TryParse(Console.ReadLine(), out Character.Age) || Character.Age > 45 || Character.Age < 19)
        {
            if (Character.Age > 45)
            {
                DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Hm, you don't look that old...\n");
            }
            else if (Character.Age < 20)
            {
                DisplayLine(ConsoleColor.Red, "The Mystical Voice", "Hm, you don't look that young...\n");
            }
            else
            {
                DisplayLine(ConsoleColor.Red, "The Mystical Voice", "It is not even an age!\n");
            }
        }

        // Ask player's ethnicity.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"Where are you from, {Character.Name}?");
        Console.WriteLine("{Possible answers: Neoan, Anaxian}\n");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Ethnicity = Console.ReadLine().ToLower();
        while (string.IsNullOrWhiteSpace(Character.Ethnicity) || (Character.Ethnicity != "neoan" && Character.Ethnicity != "anaxian"))
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That isn't a real place, or ethnicity within this realm!\n");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Ethnicity = Console.ReadLine().ToLower();
        }
        Console.WriteLine();

        // Ask player's species.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"What species group are you, {Character.Name}?");
        Console.WriteLine("{Possible answers: Human, Undead, Demonic}\n");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Species = Console.ReadLine().ToLower();
        while (string.IsNullOrWhiteSpace(Character.Species) && Character.Species != "human" && Character.Species != "undead" && Character.Species != "demonic" && Character.Species != "angelic")
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That's not a real species type within this realm! Are you sure you didn't mean a subspecies type?");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Species = Console.ReadLine().ToLower();
        }
        Console.WriteLine();

        // Ask player's subspecies.
        if (Character.Species != "human")
        {
            //Commented, since it doesnt work at the moment...
            //
            //DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"And in more detail... Your subspecies, {Character.Name}.");
            //if (Character.Species == "Undead")
            //    Console.WriteLine("{Possible answers: Vampire, Revenant.}");
            //else if (Character.Species == "Demonic")
            //    Console.WriteLine("{Possible answers: Demon.}");

            //Console.WriteLine();

            //DisplayLine(ConsoleColor.Green, "You", "", 0);
            //Character.Subspecies = Console.ReadLine();
            //while (string.IsNullOrWhiteSpace(Character.Subspecies) && Character.Subspecies != "Human" && Character.Species != "Undead" && Character.Species != "Demonic" && Character.Species != "Angelic")
            //{
            //    Console.WriteLine("Thats not a real subspecies type within this realm!");
            //    DisplayLine(ConsoleColor.Green, "You", "", 0);
            //    Character.Species = Console.ReadLine();
            //}
            //Console.WriteLine();
        }

        // Ask player's ancestor.
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"Who is your ancestor, {Character.Name}?");
        Console.WriteLine("{Possible answers: Avalon, First King of Neoa. Iedelan, The Anaxian Hero. Tau-an, The Undead Lord.}\n");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        Character.Ancestor = Console.ReadLine().ToLower();
        while (string.IsNullOrWhiteSpace(Character.Ancestor) || Character.Ancestor != "avalon" || Character.Ancestor != "iedelan" || Character.Ancestor != "tau-an")
        {
            DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That is not a real ancestor!");
            DisplayLine(ConsoleColor.Green, "You", "", 0);
            Character.Ancestor = Console.ReadLine().ToLower();
        }
    }

    public static void DisplayPrologueScreen()
    {
        Console.Clear();

        DisplayLine(ConsoleColor.White, "narrator", "You awaken inside of a dark decrepit room, no memory of who you are, nor what you are doing here...");
        DisplayLine(ConsoleColor.White, "narrator", $"The only thing you can remember is your name.. or what you think your name is - {Character.Name}.");
        DisplayLine(ConsoleColor.White, "narrator", "outside of your door you can hear voices speaking you can't even make out what they are saying.. except for a few words \"Make sure to check all of the rooms\"");
        DisplayLine(ConsoleColor.White, "narrator", "you look up at the door and the knob begins to turn..");
        DisplayLine(ConsoleColor.White, "narrator", "Two guards in steel armor enter through the door, one of the guards armor has a strange insignia.");
 
        Console.WriteLine();

        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "That symbol on his armor.. that is the insignia of the Neoan Royal Family.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guards tell you to follow them..");
        DisplayLine(ConsoleColor.White, "narrator", "you reluctantly follow them.. as you walk you look around and all you see is decayed stone walls.. with carvings that aren't able to be made out.");
        DisplayLine(ConsoleColor.White, "narrator", "you all arrive in another dark room, this one larger than the other and filled with other people who looked like they were in the same situation");
        DisplayLine(ConsoleColor.White, "narrator", "one of the others looks at you and starts whispering");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Cyan, "Stranger beside you", "do you know why we're here?");
        DisplayLine(ConsoleColor.Cyan, "Stranger beside you", "well neither do I, we might be getting executed");
        DisplayLine(ConsoleColor.Cyan, "Stranger beside you", "but I don't know.");
        DisplayLine(ConsoleColor.Cyan, "Stranger beside you", "I do-");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "Before he can finish his words one of the guards speaks and tells him to be quiet");
        DisplayLine(ConsoleColor.White, "narrator", "A door opens and a bright line shines through blinding you and the others.. then the light disappears behind the closed door..");
        DisplayLine(ConsoleColor.White, "narrator", "A man walks in. Wearing royal clothing and stood with honor, dignity, and confidence he spoke... introducing himself as Lexian");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Yellow, "Lexian II", "Good evening. Many of you may recognize me, however I doubt it. My name is Lexian, Lexian II. And I'm the King.");
        DisplayLine(ConsoleColor.Yellow, "Lexian II", "I don't know any of you sadly, but I am here for you all. To give you all second chances at life, to redeem yourselves.");
        DisplayLine(ConsoleColor.Yellow, "Lexian II", "Recently the kingdoms been going through many.. Changes, yes changes in policy and procedure, and we need more people to do the tough jobs");
        
        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "the stranger beside you raises his hand and speaks..");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Cyan, "Stranger beside you", "What exactly is this program, Sir?");
        DisplayLine(ConsoleColor.Yellow, "Lexian II", "Well I'm glad you asked, its a program where I will assign each of you a job based on your personal skills.");
        DisplayLine(ConsoleColor.Yellow, "Lexian II", "Call it a work release program, your sentences will be reduced, or even lifted.");
        DisplayLine(ConsoleColor.Yellow, "Lexian II", "All of you will be apart of it, and assigned a job right now");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guards go through giving everyone in the room a peice of paper.. stopping when they reach you");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard #1", "Sir, we don't have any more papers, what do we do?");
        DisplayLine(ConsoleColor.Yellow, "Lexian II", "Just pair those two together.");
         
        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "All of the other prisoners are returned to their cells except for you and the stranger beside you...");
        DisplayLine(ConsoleColor.White, "narrator", "the stranger beside you looks at you and introduces himself");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Cyan, "Aemon", "I still don't get why we're here, but at least I have someone like me here who can work with me.");
        DisplayLine(ConsoleColor.Cyan, "Aemon", "says here on the paper we are going to be working in the Royal District of Neoa, strange how we're getting the rich district,");
        DisplayLine(ConsoleColor.Cyan, "Aemon", "but why won't they tell us what our job is now?");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guards return.. the one wearing the uniquely marked armour and speaks to you and Aemon.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", "So you two are going to be coming with us, wasn't what I was expecting.. Now lets see if I've got this straight");
        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", $"This is you? {Character.Name}");
        
        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "the royal guard shows you a small piece of paper with your name, age and other information about you..");
        DisplayLine(ConsoleColor.White, "narrator", "You begin reading to check the information until reaching a strange part of the paper.. Your reason for being Imprisoned");
        DisplayLine(ConsoleColor.White, "narrator", "For some reason you can't even read it.. all it says is a blur to you..");
        DisplayLine(ConsoleColor.White, "narrator", "You decide to just nod and tell the guard that its you");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", $"Alright now that thats all out of the way. {Character.Name}, Aemon. Your both going to be working in the Royal District");
        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", "with me. Your going to be working as investigators. We have a surplus of crime in the royal district that needs investigation" );
        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", "and who better than criminals themselves...");
        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", "Now you two need to get some rest we're gonna have a long day tommorow");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "The guard directs you back to your cell.. and you fall asleep... passing several hours.");
        // Your Home Introduction 
        // YourHomeIntro();
        DisplayLine(ConsoleColor.White, "narrator", "after waking up again you hear a knock on the door... its the royal guard again. He opens the door");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard Captain", $"We have to get going before the trail runs cold {Character.Name}, Aemon is already headed to the capital.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "You and the captain begin a long journey to the royal district of Newport.. The journey is long and takes several days.");
        DisplayLine(ConsoleColor.White, "narrator", "The mysterious voice you heard at the begining of your life.. speaks to you");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Red, "The Mystical Voice", $"{Character.Name}, The beginning of your adventure, your first few years of your new life will be well spent,");
        DisplayLine(ConsoleColor.Red, "The Mystical Voice", "be ready for what the world will throw at you, you have to be strong for whats to come.");
        
        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "After the voice's mysterious appearence, you find yourself waking up on the back of a horse.. Outside of a decrepit old building");
        DisplayLine(ConsoleColor.White, "narrator", "The captain looks backwards...");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "The Royal Guard", "So you're finally awake, we just got here.. This place is where we will be running the investigation...");

        Console.WriteLine();
        DisplayLine(ConsoleColor.White, "narrator" "Your adventure begins now.. the ending of the prologue has arrived. Now chapter 1 begins... Are you prepared for it?");

        Console.ReadKey();

        //Prologue Ending
    }
} 