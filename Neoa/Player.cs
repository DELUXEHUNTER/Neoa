using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Neoa
{
     [Serializable]
        public class Player
        {
            Random rand;

            public string CNAME;
            public int NeoanMarks = 0;
            //Neoan marks are coins
            public int health = 10;
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

      

