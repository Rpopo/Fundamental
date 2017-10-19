using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverageOfListNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            var instruction = new Dictionary<string,int>();
            foreach (var elements in numbers)
            {
                
            }
        }
    }
}
