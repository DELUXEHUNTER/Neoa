/*
OWNER: 
DEACON HUNTER

CONTRIBUTERS:
DEACON HUNTER


DATE CREATED: 
FEBRUARY 1ST 2024

INDIRECT CONTRIBUTERS:
1. TUTORIAL USED


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Neoa
{
    public class Program
    {
            public static Player CNAME = new Player();
            static void Main(string[] args)
            {
                if(!Directory.Exists("saves"))
                {
                    Directory.CreateDirectory("saves");
                }
                Console.ForegroundColor = ConsoleColor.Red;
        

            }
    static void NewStart()
    {
      WriteLine("NEOA");
      WriteLine("Enter your name.");
      string CNAME = Console.ReadLine();
      Console.Clear();
      WriteLine("You awake in a dark cell, with no memory of anything from your past..");
        if (CNAME == "")
            WriteLine("Not even your name..");
        else 
            WriteLine("The only thing you remember is your name " + CNAME);
      Console.ReadKey();
      WriteLine("The knob on the door begins to turn.. a guard walks through the door");
      WriteLine("he pulls you up and tells you to follow him.");
      WriteLine("\""+CNAME+"you've got a friend in a high place, the king has ordered your release\"" ) ;  
      WriteLine("the prison guard ");
       
    }

    
    

    public static void Save(Player p)
    {
        BinaryFormatter binForm = new BinaryFormatter();
        string path = "saves/" + CNAME.id.ToString();
        FileStream file = File.Open(path, FileMode.OpenOrCreate);
        binForm.Serialize(file, CNAME);
        file.Close();
    }
    
    public static Player Load(string path)
    {
        Console.Clear();
        WriteLine("Choose your player");
        string[] paths = Directory.GetDirectories("saves");
        List<Player> players = new List<Player>();
        BinaryFormatter binForm = new BinaryFormatter();

        foreach (string p in paths)
        {
            FileStream file = File.Open(p,FileMode.Open);
            Player player = (Player)binForm.Deserialize(file);
            file.Close();
            players.Add(player);
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose your player:");
            foreach (Player p in players)
            {
            WriteLine(p.id+": " + p.name);
            }
        }

        Console.WriteLine("Please input player name or id (id:# or playername) 'Create' will start new game");
        string[] data = Console.ReadLine().Split(':');

        try 
        {
            if(date[0] == "id")
            {
                if(int.TryParse(data[1],out int id))
                {
                    foreach (Player player in players)
                    {
                        if(player.id == id)
                        {
                            return player;
                        }
                    }
                    WriteLine("There is no player with that id!");
                    Console.ReadKey();
                }
                else
                {
                    WriteLine("Your id needs to be a number press any key to continue");
                    Console.ReadKey();
                }
            }
            else if(date[0] == "create")
            {
                NewStart();
                Encounters.FirstEncounter();

            }
            else
            {
                foreach(Player player in players)
                {
                    if(player.name == data[0])
                    {
                        return player;
                    }
                }
                WriteLine("There is no player with that name!");
                Console.ReadKey();

            }
        }
        catch(IndexOutOfRangeException)
        {
            WriteLine("Your id needs to be a number press any key to continue");
            Console.ReadKey();
        }


        
    }



   public static void WriteLine(string text, int speed = 60)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(98);
        }
        Console.WriteLine();
    } 
}  

}   