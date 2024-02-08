namespace Neoa
{
    public class Player
    {
        Random rand = new Random();
        //strings
        public string CNAME;
        public string Ethnicity;


        //ints




        //currency int not very important until given use
        public int NeoanMark = 0;
        //Encounter ints/strings, rarely used
        public int health = 14;
        public int damage = 1;
        public int armorValue = 0;
        public int potion = 5;
        public int weaponValue = 1;

        public int mods = 0;

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
        //Player class End
    }


}