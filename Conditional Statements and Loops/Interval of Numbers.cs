using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrintSequanceNumbers(start, end);
        }

        static void PrintSequanceNumbers(int start, int end)
        {
            int bigest = Math.Max(start, end);
            int lowest = Math.Min(start, end);
            for (int i = lowest; i <= bigest; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
