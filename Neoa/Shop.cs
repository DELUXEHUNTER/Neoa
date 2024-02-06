using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Neoa
{
    public class Shop
    {
        static int armorMod;
        static int weaponMod;
        static int difMod;

        public static void LoadShop(Player p)
        {
            armorMod = p.armorValue;
            weaponMod = p.weaponValue;
            difMod = p.mods;
            RunShop(p);
        }

        public static void RunShop(Player P)
        {

            int armorP;
            int weaponP;
        

            while(true)
            {
            armorP = 45 * (p.armorValue+1);
            weaponP = 67 * (p.weaponValue + 2);
            difP = 200 + 50 * (p.mods);
            Console.Clear();
            Console.WriteLine("         Shop         ");
            Console.WriteLine("======================");
            Console.WriteLine("| (W)eapon:         $"+weaponP);
            Console.WriteLine("(A)rmor:            $"+armorP);
            Console.WriteLine("|(D)ifficulty Mod:  $"+difP);
            Console.WriteLine("======================");
            Console.WriteLine("(E)xit");
/*Stats*/   Console.WriteLine();
            Console.WriteLine(p.name+"'s Stats      ");
            Console.WriteLine("======================");
            Console.WriteLine("Marks:           "+p.NeoanMarks)
            Console.WriteLine("Weapon Strength: "+p.weaponValue);
            Console.WriteLine("Armor Toughness: "+p.armorValue);
            Console.WriteLine("Difficulty: "+p.mods);
            Console.WriteLine("======================");
            //Wait for input
            string input = Console.ReadLine().ToLower();
            if(input = "w"|| input == "weapon")
            {
                TryBuy("weapon", weaponP, p);
            }
            else if(input == "a"|| input == "armor")
            {
                TryBuy("armor", armorP, p);               
            }
            else if(input == "d"|| input == "difficulty mod")
            {
                TryBuy("dif", difP, p);
            }
            else if (input == "e"|| input == "exit")
                break;
        }
    }
    static void TryBuy(string item, int cost, Player p)
    {
        if(p.NeoanMark >= cost)
        {
            if(item == "weapon")
                p.weaponValue++;
            else if (item == "armor")
                p.armorValue++;
            else if (item == "dif")
                p.mods++;

            p.NeoanMarks -= cost; 
        }
        else
        {
            WriteLine("You don't have enough marks");
            Console.ReadKey();
        }

    }






    }
}