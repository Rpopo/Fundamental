using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var variableTypes = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (variableTypes.ContainsKey(item))
                {
                    variableTypes[item]++;
                }
                else
                {
                    variableTypes[item] = 1;
                }
            }

            foreach (var item in variableTypes)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
