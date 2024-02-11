/* An important note. Read this if first time contributer:
The encounter system is not ready to use and is completely useless. In the future we will redo this code and improve the encounter system
basically the encounters are in beta or prototype? I don't know how to class them other than not in use and useless */

namespace Neoa
{
    public class Encounters
    {

        public static void PrisonFirstEncounter()
        {
            Program.DisplayLine("After walking a short distance from your cell a prisoner comes up to you..");
            Program.DisplayLine("..\"Anaxians are all the same I'm tired of you all\"");
            Program.DisplayLine("The deranged man begins to attempt to attack you using a rusty sword");
            Program.DisplayLine("Right before the man can attack you the guard quickly tosses you his sword");
            Console.ReadKey();
            switch (rand.Next(1,3))
            {
                case 1:
                    {
                    Program.DisplayLine("Random Effect:")
                    Program.DisplayLine("Brushing Insanity")
                    }
                Case 2
                    {
                    
                    }

            }
            Combat(false, "deranged prisoner", 1, 2, 0);
            Program.DisplayLine("The guard takes back his sword and tells you to continue on");
        }

        public static void FirstEncounter()
        {
            Console.ReadKey();
            
            Combat(false, "Escaped Prisoner ", 1, 2, 1);
        }

        public static void RandomEncounter()
        {
            enviro = "RandEnc";
            Console.WriteLine("Empty");
        }

        public static void Combat(bool random, string enemyName, int enemyPower, int enemyHealth, int enemyMana)
        {
            while (enemyHealth > 0)
            {
                Console.Clear();
                Program.DisplayLine(enemyName);
                Program.DisplayLine($"Health: {enemyHealth}");
                Program.DisplayLine($"Strength: {enemyPower}");
                Program.DisplayLine($"Mana: {enemyMana}");
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine("║  (A)ttack (M)agic    ║");
                Console.WriteLine("║    (D)efend (F)lee   ║");
                Console.WriteLine("╚══════════════════════╝");
                Program.DisplayLine($"{Program.Player.Name}");
                Program.DisplayLine($"Health: {Program.Player.Health}");
                Program.DisplayLine($"Mana: {Program.Player.Mana}");

                string input = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(input) && input != "a" && input != "m" && input != "d" && input != "f")
                {
                    Console.WriteLine("Attack, magic, defend, or flee.");
                    input = Console.ReadLine();
                }

                if (input.ToLower() == "a" && Program.Player.Class != "mage" && input == "attack")
                {
                    Program.DisplayLine("");
                    Program.DisplayLine("");
                }
                else if (input.ToLower() == "m" || input == "magic")
                {
                    Program.DisplayLine("Spells");
                }
                else if (input.ToLower() == "d" || input == "defend")
                {
                    Program.DisplayLine("");
                    Program.DisplayLine("");
                }
                else if (input.ToLower() == "f" || input == "flee")
                {
                    Program.DisplayLine("");
                    Program.DisplayLine("");
                }

                if (Program.Player.Health < 0)
                {
                    Program.DisplayLine("So you've died? thats not great");
                    Program.Death();
                }

            }
            Console.ReadKey();
        }

        //Temporary
        public static string GetName()
        {
            Random rand = new ();
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
    }
}