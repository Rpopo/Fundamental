using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            List<int> integers = numbers.Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < integers.Count; i++)
            {
                char[] digit = integers[i].ToString().ToCharArray();
                string reversedDigit = string.Empty;
                for (int g = digit.Length-1; g >= 0; g--)
                {
                    reversedDigit += digit[g];
                }
                integers[i] = int.Parse(reversedDigit);
            }
            for (int i = 0; i < integers.Count; i++)
            {
                sum += integers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
