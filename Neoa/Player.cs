namespace Neoa
{
    public class Player
    {
        Random rand = new Random();

        public string Name;
        public string Ancestor;
        public string Ethnicity;

        //Ints without use yet
        public int NeoanMark = 0;
        //Idea? public int Sanity = 150;

        //Encounter ints/strings, rarely used
        public int health = 15;
        public int mana = 100;
        public int damage = 1;
        public int armorValue = 0;
        public int potion = 5;
        public int weaponValue = 1;

        public int mods;

        public int GetHealth()
        {
            int upper = (2 * mods + 7);
            int lower = (mods + 2);
            return rand.Next(lower, upper);

        }
        public int GetPower()
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }
    }
}
