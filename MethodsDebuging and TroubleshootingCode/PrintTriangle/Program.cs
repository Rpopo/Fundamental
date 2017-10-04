using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte N = sbyte.Parse(Console.ReadLine());
            PrintTopTrianglePart(N);
            PrintBottomTrianglePart(N);
        }
        static void PrintTopTrianglePart(sbyte n)
        {
            for (int g = 0; g <= n; g++)
            {
                for (int i = 1; i <= g; i++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void PrintBottomTrianglePart(sbyte n)
        {
            for (int g = 0; g < n-1; g++)
            {
                for (int i = 1; i <n-g; i++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
