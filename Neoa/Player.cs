using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Neoa
{
        public class Player
        {
            Random rand = new Random();

            public string CNAME;
            public string Ethnicity;


            //ints
            public int NeoanMark = 0;

            //Encounter ints/strings
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
                return rand.Next(lower,upper);

            }
            public int GetPower()
            {
                int upper = (2 * mods + 2);
                int lower = (mods + 2);
                return rand.Next(lower,upper);
            }
        //Player class End
        }

        
}

      

