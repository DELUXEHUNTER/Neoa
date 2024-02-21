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
    public int NeoanExchange = 0;
    
    //Mind
    public int Sanity = 225;

    //Undead
     //BT max val 10, min val -5
    public int Bloodthirst;

    //World/Influence
    public int Reputation;
    public int DivineFavor;
    public int AncestralFavor = -50;

    //Physical/Magical
    public int Age; 

    //Physical/Magical(Encounters)
    public int Health = 100;
    public int Mana = 100;
    public int BloodMana = 0;
    public int Damage = 10;
    public int Blooddamage = 0;
    public int Armor = 0;
    public int WeaponStrength = 1;

    public static void SetupStats()
    {
        if (Program.Character.Species == "Human")
        {
            Program.Character.Health = 105;
            Program.Character.Mana = 125;
            Program.Character.Damage = 10;
            Program.Character.DivineFavor = -5;
            if (Program.Character.Ancestor == "Avalon" )
            Program.Character.AncestralFavor = 20;
            if (Program.Character.Ancestor != "Avalon" )
            Program.Character.AncestralFavor = 2;
            Program.Character.Sanity = 250;
            Program.Character.Reputation = 0;

        }
        else if (Program.Character.Species == "Undead")
        {
            if (Program.Character.Subspecies == "Vampire")
            {
                Program.Character.Health = 125;
                Program.Character.Mana = 100;
                Program.Character.Damage = 10;
                if (Program.Character.Ancestor == "Tau-an")
                    Program.Character.AncestralFavor = 5;
                else if (Program.Character.Ancestor != "Tau-an")
                    Program.Character.AncestralFavor = -50;
                Program.Character.DivineFavor = -25;
                Program.Character.Sanity = 235;
                Program.Character.Reputation = 0;

                //Vampiric
                Program.Character.Blooddamage = 2;
                Program.Character.BloodMana = 100;
                Program.Character.Bloodthirst = 1;

            }
            else if (Program.Character.Subspecies == "Revenant")
            {
                Program.Character.Health = 65;
                Program.Character.Mana = 76;
                Program.Character.Damage = 17;
                Program.Character.Armor = 5;
                Program.Character.DivineFavor = -35;
                Program.Character.AncestralFavor = -50;
                Program.Character.Sanity = -300;
                Program.Character.Reputation = -60;
            }

        }
        else if (Program.Character.Species == "Demonic")
        {
            if (Program.Character.Subspecies == "Demon")
            {
                Program.Character.Health = 175;
                Program.Character.Mana = 300;
                Program.Character.Damage = 15;
                Program.Character.Armor = 2;
                Program.Character.DivineFavor = -30;
                Program.Character.AncestralFavor = -200;
                Program.Character.Sanity = 450;
                Program.Character.Reputation = -100;

                //Demonic 
                Program.Character.Bloodthirst = 5; 
                Program.Character.BloodMana = 100;

            }
        }
    }
}