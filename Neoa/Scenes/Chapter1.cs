using static Neoa.Program;
using static Neoa.Utilities.TextOutput;

namespace Neoa.Scenes;

public class Chapter1()
{
    public static void DisplayPart1()
    {

        //Choices could be added anywhere this is just the basic story and is going to change over time.
        DisplayLine(ConsoleColor.White, "narrator", "You awaken to the sound of footsteps above you and knocking on your door");
        DisplayLine(ConsoleColor.White, "narrator", $"you can hear a somewhat familiar voice say \"Wake up {Character.Name}. You have a busy day today\"");

        Console.ReadKey();

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "you decide to get up and open the door for the man, and notice its the Royal Guard");

        Console.WriteLine();
        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", $"I've been trying to wake you up for hours {Character.Name}. Now that your up, the king told me I should properly introduce myself,");
        DisplayLine(ConsoleColor.DarkMagenta, "Royal Guard", "My name is Kain,");
        DisplayLine(ConsoleColor.DarkMagenta, "Kain", "I am the captain of the royal guard.");

        Console.WriteLine();

        Console.ReadKey();

        DisplayLine(ConsoleColor.White, "narrator", "the guard being so kind is suprising to you as he hasn't been kind to you since meeting you.. why is he telling you his name you wonder..");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Kain", "Now that you know my name, don't ever call me Kain. I am the captain to you, and you will refer to me as captain.");
        DisplayLine(ConsoleColor.DarkMagenta, "Kain", "Anyways now that thats out of the way. The king wanted me to tell you, there is something in town that requires your attention.");
        DisplayLine(ConsoleColor.DarkMagenta, "Kain", "you are going to need this, and you have to head to the local tavern, the keeper will know why your there.");

        DisplayLine(ConsoleColor.White, "narrator", "Kain hands you twenty four marks and a single piece of paper");
        Character.NeoanExchange += 1; Character.NeoanMark += 24;

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "What am I supposed to do with this?");

        Console.WriteLine();

        DisplayLine(ConsoleColor.DarkMagenta, "Kain", "Just head to the tavern and do what the man there tells you");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "Kain leaves the room and you begin to walk out to the hallway.. looking down for a moment someone bumps into you but you look back and theres nothing there.");
        DisplayLine(ConsoleColor.White, "narrator", "continuing on, once you reach the top of the stairs you find the entire hall empty with no one inside \"where has everyone gone\" you wonder to yourself.");
        DisplayLine(ConsoleColor.White, "narrator", "instead of dwelling on it you  exit the castle, you notice the tavern is convienently outside of the castle");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Cyan, "Beggar", "Excuse me, sir, do you have money to spare?");

        Console.WriteLine("(Y)es I do, (N)o I don't");
        DisplayLine(ConsoleColor.Green, "You", "", 0);
        string input = Console.ReadLine();
        while (input.ToLower() != "y" && input.ToLower() != "")
        {
            Console.WriteLine("Incorrect input.");
            Console.WriteLine("{(Y)es I do, (N)o I don't.}");
        }
        if (input.ToLower() == "y")
        {
            DisplayLine(ConsoleColor.White, "narrator", "you give the beggar 1 mark");
            Character.NeoanMark -= 1; Character.AncestralFavor += 2; Character.DivineFavor += 1;

            DisplayLine(ConsoleColor.Cyan, "Beggar", "Thank you, kind sir..");

            Console.ReadKey();
            Character.Sanity += 3;

            DisplayLine(ConsoleColor.White, "narrator", "you continue to the tavern with a feeling of acomplishment");
        }
        else if (input.ToLower() == "n")
        {
            DisplayLine(ConsoleColor.White, "narrator", "you leave the beggar in the streets and don't give him any marks....");
            Character.AncestralFavor -= 2; Character.DivineFavor -= 3;

            DisplayLine(ConsoleColor.White, "narrator", "not caring about the poor man.. you continue towards the tavern..");
        }

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "reaching the doorway.. you hesitantly enter.. upon walking in the tavern keeper looks at you");
        DisplayLine(ConsoleColor.Cyan, "Tavern Keeper", $"Its been a while since I've seen someone new here.. You must be {Character.Name} the guards told me you were coming");
        DisplayLine(ConsoleColor.Cyan, "Tavern Keeper", "My name is Thomas.");

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "I was told to come here because the king needed something from here?");

        Console.WriteLine();

        DisplayLine(ConsoleColor.White, "narrator", "Thomas walks into the backroom and you hear russeling noises...");
        DisplayLine(ConsoleColor.White, "narrator", "walking out you see he has a small piece of metal. ");

        Console.ReadKey();

        DisplayLine(ConsoleColor.Cyan, "Thomas", $"This metal piece is one of the rarest things you'll ever seen in your life {Character.Name}");
        DisplayLine(ConsoleColor.Cyan, "Thomas", "Kain was supposed to pay me 24 marks for it, do you have them?.");

        Console.WriteLine();
        Console.ReadKey();
        //Choice could be added here??
        if (Character.NeoanMark == 24)
        {
            DisplayLine(ConsoleColor.Green, "You", "Yes I do. Here");
            Character.NeoanMark -= 24;
            Console.WriteLine();
            DisplayLine(ConsoleColor.Cyan, "Thomas", "Thank you.");
        }
        if (Character.NeoanMark == 23)
        {
            DisplayLine(ConsoleColor.Green, "You", "I have 23, is that good enough?");
            Console.WriteLine();
            DisplayLine(ConsoleColor.Cyan, "Thomas", "Your lucky today I didn't have to deal with one of my other clients, otherwise we'd be in a lot of trouble.");
            Character.NeoanMark -= 23;
        }
        DisplayLine(ConsoleColor.Cyan, "Thomas", "So, now that we've got that out of the way, a small reward for helping me, 2 Marks.");
        Character.NeoanMark += 2;

        Console.WriteLine();

        DisplayLine(ConsoleColor.Green, "You", "I didn't do much.. but still thank you");

        Console.WriteLine();
    }
}