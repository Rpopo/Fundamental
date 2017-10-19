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
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var count = new SortedDictionary<double, int>();
            foreach (var item in numbers)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count[item] = 1;
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine("{0} - > {1}",count.Select(x=>x.Key));
            }
        }
    }
}
