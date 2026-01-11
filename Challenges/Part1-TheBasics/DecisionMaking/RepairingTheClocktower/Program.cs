using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheClocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Tick");
            } else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
