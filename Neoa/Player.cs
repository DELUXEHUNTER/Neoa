namespace Neoa
{
    public class Player
    {
        Random rand = new Random();

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
        public int health = 100;
        public int mana = 100;
        public int damage = 10;
        public int armorValue = 0;
        public int weaponValue = 1;
    }
}
