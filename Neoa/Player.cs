namespace Neoa
{
    public class Player
    {

//strings
        public string Name;
        public string Ancestor;
        public string Species;
        public string Subspecies; 
        public string Ethnicity;
        public string Class;


//ints   
        public int NeoanMark;

        //Mind
        public int Sanity = 225;
        public int Bloodthirst = 0;


        public int Reputation = 0;
        public int DivineFavor = 0;
        public int AncestralFavor = -50;
        


        public int Health = 100;
        public int Mana = 100;
        public int Damage = 10;
        public int Blooddamage = 0;
        public int Armor = 0;
        public int WeaponStrength = 1;
    



//Unique stats & Player systems

        if (Program.Player.Species == "Human")
        {
            Program.Player.Health = 105;
            Program.Player.Mana = 125;
            Program.Player.Damage = 10; 
            Program.Player.DivineFavor = -5;
            Program.Player.AncestralFavor = 5;
            Program.Player.Sanity = 250;
            Program.Player.Reputation = 0;

        }

        if(Program.Player.Species == "Undead")
        {
            if(Program.Player.Subspecies == "Vampire")
            {
            Program.Player.Health = 125;
            Program.Player.Mana = 200;
            Program.Player.Damage = 10; 
            Program.Player.BloodDamage = 2;
            if (Program.Player.Ancestor == "Tau-an")
                Program.Player.AncestralFavor = 5;
            else if (Program.Player.Ancestor != "Tau-an")
                Program.Player.AncestralFavor = -50;
            Program.Player.DivineFavor =  -25;
            Program.Player.Sanity = 235;
            Program.Player.Bloodthirst = 1;
            Program.Player.Reputation = 0;

            }
            else if (Program.Player.Subspecies == "Zombie")
            {
            Program.Player.Health = 120;
            Program.Player.Mana = 20;
            Program.Player.Damage = 12;
            Program.Player.Armor = 3;
            //Due to them being resurected even if forced
            Program.Player.DivineFavor = -30;       
            Program.Player.AncestralFavor = -100;
            Program.Player.Sanity = -250;
            Program.Player.Reputation = -50;
            }
            else if (Program.Player.Subspecies == "Revenant")
            {
            Program.Player.Health = 65;
            Program.Player.Mana = 76;
            Program.Player.Damage = 17;
            Program.Player.Armor = 5;
            Program.Player.DivieFavor = -35;
            Program.PLayer.AncestralFavor = -50;
            Program.Player.Sanity = -300;
            Program.Player.Reputation = -60;
            }

        }

        if(Program.Player.Species == "Demonic")
        {
            if(Program.Player.Subspecies == "Demon")
            {
            Program.Player.Health = 175;
            Program.Player.Mana = 400;
            Program.Player.Damage = 15;
            Program.Player.Armor = 2;
            Program.Player.DivineFavor = -30;       
            Program.Player.AncestralFavor = -200;
            Program.Player.Sanity = 450;
            Program.Player.Reputation -100;
        
            }
        }

        }
    }
}
