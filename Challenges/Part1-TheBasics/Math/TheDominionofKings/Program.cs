using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDominionofKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter provinces: ");
            int provinceNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter duchy: ");
            int duchyNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter estate: ");
            int estateNum = int.Parse(Console.ReadLine());
            int total = provinceNum * 6 + duchyNum * 3 + estateNum;
            Console.WriteLine($"Total point: {total}");
            
        }
    }
}
