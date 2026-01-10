using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThingNamer3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine(); //name of machine
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine();
            /*
             * i created here based on what i want to do
             */
            string c = "The Thing Namer";
            string d = "3000";
            Console.WriteLine($"Your {c} {d} is working fine");
        }
    }
}
