using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVariableShopReturns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 200;          
            short b = -12000;     
            int c = 150000;       
            long d = 9_000_000_000L; 

            sbyte e = -100;       
            ushort f = 60000;     
            uint g = 3_000_000_000; 
            ulong h = 18_000_000_000_000_000_000UL; 

            float i = 3.14f;      
            double j = 12345.6789; 
            decimal k = 9999.99m; 

            char l = 'Z';         
            string m = "CSharp";  
            bool n = false;

            Console.WriteLine($"a={a}, b={b}, c={c}, d={d}, e={e}, f={f}, g={g}, h={h}, i={i}, j={j}, k={k}, l={l}, m={m}, n={n}");


        }
    }
}
