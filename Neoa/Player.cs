namespace Neoa;

public class Player
{ 
    // strings
    public string Name;
    public string Ethnicity;
    public string Gender;

    public string Ancestor;
    public string Species;
    public string Subspecies;
    
    public string Class;

    //ints   

    //Currency
    public int NeoanMark = 0;
    
    //Mind
    public int Sanity = 225;

    //Undead

    //blood thirst value is at a maximum of 10 and a minimum of negative 1. 
    public int Bloodthirst = 0;

    //World/Influence
    public int Reputation = 0;
    public int DivineFavor = 0;
    public int AncestralFavor = -50;

    //Physical/Magical
    public int Age; 

    //Physical/Magical(Encounters)
    public int Health = 100;
    public int Mana = 100;
    public int Blood = 0;
    public int Damage = 10;
    public int Blooddamage = 0;
    public int Armor = 0;
    public int WeaponStrength = 1;

    public static void SetupStats()
    {
        if (Program.Player.Species == "Human")
        {
            Program.Player.Health = 105;
            Program.Player.Mana = 125;
            Program.Player.Damage = 10;
            Program.Player.DivineFavor = -5;
            if (Program.Player.Ancestor == "Avalon" )
            Program.Player.AncestralFavor = 20;
            if (Program.Player.Ancestor != "Avalon" )
            Program.Player.AncestralFavor = 2;
            Program.Player.Sanity = 250;
            Program.Player.Reputation = 0;

        }

        else if (Program.Player.Species == "Undead")
        {
            if (Program.Player.Subspecies == "Vampire")
            {
                Program.Player.Health = 125;
                Program.Player.Mana = 200;
                Program.Player.Damage = 10;
                if (Program.Player.Ancestor == "Tau-an")
                    Program.Player.AncestralFavor = 5;
                else if (Program.Player.Ancestor != "Tau-an")
                    Program.Player.AncestralFavor = -50;
                Program.Player.DivineFavor = -25;
                Program.Player.Sanity = 235;
                Program.Player.Reputation = 0;

                //Vampiric
                Program.Player.Blooddamage = 2;
                Program.Player.Blood = 100;
                Program.Player.Bloodthirst = 1;

            }
            else if (Program.Player.Subspecies == "Zombie")
            {
                Program.Player.Health = 120;
                Program.Player.Mana = 20;
                Program.Player.Damage = 12;
                Program.Player.Armor = 3;
                //Due to them being resurected even if forced
                Program.Player.DivineFavor = -30;
                if (Program.Player.Ancestor == "Tau-An")
                    Program.Player.AncestralFavor = 2;
                else if (Program.Player.Ancestor != "Tau-An")
                    Program.Player.AncestralFavor = -100;
                Program.Player.Sanity = -250;
                Program.Player.Reputation = -50;

                //Undead
                Program.Player.Bloodthirst = 50;
            }
            else if (Program.Player.Subspecies == "Revenant")
            {
                Program.Player.Health = 65;
                Program.Player.Mana = 76;
                Program.Player.Damage = 17;
                Program.Player.Armor = 5;
                Program.Player.DivineFavor = -35;
                Program.Player.AncestralFavor = -50;
                Program.Player.Sanity = -300;
                Program.Player.Reputation = -60;
            }

        }

        else if (Program.Player.Species == "Demonic")
        {
            if (Program.Player.Subspecies == "Demon")
            {
                Program.Player.Health = 175;
                Program.Player.Mana = 400;
                Program.Player.Damage = 15;
                Program.Player.Armor = 2;
                Program.Player.DivineFavor = -30;
                Program.Player.AncestralFavor = -200;
                Program.Player.Sanity = 450;
                Program.Player.Reputation = -100;

                //Demonic
                Program.Player.Bloodthirst = 5; 

            }
        }
    }
}
