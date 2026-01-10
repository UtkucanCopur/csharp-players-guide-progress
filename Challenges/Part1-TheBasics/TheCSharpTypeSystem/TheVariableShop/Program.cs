using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVariableShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            short b = 2;
            int c = 3;
            long d = 4;
            sbyte e = 5;
            ushort f = 6;
            uint g = 7;
            ulong h = 8;
            float i = 9.2f;
            double j = 10.5;
            decimal k = 15.4m;
            char l = 'a';
            string m = "word";
            bool n = true;
            Console.WriteLine($"Variables: {a} {b} {c} {d} {e} {f} {g} {h} {i} {j} {k} {l} {m} {n}");
        }
    }
}
