using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            List<int> integers = numbers.Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 1; i < integers.Count; i++)
            {
                if (integers[i] == integers[i - 1])
                {
                    len++;
                }
                else
                {
                    if (bestLen < len)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                    start = i;
                    len = 1;
                }
                if (bestLen < len)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(integers[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
