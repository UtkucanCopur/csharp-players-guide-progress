using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x value: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y value: ");
            int y = int.Parse(Console.ReadLine());
            if(x > 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("The enemy is to the NE");
                } else if (y < 0)
                {
                    Console.WriteLine("The enemy is to the SE");
                } else
                {
                    Console.WriteLine("The enemy is to the E");
                }
            } else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("The enemy is to the NW");
                }
                else if (y < 0)
                {
                    Console.WriteLine("The enemy is to the SW");
                }
                else
                {
                    Console.WriteLine("The enemy is to the W");
                }
            } else
            {
                if (y > 0)
                {
                    Console.WriteLine("The enemy is to the N");
                }
                else if (y < 0)
                {
                    Console.WriteLine("The enemy is to the S");
                }
                else
                {
                    Console.WriteLine("The enemy is here!");
                }
            }
            
        }
    }
}
