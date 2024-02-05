using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Neoa
{
    class Program
    {
        public static void Main(string[] args)
        {
      WriteLine("The KINGDOM OF NEOA:");
      WriteLine("Greetings..");
      WriteLine("..Hm I can't seem to think of your name");


             
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

      