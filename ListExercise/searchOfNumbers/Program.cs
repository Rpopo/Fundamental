using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            List<int> integers = numbers.Split(new char[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            int[] masterNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            for (int i = 0; i < masterNumbers[0]; i++)
            {
                result.Add(integers[i]);
            }
            result.Remove(masterNumbers[1]);
            if (result.Contains(masterNumbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
