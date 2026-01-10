using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the base size");
            float baseSize = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Give the height");
            float height = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            float triangleArea = (baseSize * height) / 2;
            if(triangleArea > 0)
            {
                Console.WriteLine($"Area: {triangleArea}");
            } else
            {
                Console.WriteLine("Wrong output");
            }
        }
    }
}
