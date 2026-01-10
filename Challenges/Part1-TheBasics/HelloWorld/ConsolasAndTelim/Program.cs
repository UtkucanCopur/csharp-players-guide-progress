using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolasAndTelim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread is ready \nWho is the bread for?");
            string input = Console.ReadLine();
            Console.WriteLine($"Noted: {input} got bread");
        }
    }
}
