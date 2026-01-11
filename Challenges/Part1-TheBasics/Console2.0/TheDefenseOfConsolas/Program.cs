using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDefenseOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter column: ");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"{row},{col-1}");
            Console.WriteLine($"{row},{col+1}");
            Console.WriteLine($"{row-1},{col}");
            Console.WriteLine($"{row+1},{col}");
            Console.Title = "Defense of Consolas";
            Console.Beep();
        }
    }
}
