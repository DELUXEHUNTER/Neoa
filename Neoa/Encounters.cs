/* An important note. Read this if first time contributer:
The encounter system is not ready to use and is completely useless. In the future we will redo this code and improve the encounter system
basically the encounters are in beta or prototype? I don't know how to class them other than not in use and useless */
namespace Neoa
{
    public class Encounters
    {
        public static Random rand = new Random();
        public static int reward = 0;
        //Encounters
        public static void PrisonFirstEncounter()
        {
            reward = 1;
            Program.DisplayLine("After walking a short distance from your cell a prisoner comes up to you..");
            Program.DisplayLine("..\"Anaxians are all the same I'm tired of you all\"");
            Program.DisplayLine("The deranged man begins to attempt to attack you using a rusty sword");
            Program.DisplayLine("Right before the man can attack you the guard quickly tosses you his sword");
            Console.ReadKey();
            Combat(true, "deranged prisoner", 1, 2);
            Program.DisplayLine("The guard takes back his sword and tells you to continue on");

            Console.WriteLine("Save game? Y/n");
            Console.ReadKey();
            Program.DisplayLine("Did you actually think I made a save game yet? Not yet, you can tell I got bored doing this.");
        }

        public static void FirstEncounter()
        {
            enviro = "FirstEnc";
            reward = 30;
            Console.ReadKey();
            Combat(true, "Escaped Prisoner ", 1, 2);


        }
        public static void RandomEncounter()
        {
            enviro = "RandEnc";
            Console.WriteLine("Empty");

        }

        public static void Combat(bool random, string name, int power, int health, int mana)
        {
            string n = "";
            int p = 0;
            int h = 0;
            int m = 0;
            n = name;
            p = power;
            h = health;
            m = mana;
            int NM = 0;
        
        while (h > 0)
        {
            Console.Clear();
            Program.DisplayLine(n);
            Program.DisplayLine($"Health: {h}");
            Program.DisplayLine($"Strength: {p}");
            Program.DisplayLine($"Mana: {m}");
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║  (A)ttack (M)agic    ║");
            Console.WriteLine("║    (D)efend (F)lee   ║");                             
            Console.WriteLine("╚══════════════════════╝");  
            Program.DisplayLine($"{player.Name}");
            Program.DisplayLine($"Health: {player.health}");
            Program.DisplayLine($"Mana: {player.mana}");
            string input = Console.ReadLine();
            if (input.ToLower() == "a" && player.class != mage && input == "attack")
            {
                Program.DisplayLine("");
                Program.DisplayLine("");
            }
            else if (input.ToLower() == "m" && input == "magic")
            {
                Console.DisplayLine("Spells");
            }
            else if (input.ToLower() == "d" && input == "defend")
            {
                Program.DisplayLine("");
                Program.DisplayLine("");
            }
            else if  (input.ToLower() == "f" && input == "flee")
            {
                Program.DisplayLine("");
                Program.DisplayLine("");
            }
            while (string.IsNullOrWhiteSpace(input) && input != "a" && input = "m" && input != "d" && input != "f")
            {
                Console.WriteLine("Attack, magic, defend, or flee.");
                input = Console.ReadLine();
            }
            if (player.health < 0)
            {
                Program.DisplayLine("So you've died? thats not great");
                Program.Death();
            }

            }
            Console.ReadKey();

            {
                //Temporary
                NM = reward; 
                Program.DisplayLine($"You looted {NM}");
                Program.player.NeoanMark += NM;


            }

            
    

        }
        //Temporary
        public static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Keeper";
                case 1:
                    return "Guardian";
                case 2:
                    return "Human Cultist";
            }
            return "Escaped Prisoner";

        }
        public static string enviro = "";
    }
}