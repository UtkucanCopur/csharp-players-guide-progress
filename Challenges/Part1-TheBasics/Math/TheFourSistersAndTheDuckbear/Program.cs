using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourSistersAndTheDuckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter eggs number:");
            int eggs = int.Parse(Console.ReadLine());
            int sistersEggs = eggs / 4;
            Console.WriteLine($"Sisters eggs for each: {sistersEggs}");
            int duckbearEggs = eggs % 4;
            Console.WriteLine($"Duckbear eggs: {duckbearEggs}");
        }
    }
}
