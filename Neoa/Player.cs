namespace Neoa
{
    public class Player
    {
        public string Name;
        public string Ancestor;
        public string Species;
        public string Subspecies; 
        public string Ethnicity;
        public string Class;
        
        public int NeoanMark = 0;
        public int Sanity = 225;

        public int DivineFavor = 0;
        public int AncestralFavor = -50;

        //Encounter ints/strings, rarely used
        public int Health = 100;
        public int Mana = 100;
        public int Damage = 10;
        public int Armor = 0;
        public int WeaponStrength = 1;
    }
}
