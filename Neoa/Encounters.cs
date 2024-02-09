/* An important note. Read this if first time contributer:

The encounter system is not ready to use and is completely useless. In the future we will redo this code and improve the encounter system
basically the encounters are in beta or prototype? I don't know how to class them other than not in use and useless
*/





namespace Neoa
{
    public class Encounters
    {
        public static Random rand = new Random();
        //Encounters
        public static void PrisonFirstEncounter()
        {
            reward = 1
            Program.DisplayLine("After walking a short distance from your cell a prisoner comes up to you..");
            Program.DisplayLine("..\"Anaxians are all the same I'm tired of you all\"");
            Program.DisplayLine("The deranged man begins to attempt to attack you using a rusty sword");
            Program.DisplayLine("Right before the man can attack you the guard quickly tosses you his sword");
            Console.ReadKey();
            Combat(false, "deranged prisoner", 1, 2);
            Program.DisplayLine("The guard takes back his sword and tells you to continue on");

            Console.WriteLine("Save game? Y/n");
            Console.ReadKey();
            Program.DisplayLine("Did you actually think I made a save game yet? Not yet, you can tell I got bored doing this.");
        }

        public static void FirstEncounter()
        {
            enviro = "FirstEnc";
            Console.ReadKey();
            Combat(false, "Escaped Prisoner ", 1, 2,3);


        }
        public static void RandomEncounter()
        {
            Console.WriteLine("Empty");

        }



        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            int NM = 0;
            if (random)
            {
                n = GetName();
                p = Program.player.GetPower() + 1;
                h = Program.player.GetHealth() + 1;
            }
            else
            {
                n = name;
                p = power;
                h = health;
    
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("Health: " + h);
                Console.WriteLine("Strength: " + p);
                Console.WriteLine("======================");
                Console.WriteLine("| (A)ttack (D)efend  |");
                Console.WriteLine("|  (R)un    (H)eal   |");
                Console.WriteLine("======================");
                Console.WriteLine(" Potions: " + Program.player.potion + " Health: " + Program.player.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Program.DisplayLine("A quick thrust towards the " + n + " as you thrust the " + n + " strikes you");
                    int damage = p - Program.player.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.player.weaponValue) + rand.Next(1, 5);
                    Program.DisplayLine("You lose " + damage + "health and deal " + attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Program.DisplayLine("As the " + n + " prepares to strike, you ready your sword in a defensive stane");
                    int damage = (p / 4) - Program.player.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.player.weaponValue) / 2;

                    Program.DisplayLine("You lose " + damage + "health and deal " + attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if (rand.Next(0, 2) == 0)
                    {
                        Program.DisplayLine("As you sprint away the " + n + " strikes you in the back, sending you sprawling");
                        int damage = p - Program.player.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.DisplayLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Program.DisplayLine("You use your agility to escape from the " + n + " and you successfullY escape!");
                        Console.ReadKey();
                        //Go to store

                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "Heal")
                {
                    //Heal
                    Program.DisplayLine("");
                    if (Program.player.potion == 0)
                    {
                        Program.DisplayLine("You deprately grasp for a potion in your bag but all you can feel are empty flasks");
                        int damage = p - Program.player.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.DisplayLine("The " + n + " stikes you with a sword and you lose " + damage + " health!");
                    }
                    else
                    {
                        Program.DisplayLine("You reach into your bag and drink the liquid in the vial");
                        int potionV = 5;
                        Program.DisplayLine("You gain " + potionV + " health");
                        Program.player.health += potionV;

                    }
                    Console.ReadKey();
                }
                if (Program.player.health < 0)
                {
                    //Death 
                    Program.DisplayLine("As the " + n + " stands high it " + n + " has slain you");
                    Console.ReadKey();

                }
                Console.ReadKey();
            }
            {
                if (random)
                NM = GetReward();
                else
                NM = GetReward();
                Console.WriteLine("You stand victorious over " + n + " and gain " + NM + " Neoan Marks");
                Program.player.NeoanMark += NM;
                Console.ReadKey();
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
        public static int GetReward()
        {
            if (RandomEncounter())
            {
            reward = rand.Next(0,25)  ;
            }
            else if
            return int reward;
        }

        public static string enviro = "";
    }
}